using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsArgeya.Data.Entities;
using JobsArgeya.Data.Context;
using JobsArgeya.Areas.Admin.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;
using JobsArgeya.Business;

namespace JobsArgeya.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin")]
    public class UserController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        private readonly IConfiguration _configuration;

        public UserController(DatabaseContext databaseContext, IConfiguration configuration)
        {
            _databaseContext = databaseContext;
            _configuration = configuration;
        }
        [HttpGet]
        public IActionResult Index()
        {
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            List<Users> DbUsers = _databaseContext.Users.ToList();
            List<UsersViewModel> AllUsers = new List<UsersViewModel>();

            foreach (Users User in DbUsers)
            {
                UsersViewModel UserVm = new UsersViewModel();
                UserVm.Id = User.Id;
                UserVm.Name = User.Name;
                UserVm.Surname = User.Surname;
                UserVm.Email = User.Email;
                UserVm.CompanyId = Convert.ToInt32(Details.GetUserCompany(User.Id, 3));
                UserVm.CompanyName = Details.GetUserCompany(User.Id, 1);
                UserVm.CompanyDomain = Details.GetUserCompany(User.Id, 2);
                AllUsers.Add(UserVm);
            }
            return View(AllUsers);
        }
        [HttpGet]
        public IActionResult Add()
        {
            List<Roles> DbRoles = _databaseContext.Roles.ToList();
            List<RoleModel> AllRoles = new List<RoleModel>();

            foreach (Roles Role in DbRoles)
            {
                RoleModel UserRole = new RoleModel();
                UserRole.Id = Role.Id;
                UserRole.RoleName = Role.RoleName;
                AllRoles.Add(UserRole);
            }
            return View(AllRoles);
        }
        [HttpPost]
        public IActionResult Add(UsersViewModel Model)
        {
            if (ModelState.IsValid)
            {
                if(_databaseContext.Companies.Any(x=> x.CompanyDomain == Model.CompanyDomain) || _databaseContext.Users.Any(x=> x.Email == Model.Email))
                {
                    TempData["dangerMessage"] = "Bu bilgilerle başka kullanıcı/ofis bulunmakta. Lütfen tekrar deneyiniz.";
                }
                else
                {
                    var Office = new Company
                    {
                        CompanyName = Model.CompanyName,
                        CompanyDomain = Model.CompanyDomain
                    };

                    _databaseContext.Companies.Add(Office);
                    _databaseContext.SaveChanges();

                    _databaseContext.Users.Add(new Users
                    {
                        Name = Model.Name,
                        Surname = Model.Surname,
                        Email = Model.Email,
                        Password = MD5Hash.Hash.Content(Model.Password),
                        CompanyId = Office.Id,
                        RoleId = Model.RoleId
                    });

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
                        CompanyId = Office.Id,
                        SiteColor = "#DC3545"
                    });
                    _databaseContext.SaveChanges();
                    TempData["successMessage"] = "Kullanıcı başarıyla eklendi.";
                    return Redirect("/admin/user/index");
                }
            }
            //TempData["dangerMessage"] = "Kullanıcı eklenirken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
            return Redirect("/admin/user/index");
        }
        [HttpPost]
        public IActionResult Edit(UsersModel Model)
        {
            if (ModelState.IsValid)
            {
                    var DbUser = _databaseContext.Users.Where(x => x.Id == Model.Id).FirstOrDefault();
                    DbUser.Name = Model.Name;
                    DbUser.Surname = Model.Surname;
                    DbUser.Email = Model.Email;
                    DbUser.Password = MD5Hash.Hash.Content(Model.password);
                    _databaseContext.SaveChanges();
                    TempData["successMessage"] = "Kullanıcı başarıyla güncellendi.";
                    return Redirect("/admin/user/index");
            }
            TempData["dangerMessage"] = "Kullanıcı güncellenirken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
            return Redirect("/admin/user/index");
        }
        [HttpPost]
        public IActionResult CompanyEdit(CompanyModel Model)
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
            var Company = _databaseContext.Companies.Where(x => x.Id == Id).FirstOrDefault();
            var User = _databaseContext.Users.Where(x => x.CompanyId == Company.Id).FirstOrDefault();
            var Settings = _databaseContext.Settings.Where(x => x.CompanyId == Company.Id).FirstOrDefault();
            var Jobs = _databaseContext.Jobs.Where(x => x.CompanyId == Company.Id).ToList();
            var Applies = _databaseContext.Applies.Where(x => x.CompanyId == Company.Id).ToList();
            var Contacts = _databaseContext.Contact.Where(x => x.CompanyId == Company.Id).ToList();
            if (Company != null)
            {
                _databaseContext.Companies.Remove(Company);
                _databaseContext.Users.Remove(User);
                _databaseContext.Settings.Remove(Settings);
                _databaseContext.Jobs.RemoveRange(Jobs);
                _databaseContext.Applies.RemoveRange(Applies);
                _databaseContext.Contact.RemoveRange(Contacts);
                _databaseContext.SaveChanges();
                TempData["successMessage"] = "Ofis başarıyla silindi.";
            }
            else
            {
                TempData["dangerMessage"] = "Ofis silinirken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
            }
            return Redirect("/admin/user/index");
        }
    }
}
