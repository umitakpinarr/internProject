using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsArgeya.Models;
using Microsoft.AspNetCore.Hosting;
using JobsArgeya.Data.Context;
using Microsoft.Extensions.Configuration;
using JobsArgeya.Business;
using JobsArgeya.Data.Entities;
using System.Text.RegularExpressions;

namespace JobsArgeya.Controllers
{
    public class ContactController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        private IWebHostEnvironment _hostingEnvironment;
        private readonly IConfiguration _configuration;
        public ContactController(DatabaseContext databaseContext, IWebHostEnvironment environment, IConfiguration configuration)
        {
            _databaseContext = databaseContext;
            _hostingEnvironment = environment;
            _configuration = configuration;
        }
        [HttpGet]
        public IActionResult Index()
        {
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            string Host = Request.Host.ToString();
            var DbCompany = _databaseContext.Companies.Where(x => x.CompanyDomain == Host).FirstOrDefault();
            ViewData["SiteColor"] = _databaseContext.Settings.Where(x => x.CompanyId == DbCompany.Id).Select(x => x.SiteColor).FirstOrDefault();
            ViewData["SiteName"] = Details.GetSiteDetails(3, Host);
            ViewData["FavIcon"] = Details.GetSiteDetails(7, Host);
            return View();
        }
        [HttpPost]
        public IActionResult Index(ContactModel Model)
        {
            CaptchaController CaptchaController = new CaptchaController();
            if (!CaptchaController.IsValid(Model.captcha, HttpContext.Session))
            {
                TempData["dangerMessage"] = "Yanlış captcha girişi yaptınız. Lütfen tekrar deneyiniz.";
                return Redirect(Request.Headers["Referer"].ToString());
            }

            string Host = Request.Host.ToString();
            var DbCompany = _databaseContext.Companies.Where(x => x.CompanyDomain == Host).FirstOrDefault();
            if(ModelState.IsValid)
            {
                string RegexPattern = @"^(05(\d{9}))$";
                if (Regex.IsMatch(Model.Phone, RegexPattern) == true)
                {
                    _databaseContext.Contact.Add(new Contact
                    {
                        Name = Model.Name,
                        Email = Model.Email,
                        Phone = Model.Phone,
                        Subject = Model.Subject,
                        Message = Model.Message,
                        CompanyId = DbCompany.Id
                    });
                    _databaseContext.SaveChanges();
                    TempData["successMessage"] = "Mesajınızı aldık. En kısa sürede tarafınıza dönüş sağlayacağız.";
                }
                else
                {
                    TempData["dangerMessage"] = "Telefon numarasını istenilen formatta girmediniz. (Örn. 05XXXXXXXXX) Lütfen tekrar deneyiniz.";
                }
            }
            else
            {
                TempData["dangerMessage"] = "Lütfen doldurulması gereken alanları doldup tekrar deneyin.";
            }

            return Redirect("/contact");
        }
    }
}
