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
            GetDetails details = new GetDetails(_databaseContext, _configuration);
            string host = Request.Host.ToString();
            var dbOffice = _databaseContext.Offices.Where(x => x.officeDomain == host).FirstOrDefault();
            ViewData["SiteColor"] = _databaseContext.Settings.Where(x => x.officeId == dbOffice.id).Select(x => x.siteColor).FirstOrDefault();
            ViewData["SiteName"] = details.getSiteDetails(3, host);
            return View();
        }
        [HttpPost]
        public IActionResult Index(ContactModel Model)
        {
            CaptchaController captchaController = new CaptchaController();
            if (!captchaController.IsValid(Model.captcha, HttpContext.Session))
            {
                TempData["dangerMessage"] = "Yanlış captcha girişi yaptınız. Lütfen tekrar deneyiniz.";
                return Redirect(Request.Headers["Referer"].ToString());
            }

            string host = Request.Host.ToString();
            var dbOffice = _databaseContext.Offices.Where(x => x.officeDomain == host).FirstOrDefault();
            if(ModelState.IsValid)
            {
                string regexPattern = @"^(05(\d{9}))$";
                if (Regex.IsMatch(Model.Phone, regexPattern) == true)
                {
                    _databaseContext.Contact.Add(new Contact
                    {
                        Name = Model.Name,
                        Email = Model.Email,
                        Phone = Model.Phone,
                        Subject = Model.Subject,
                        Message = Model.Message,
                        OfficeId = dbOffice.id
                    });
                    _databaseContext.SaveChanges();
                    TempData["successMessage"] = "Mesajınızı aldık. En kısa sürede tarafınıza dönüş sağlayacağız.";
                }
                else
                {
                    TempData["dangerMessage"] = "Telefon numarasını istenilen formatta girmediniz. Lütfen tekrar deneyiniz.";
                }
            }
            else
            {
                TempData["dangerMessage"] = "Mesajınız gönderilemedi. Lütfen daha sonra tekrar deneyiniz.";
            }

            return Redirect("/contact");
        }
    }
}
