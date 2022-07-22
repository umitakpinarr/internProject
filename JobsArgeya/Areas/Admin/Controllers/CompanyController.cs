using JobsArgeya.Areas.Admin.Models;
using JobsArgeya.Data.Context;
using JobsArgeya.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
        public IActionResult Add()
        {
            List<Users> DbUsers = _databaseContext.Users.Where(x => x.CompanyId == 0).ToList();
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
            return View(AllUsers);
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

                    var User = _databaseContext.Users.Where(x => x.Id == Model.UserId).FirstOrDefault();
                    if(User != null)
                    {
                        User.CompanyId = Company.Id;
                        _databaseContext.SaveChanges();
                    }

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
                    return Redirect("/admin/user/index");
                }
            }
            return Redirect("/admin/user/index");
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
                TempData["successMessage"] = "Ofis başarıyla güncellendi.";
                return Redirect("/admin/user/index");
            }
            TempData["dangerMessage"] = "Ofis güncellenirken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
            return Redirect("/admin/user/index");
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
                    TempData["successMessage"] = "Kayıt başarıyla silindi.";
                }
                else
                {
                    TempData["dangerMessage"] = "Kayıt silinirken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
                }
            }
            else
            {
                TempData["dangerMessage"] = "Kayıt silinirken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
            }

            return Redirect("/admin/user/index");
        }
    }
}
