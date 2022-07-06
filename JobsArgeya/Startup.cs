using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using JobsArgeya.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace JobsArgeya
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.AddDbContext<DatabaseContext>(options => { options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")); });
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options => {
                options.LoginPath = "/admin/login";
                options.LogoutPath = "/admin/logout";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseAuthentication();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapAreaControllerRoute("Admin", "Admin", "Admin/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapAreaControllerRoute("AdminLogin", "Admin", "/yonetim/{controller=login}/{action=Index}");
                endpoints.MapAreaControllerRoute("Logout", "Admin", "/yonetim/{controller=login}/{action=SignOut}");

                endpoints.MapAreaControllerRoute("List", "Admin", "Admin/{controller=Jobs}/{action=List}");
                endpoints.MapAreaControllerRoute("List", "Admin", "Admin/{controller=Jobs}/{action=Add}");
                endpoints.MapAreaControllerRoute("List", "Admin", "Admin/{controller=Jobs}/{action=Edit}");
            });
        }
    }
}
