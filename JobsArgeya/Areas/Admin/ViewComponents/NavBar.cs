using JobsArgeya.Areas.Admin.Models;
using JobsArgeya.Business;
using JobsArgeya.Data.Context;
using JobsArgeya.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Areas.Admin.ViewComponents
{
    [Area("Admin")]
    public class NavBar : ViewComponent
    {
        private readonly DatabaseContext _databaseContext;
        private IWebHostEnvironment _hostingEnvironment;
        private readonly IConfiguration _configuration;
        public NavBar(DatabaseContext databaseContext, IWebHostEnvironment environment, IConfiguration configuration)
        {
            _databaseContext = databaseContext;
            _hostingEnvironment = environment;
            _configuration = configuration;
        }
        public IViewComponentResult Invoke()
        {
            string host = Request.Host.ToString();
            GetDetails details = new GetDetails(_databaseContext, _configuration);
            ViewData["NavBarLogo"] = details.getSiteDetails(5, host);
            /*var dbOffice = _databaseContext.Offices.Where(x => x.officeDomain == host).FirstOrDefault();
            Settings dbSettings = _databaseContext.Settings.Where(x => x.officeId == dbOffice.id).FirstOrDefault();
            SettingsModel allSettings = new SettingsModel();

            allSettings.title = dbSettings.title;
            allSettings.keywords = dbSettings.keywords;
            allSettings.description = dbSettings.description;
            allSettings.email = dbSettings.email;
            allSettings.phone = dbSettings.phone;
            allSettings.adress = dbSettings.adress;
            allSettings.facebook = dbSettings.facebook;
            allSettings.instagram = dbSettings.instagram;
            allSettings.twitter = dbSettings.twitter;
            allSettings.linkedin = dbSettings.linkedin;
            allSettings.smtpServer = dbSettings.smtpServer;
            allSettings.smtpUsername = dbSettings.smtpUsername;
            allSettings.smtpPassword = dbSettings.smtpPassword;
            allSettings.smtpPort = dbSettings.smtpPort;
            allSettings.siteColor = dbSettings.siteColor;
            allSettings.logo = dbSettings.logo;

            return View(allSettings);*/
            return View();
        }
    }
}
