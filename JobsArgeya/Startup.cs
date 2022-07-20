using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using JobsArgeya.Data.Context;
using JobsArgeya.Business;
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
            services.AddMvc().AddSessionStateTempDataProvider();
            services.AddSession();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
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
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "index",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                /*endpoints.MapControllerRoute(
                    name:"office",
                    pattern:"{controller=Office}/{action=Index}/{id?}");*/
                /*endpoints.MapControllerRoute(
                    name: "jobDetail",
                    pattern: "{controller=JobDetail}/{action=Index}/{slug?}");*/

                endpoints.MapAreaControllerRoute("Admin", "Admin", "Admin/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapAreaControllerRoute("AdminLogin", "Admin", "/yonetim/{controller=login}/{action=Index}");
                endpoints.MapAreaControllerRoute("Logout", "Admin", "/yonetim/{controller=login}/{action=SignOut}");

                endpoints.MapAreaControllerRoute("ApplyDelete", "Admin", "Admin/{controller=Home}/{action=Delete}/{id?}");

                endpoints.MapAreaControllerRoute("JobsList", "Admin", "Admin/{controller=Jobs}/{action=List}");
                endpoints.MapAreaControllerRoute("JobsAdd", "Admin", "Admin/{controller=Jobs}/{action=Add}");
                endpoints.MapAreaControllerRoute("JobsEdit", "Admin", "Admin/{controller=Jobs}/{action=Edit}/{id?}");
                endpoints.MapAreaControllerRoute("JobsDelete", "Admin", "Admin/{controller=Jobs}/{action=Delete}/{id?}");

                endpoints.MapAreaControllerRoute("Settings", "Admin", "Admin/{controller=Settings}/{action=Index}");

                endpoints.MapAreaControllerRoute("MailList", "Admin", "Admin/{controller=Mail}/{action=Index}");
                //endpoints.MapAreaControllerRoute("MailSend", "Admin", "Admin/{controller=Mail}/{action=Send}");
                endpoints.MapAreaControllerRoute("MailDelete", "Admin", "Admin/{controller=Mail}/{action=Delete}/{id?}");

                endpoints.MapControllerRoute(name: "captcha", pattern: "argeya-captcha", defaults: new { controller = "captcha", action = "getImage" });
            });
        }
    }
}
