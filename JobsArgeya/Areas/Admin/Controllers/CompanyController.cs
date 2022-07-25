using JobsArgeya.Areas.Admin.Models;
using JobsArgeya.Business;
using JobsArgeya.Data.Context;
using JobsArgeya.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin")]
    public class CompanyController : Controller
    {

        private readonly DatabaseContext _databaseContext;
        private IWebHostEnvironment _hostingEnvironment;
        public CompanyController(DatabaseContext databaseContext, IWebHostEnvironment environment)
        {
            _databaseContext = databaseContext;
            _hostingEnvironment = environment;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Company> DbCompany = _databaseContext.Companies.ToList();
            List<CompanyViewModel> AllCompanies = new List<CompanyViewModel>();

            foreach(Company Company in DbCompany)
            {
                CompanyViewModel CompanyVm = new CompanyViewModel();
                CompanyVm.Id = Company.Id;
                CompanyVm.CompanyName = Company.CompanyName;
                CompanyVm.CompanyDomain = Company.CompanyDomain;
                AllCompanies.Add(CompanyVm);
            }

            return View(AllCompanies);
        }
        [HttpGet]
        public IActionResult Add()
        {
            /*List<Users> DbUsers = _databaseContext.Users.Where(x => x.CompanyId == 0).ToList();
            List<UsersModel> AllUsers = new List<UsersModel>();

            foreach (Users Users in DbUsers)
            {
                UsersModel Model = new UsersModel();
                Model.Id = Users.Id;
                Model.Name = Users.Name;
                Model.Surname = Users.Surname;
                Model.Email = Users.Email;
                AllUsers.Add(Model);
            }
            return View(AllUsers);*/
            return View();
        }
        [HttpPost]
        public IActionResult Add(CompanyViewModel Model)
        {
            if (ModelState.IsValid)
            {
                if (_databaseContext.Companies.Any(x => x.CompanyDomain == Model.CompanyDomain))
                {
                    TempData["dangerMessage"] = "Bu domainde başka şirket bulunmakta. Lütfen tekrar deneyiniz.";
                }
                else
                {
                    var Company = new Company
                    {
                        CompanyName = Model.CompanyName,
                        CompanyDomain = Model.CompanyDomain
                    };

                    _databaseContext.Companies.Add(Company);
                    _databaseContext.SaveChanges();

                    _databaseContext.Settings.Add(new Settings
                    {
                        Title = "Lütfen Site Başlığı Girin",
                        Keywords = "Lütfen Site Anahtar Kelimelerini Girin",
                        Description = "Lütfen Site Açıklaması Girin",
                        Email = "Lütfen Email Adresi Girin",
                        Phone = "Lütfen Telefon Nuamrası Girin",
                        Adress = "Lütfen Ofis Adresi Girin",
                        Facebook = "#",
                        Instagram = "#",
                        Twitter = "#",
                        Linkedin = "#",
                        SmtpServer = "smtp.test.com",
                        SmtpUsername = "test@test.com",
                        SmtpPassword = "test",
                        SmtpPort = "465",
                        Logo = "logo.png",
                        UseSSL = "true",
                        CompanyId = Company.Id,
                        SiteColor = "#DC3545"
                    });
                    _databaseContext.SaveChanges();
                    TempData["successMessage"] = "Şirket başarıyla eklendi.";
                    return Redirect("/admin/company/index");
                }
            }
            TempData["dangerMessage"] = "Zorunlu olan alanları doldurup tekrar deneyiniz.";
            return Redirect("/admin/company/index");
        }
        [HttpPost]
        public IActionResult Edit(CompanyModel Model)
        {
            if (ModelState.IsValid)
            {
                var DbCompany = _databaseContext.Companies.Where(x => x.Id == Model.CompanyId).FirstOrDefault();
                DbCompany.CompanyName = Model.CompanyName;
                DbCompany.CompanyDomain = Model.CompanyDomain;
                _databaseContext.SaveChanges();
                TempData["successMessage"] = "Şirket başarıyla güncellendi.";
                return Redirect("/admin/user/index");
            }
            TempData["dangerMessage"] = "Şirket güncellenirken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
            return Redirect("/admin/company/index");
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            if (Id != 0)
            {
                var Company = _databaseContext.Companies.Where(x => x.Id == Id).FirstOrDefault();
                var User = _databaseContext.Users.Where(x => x.CompanyId == Company.Id).FirstOrDefault();
                var Settings = _databaseContext.Settings.Where(x => x.CompanyId == Company.Id).FirstOrDefault();
                var Jobs = _databaseContext.Jobs.Where(x => x.CompanyId == Company.Id).ToList();
                var Applies = _databaseContext.Applies.Where(x => x.CompanyId == Company.Id).ToList();
                var Contacts = _databaseContext.Contact.Where(x => x.CompanyId == Company.Id).ToList();
                if (Company != null)
                {
                    _databaseContext.Companies.Remove(Company);
                    _databaseContext.Settings.Remove(Settings);
                    _databaseContext.Jobs.RemoveRange(Jobs);
                    _databaseContext.Applies.RemoveRange(Applies);
                    _databaseContext.Contact.RemoveRange(Contacts);
                    if (User != null)
                    {
                        User.CompanyId = 0;
                    }
                    _databaseContext.SaveChanges();
                    TempData["successMessage"] = "Şirket başarıyla silindi.";
                }
                else
                {
                    TempData["dangerMessage"] = "Şirket bulunamadı. Lütfen tekrar deneyiniz.";
                }
            }
            else
            {
                TempData["dangerMessage"] = "Geçersiz şirket bilgisi girdiniz. Lütfen tekrar deneyiniz.";
            }

            return Redirect("/admin/company/index");
        }
        [HttpGet]
        public IActionResult Settings(int Id)
        {
            List <Settings> DbSettings = _databaseContext.Settings.Where(x => x.CompanyId == Id).ToList();
            List<SettingsViewModel> AllSettings = new List<SettingsViewModel>();

            foreach (Settings Settings in DbSettings)
            {
                SettingsViewModel SettingsVm = new SettingsViewModel();
                SettingsVm.Id = Settings.Id;
                SettingsVm.Title = Settings.Title;
                SettingsVm.Description = Settings.Description;
                SettingsVm.Keywords = Settings.Keywords;
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
                SettingsVm.CompanyId = Settings.CompanyId;
                SettingsVm.SiteColor = Settings.SiteColor;
                SettingsVm.DarkLogo = Settings.DarkLogo;
                SettingsVm.Logo = Settings.Logo;
                AllSettings.Add(SettingsVm);
            }
            return View(AllSettings);
        }
        [HttpPost]
        public IActionResult Settings(SettingsModel Settings, IFormFile Logo, IFormFile DarkLogo)
        {
            int CompanyId = Settings.CompanyId;
            List<Settings> DbSettings = _databaseContext.Settings.Where(x => x.CompanyId == CompanyId).ToList();
            List<SettingsViewModel> AllSettings = new List<SettingsViewModel>();

            if (Logo != null && DarkLogo != null)
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
                        if (Settings.UseSSL == "on")
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
                    var Db = _databaseContext.Settings.Where(x => x.CompanyId == CompanyId).FirstOrDefault();
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
                    if (Settings.UseSSL == "on")
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
                var Db = _databaseContext.Settings.Where(x => x.CompanyId == CompanyId).FirstOrDefault();
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
