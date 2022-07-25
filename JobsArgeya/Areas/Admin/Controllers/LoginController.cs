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
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            string Host = Request.Host.ToString();
            ViewData["LightLogo"] = Details.GetSiteDetails(5, Host);
            ViewData["DarkLogo"] = Details.GetSiteDetails(6, Host);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UsersModel User)
        {
            if (ModelState.IsValid)
            {
                string PasswordHashed = MD5Hash.Hash.Content(User.Password);
                string Host = Request.Host.ToString();
                Company DbCompany = _databaseContext.Companies.Where(o => o.CompanyDomain == Host).FirstOrDefault();
                Users DbUser = _databaseContext.Users.Where(u => u.Email == User.Email && u.Password == PasswordHashed && u.CompanyId == DbCompany.Id).FirstOrDefault();
                if (DbUser != null && DbUser.IsActive == 1)
                {
                    Roles dbRole = _databaseContext.Roles.Where(x => x.Id == DbUser.RoleId).FirstOrDefault();
                        var claims = new List<Claim>
                        {
                            new Claim("FullName", DbUser.Name + " " + DbUser.Surname),
                            new Claim("UserId", DbUser.Id.ToString()),
                            new Claim("OfficeId", DbCompany.Id.ToString()),
                            new Claim("OfficeName", DbCompany.CompanyName),
                            new Claim(ClaimTypes.Role, dbRole.RoleName)
                        };

                    var ClaimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(ClaimsIdentity));
                    return Redirect("/admin/home/index");
                }
                else
                {
                    TempData["DangerMessage"] = "Kullanıcı adı veya şifre hatalı. Lütfen tekrar deneyiniz.";
                }
            }
            else
            {
                TempData["DangerMessage"] = "Lütfen boş bırakılan alanları doldurun ve tekrar deneyin.";
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
