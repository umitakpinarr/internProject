using JobsArgeya.Areas.Admin.Models;
using JobsArgeya.Data.Context;
using JobsArgeya.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.ViewComponents
{
    public class Header : ViewComponent
    {
        private readonly DatabaseContext _databaseContext;
        private IWebHostEnvironment _hostingEnvironment;
        public Header(DatabaseContext databaseContext, IWebHostEnvironment environment)
        {
            _databaseContext = databaseContext;
            _hostingEnvironment = environment;
        }
        public IViewComponentResult Invoke()
        {
            Settings dbSettings = _databaseContext.Settings.Where(x => x.id == 1).FirstOrDefault();
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
            allSettings.logo = dbSettings.logo;

            return View(allSettings);
        }

    }
}
