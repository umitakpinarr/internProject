using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsArgeya.Data.Entities;
using JobsArgeya.Data.Context;
using Microsoft.Extensions.Configuration;
using JobsArgeya.Areas.Admin.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using JobsArgeya.Business;

namespace JobsArgeya.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        private readonly IConfiguration _configuration;


        public LoginController(DatabaseContext databaseContext, IConfiguration configuration)
        {
            _databaseContext = databaseContext;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            GetDetails details = new GetDetails(_databaseContext, _configuration);
            string host = Request.Host.ToString();
            ViewData["PanelLogo"] = details.getSiteDetails(5, host);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UsersModel user)
        {
            string passwordHashed = MD5Hash.Hash.Content(user.password);
            string host = Request.Host.ToString();
            Offices dbOffice = _databaseContext.Offices.Where(o => o.officeDomain == host).FirstOrDefault();
            Users dbUser = _databaseContext.Users.Where(u => u.email == user.email && u.password == passwordHashed && u.officeId == dbOffice.id).FirstOrDefault();
         
            if(dbUser != null)
            {
                Roles dbRole = _databaseContext.Roles.Where(x => x.id == dbUser.roleId).FirstOrDefault();
                var claims = new List<Claim>
                {
                    new Claim("fullName", dbUser.name + " " + dbUser.surname),
                    new Claim("userId", dbUser.id.ToString()),
                    new Claim("officeId", dbOffice.id.ToString()),
                    new Claim("officeName", dbOffice.officeName),
                    new Claim(ClaimTypes.Role, dbRole.roleName)
                };
                
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                return Redirect("/admin/home/index");
            }
            return Redirect("/yonetim");
        }
        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/admin/home/index");
        }
    }
}
