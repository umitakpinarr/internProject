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
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UsersModel user)
        {
            string passwordHashed = MD5Hash.Hash.Content(user.password);
            Users dbUser = _databaseContext.Users.Where(u => u.email == user.email && u.password == passwordHashed).FirstOrDefault();
            Offices dbOffice = _databaseContext.Offices.Where(o => o.id == dbUser.officeId).FirstOrDefault();
            if(dbUser != null)
            {
                var claims = new List<Claim>
                {
                    new Claim("fullName", dbUser.name + " " + dbUser.surname),
                    new Claim("roleName", "Admin"),
                    new Claim("userId", dbUser.id.ToString()),
                    new Claim("officeId", dbOffice.id.ToString()),
                    new Claim("officeName", dbOffice.officeName)
                };
                
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                return Redirect("/admin/home/index");
            }
            return View(null);
        }
        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/admin/home/index");
        }
    }
}
