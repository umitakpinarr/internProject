using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsArgeya.Areas.Admin.Models;
using JobsArgeya.Data.Entities;
using JobsArgeya.Data.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace JobsArgeya.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class SettingsController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        private IWebHostEnvironment _hostingEnvironment;
        public SettingsController(DatabaseContext databaseContext, IWebHostEnvironment environment)
        {
            _databaseContext = databaseContext;
            _hostingEnvironment = environment;
        }
        [HttpGet]
        public IActionResult Index()
        {
            int OfficeId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "OfficeId").Value);
            List<Settings> DbSettings = _databaseContext.Settings.Where(x=> x.CompanyId == OfficeId).ToList();
            List<SettingsViewModel> AllSettings = new List<SettingsViewModel>();

            foreach (Settings Settings in DbSettings)
            {
                SettingsViewModel SettingsVm = new SettingsViewModel();
                SettingsVm.Title = Settings.Title;
                SettingsVm.Keywords = Settings.Keywords;
                SettingsVm.Description = Settings.Description;
                SettingsVm.Email = Settings.Email;
                SettingsVm.Phone = Settings.Phone;
                SettingsVm.Adress = Settings.Adress;
                SettingsVm.Facebook = Settings.Facebook;
                SettingsVm.Instagram = Settings.Instagram;
                SettingsVm.Twitter = Settings.Twitter;
                SettingsVm.Linkedin = Settings.Linkedin;
                SettingsVm.SmtpServer = Settings.SmtpServer;
                SettingsVm.SmtpUsername = Settings.SmtpUsername;
                SettingsVm.SmtpPassword = Settings.SmtpPassword;
                SettingsVm.SmtpPort = Settings.SmtpPort;
                SettingsVm.UseSSL = Settings.UseSSL;
                SettingsVm.SiteColor = Settings.SiteColor;
                SettingsVm.Logo = Settings.Logo;

                AllSettings.Add(SettingsVm);
            }

            return View(AllSettings);
        }

        [HttpPost]
        public IActionResult Index(SettingsModel Settings, IFormFile Logo, IFormFile DarkLogo)
        {
            int OfficeId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "OfficeId").Value);
            List<Settings> DbSettings = _databaseContext.Settings.Where(x=> x.CompanyId == OfficeId).ToList();
            List<SettingsViewModel> AllSettings = new List<SettingsViewModel>();

            if(Logo != null && DarkLogo != null)
            {
                if (Logo.ContentType == "image/jpeg" || Logo.ContentType == "image/png" || Logo.ContentType == "image/svg+xml." && Logo != null && Logo.Length > 0)
                {
                    /*Dosya uzantısını alıyoruz*/
                    var Extension = System.IO.Path.GetExtension(Logo.FileName);
                    var DarkExtension = System.IO.Path.GetExtension(Logo.FileName);
                    /*Benzersiz bir dosya adı alıp uzantıyla birleştiriyoruz*/
                    var FileName = Guid.NewGuid() + Extension;
                    var DarkFileName = Guid.NewGuid() + Extension;
                    /*Dosyanın yükleneceği klasörün yolu*/
                    var Path = Directory.GetCurrentDirectory() + "\\wwwroot" + "\\uploads\\" + FileName;
                    var DarkPath = Directory.GetCurrentDirectory() + "\\wwwroot" + "\\uploads\\" + DarkFileName;
                    /*Dosya oluşturuluyor*/
                    FileStream Stream = new FileStream(Path, FileMode.Create);
                    FileStream Stream1 = new FileStream(DarkPath, FileMode.Create);
                    Logo.CopyTo(Stream);
                    DarkLogo.CopyTo(Stream1);

                    /*Db den gelen veriler settingsVM e atanıyor*/
                    foreach (Settings Setting in DbSettings)
                    {
                        SettingsViewModel SettingsVm = new SettingsViewModel();
                        SettingsVm.Title = Settings.Title;
                        SettingsVm.Keywords = Settings.Keywords;
                        SettingsVm.Description = Settings.Description;
                        SettingsVm.Email = Settings.Email;
                        SettingsVm.Phone = Settings.Phone;
                        SettingsVm.Adress = Settings.Adress;
                        SettingsVm.Facebook = Settings.Facebook;
                        SettingsVm.Instagram = Settings.Instagram;
                        SettingsVm.Twitter = Settings.Twitter;
                        SettingsVm.Linkedin = Settings.Linkedin;
                        SettingsVm.SmtpServer = Settings.SmtpServer;
                        SettingsVm.SmtpUsername = Settings.SmtpUsername;
                        SettingsVm.SmtpPassword = Settings.SmtpPassword;
                        SettingsVm.SmtpPort = Settings.SmtpPort;
                        if(Settings.UseSSL == "on")
                        {
                            SettingsVm.UseSSL = "true";
                        }
                        else
                        {
                            SettingsVm.UseSSL = "false";
                        }
                        SettingsVm.SiteColor = Settings.SiteColor;
                        SettingsVm.Logo = FileName;
                        SettingsVm.DarkLogo = DarkFileName;

                        AllSettings.Add(SettingsVm);
                    }
                    /* Ayar Update */
                    var Db = _databaseContext.Settings.Where(x => x.CompanyId == OfficeId).FirstOrDefault();
                    Db.Title = AllSettings[0].Title;
                    Db.Keywords = AllSettings[0].Keywords;
                    Db.Description = AllSettings[0].Description;
                    Db.Email = AllSettings[0].Email;
                    Db.Phone = AllSettings[0].Phone;
                    Db.Adress = AllSettings[0].Adress;
                    Db.Facebook = AllSettings[0].Facebook;
                    Db.Instagram = AllSettings[0].Instagram;
                    Db.Twitter = AllSettings[0].Twitter;
                    Db.Linkedin = AllSettings[0].Linkedin;
                    Db.SmtpServer = AllSettings[0].SmtpServer;
                    Db.SmtpUsername = AllSettings[0].SmtpUsername;
                    Db.SmtpPassword = AllSettings[0].SmtpPassword;
                    Db.SmtpPort = AllSettings[0].SmtpPort;
                    Db.UseSSL = AllSettings[0].UseSSL;
                    Db.SiteColor = AllSettings[0].SiteColor;
                    Db.Logo = FileName;
                    Db.DarkLogo = DarkFileName;
                    _databaseContext.SaveChanges();
                }
            }
            else
            {
                foreach (Settings Setting in DbSettings)
                {
                    SettingsViewModel SettingsVm = new SettingsViewModel();
                    SettingsVm.Title = Settings.Title;
                    SettingsVm.Keywords = Settings.Keywords;
                    SettingsVm.Description = Settings.Description;
                    SettingsVm.Email = Settings.Email;
                    SettingsVm.Phone = Settings.Phone;
                    SettingsVm.Adress = Settings.Adress;
                    SettingsVm.Facebook = Settings.Facebook;
                    SettingsVm.Instagram = Settings.Instagram;
                    SettingsVm.Twitter = Settings.Twitter;
                    SettingsVm.Linkedin = Settings.Linkedin;
                    SettingsVm.SmtpServer = Settings.SmtpServer;
                    SettingsVm.SmtpUsername = Settings.SmtpUsername;
                    SettingsVm.SmtpPassword = Settings.SmtpPassword;
                    SettingsVm.SmtpPort = Settings.SmtpPort;
                    if(Settings.UseSSL == "on")
                    {
                        SettingsVm.UseSSL = "true";
                    }
                    else
                    {
                        SettingsVm.UseSSL = "false";
                    }
                    SettingsVm.SiteColor = Settings.SiteColor;
                    AllSettings.Add(SettingsVm);
                }
                /* Ayar Update */
                var Db = _databaseContext.Settings.Where(x => x.CompanyId == OfficeId).FirstOrDefault();
                Db.Title = AllSettings[0].Title;
                Db.Keywords = AllSettings[0].Keywords;
                Db.Description = AllSettings[0].Description;
                Db.Email = AllSettings[0].Email;
                Db.Phone = AllSettings[0].Phone;
                Db.Adress = AllSettings[0].Adress;
                Db.Facebook = AllSettings[0].Facebook;
                Db.Instagram = AllSettings[0].Instagram;
                Db.Twitter = AllSettings[0].Twitter;
                Db.Linkedin = AllSettings[0].Linkedin;
                Db.SmtpServer = AllSettings[0].SmtpServer;
                Db.SmtpUsername = AllSettings[0].SmtpUsername;
                Db.SmtpPassword = AllSettings[0].SmtpPassword;
                Db.SmtpPort = AllSettings[0].SmtpPort;
                Db.UseSSL = AllSettings[0].UseSSL;
                Db.SiteColor = AllSettings[0].SiteColor;
                _databaseContext.SaveChanges();
            }
            
            TempData["successMessage"] = "Site ayarları başarıyla güncellendi.";
            return View(AllSettings);
        }
    }
}
