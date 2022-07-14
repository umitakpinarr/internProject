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
            List<Settings> dbSettings = _databaseContext.Settings.ToList();
            List<SettingsViewModel> allSettings = new List<SettingsViewModel>();

            foreach (Settings settings in dbSettings)
            {
                SettingsViewModel settingsVm = new SettingsViewModel();
                settingsVm.title = settings.title;
                settingsVm.keywords = settings.keywords;
                settingsVm.description = settings.description;
                settingsVm.email = settings.email;
                settingsVm.phone = settings.phone;
                settingsVm.adress = settings.adress;
                settingsVm.facebook = settings.facebook;
                settingsVm.instagram = settings.instagram;
                settingsVm.twitter = settings.twitter;
                settingsVm.linkedin = settings.linkedin;
                settingsVm.smtpServer = settings.smtpServer;
                settingsVm.smtpUsername = settings.smtpUsername;
                settingsVm.smtpPassword = settings.smtpPassword;
                settingsVm.smtpPort = settings.smtpPort;
                settingsVm.logo = settings.logo;

                allSettings.Add(settingsVm);
            }

            return View(allSettings);
        }

        [HttpPost]
        public IActionResult Index(SettingsModel settings, IFormFile logo)
        {
            List<Settings> dbSettings = _databaseContext.Settings.ToList();
            List<SettingsViewModel> allSettings = new List<SettingsViewModel>();

            if(logo != null)
            {
                if (logo.ContentType == "image/jpeg" || logo.ContentType == "image/png" || logo.ContentType == "image/svg+xml." && logo != null && logo.Length > 0)
                {
                    /*Dosya uzantısını alıyoruz*/
                    var extension = Path.GetExtension(logo.FileName);
                    /*Benzersiz bir dosya adı alıp uzantıyla birleştiriyoruz*/
                    var fileName = Guid.NewGuid() + extension;
                    /*Dosyanın yükleneceği klasörün yolu*/
                    var path = Directory.GetCurrentDirectory() + "\\wwwroot" + "\\uploads\\" + fileName;
                    /*Dosya oluşturuluyor*/
                    FileStream stream = new FileStream(path, FileMode.Create);
                    logo.CopyTo(stream);

                    /*Db den gelen veriler settingsVM e atanıyor*/
                    foreach (Settings setting in dbSettings)
                    {
                        SettingsViewModel settingsVm = new SettingsViewModel();
                        settingsVm.title = settings.title;
                        settingsVm.keywords = settings.keywords;
                        settingsVm.description = settings.description;
                        settingsVm.email = settings.email;
                        settingsVm.phone = settings.phone;
                        settingsVm.adress = settings.adress;
                        settingsVm.facebook = settings.facebook;
                        settingsVm.instagram = settings.instagram;
                        settingsVm.twitter = settings.twitter;
                        settingsVm.linkedin = settings.linkedin;
                        settingsVm.smtpServer = settings.smtpServer;
                        settingsVm.smtpUsername = settings.smtpUsername;
                        settingsVm.smtpPassword = settings.smtpPassword;
                        settingsVm.smtpPort = settings.smtpPort;
                        settingsVm.logo = fileName;

                        allSettings.Add(settingsVm);
                    }
                    /* Ayar Update */
                    var db = _databaseContext.Settings.Where(x => x.id == 1).FirstOrDefault();
                    db.title = allSettings[0].title;
                    db.keywords = allSettings[0].keywords;
                    db.description = allSettings[0].description;
                    db.email = allSettings[0].email;
                    db.phone = allSettings[0].phone;
                    db.adress = allSettings[0].adress;
                    db.facebook = allSettings[0].facebook;
                    db.instagram = allSettings[0].instagram;
                    db.twitter = allSettings[0].twitter;
                    db.linkedin = allSettings[0].linkedin;
                    db.smtpServer = allSettings[0].smtpServer;
                    db.smtpUsername = allSettings[0].smtpUsername;
                    db.smtpPassword = allSettings[0].smtpPassword;
                    db.smtpPort = allSettings[0].smtpPort;
                    db.logo = fileName;
                    _databaseContext.SaveChanges();
                }
            }
            else
            {
                foreach (Settings setting in dbSettings)
                {
                    SettingsViewModel settingsVm = new SettingsViewModel();
                    settingsVm.title = settings.title;
                    settingsVm.keywords = settings.keywords;
                    settingsVm.description = settings.description;
                    settingsVm.email = settings.email;
                    settingsVm.phone = settings.phone;
                    settingsVm.adress = settings.adress;
                    settingsVm.facebook = settings.facebook;
                    settingsVm.instagram = settings.instagram;
                    settingsVm.twitter = settings.twitter;
                    settingsVm.linkedin = settings.linkedin;
                    settingsVm.smtpServer = settings.smtpServer;
                    settingsVm.smtpUsername = settings.smtpUsername;
                    settingsVm.smtpPassword = settings.smtpPassword;
                    settingsVm.smtpPort = settings.smtpPort;

                    allSettings.Add(settingsVm);
                }
                /* Ayar Update */
                var db = _databaseContext.Settings.Where(x => x.id == 1).FirstOrDefault();
                db.title = allSettings[0].title;
                db.keywords = allSettings[0].keywords;
                db.description = allSettings[0].description;
                db.email = allSettings[0].email;
                db.phone = allSettings[0].phone;
                db.adress = allSettings[0].adress;
                db.facebook = allSettings[0].facebook;
                db.instagram = allSettings[0].instagram;
                db.twitter = allSettings[0].twitter;
                db.linkedin = allSettings[0].linkedin;
                db.smtpServer = allSettings[0].smtpServer;
                db.smtpUsername = allSettings[0].smtpUsername;
                db.smtpPassword = allSettings[0].smtpPassword;
                db.smtpPort = allSettings[0].smtpPort;
                _databaseContext.SaveChanges();
            }
            
            TempData["successMessage"] = "Site ayarları başarıyla güncellendi.";
            return View(allSettings);
        }
    }
}
