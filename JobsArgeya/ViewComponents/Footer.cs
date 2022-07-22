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
    public class Footer : ViewComponent
    {
        private readonly DatabaseContext _databaseContext;
        private IWebHostEnvironment _hostingEnvironment;
        public Footer(DatabaseContext databaseContext, IWebHostEnvironment environment)
        {
            _databaseContext = databaseContext;
            _hostingEnvironment = environment;
        }
        public IViewComponentResult Invoke()
        {
            string Host = Request.Host.ToString();
            var DbCompany = _databaseContext.Companies.Where(x => x.CompanyDomain == Host).FirstOrDefault();
            Settings DbSettings = _databaseContext.Settings.Where(x => x.CompanyId == DbCompany.Id).FirstOrDefault();
            SettingsModel AllSettings = new SettingsModel();

            AllSettings.Title = DbSettings.Title;
            AllSettings.Keywords = DbSettings.Keywords;
            AllSettings.Description = DbSettings.Description;
            AllSettings.Email = DbSettings.Email;
            AllSettings.Phone = DbSettings.Phone;
            AllSettings.Adress = DbSettings.Adress;
            AllSettings.Facebook = DbSettings.Facebook;
            AllSettings.Instagram = DbSettings.Instagram;
            AllSettings.Twitter = DbSettings.Twitter;
            AllSettings.Linkedin = DbSettings.Linkedin;
            AllSettings.SmtpServer = DbSettings.SmtpServer;
            AllSettings.SmtpUsername = DbSettings.SmtpUsername;
            AllSettings.SmtpPassword = DbSettings.SmtpPassword;
            AllSettings.SmtpPort = DbSettings.SmtpPort;
            AllSettings.SiteColor = DbSettings.SiteColor;
            AllSettings.Logo = DbSettings.Logo;

            return View(AllSettings);
        }
    }
}
