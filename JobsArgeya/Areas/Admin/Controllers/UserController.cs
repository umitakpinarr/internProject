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
            GetDetails details = new GetDetails(_databaseContext, _configuration);
            List<Users> dbUsers = _databaseContext.Users.ToList();
            List<UsersViewModel> allUsers = new List<UsersViewModel>();

            foreach (Users user in dbUsers)
            {
                UsersViewModel userVm = new UsersViewModel();
                userVm.id = user.id;
                userVm.name = user.name;
                userVm.surname = user.surname;
                userVm.email = user.email;
                userVm.officeId = Convert.ToInt32(details.getUserOffice(user.id, 3));
                userVm.officeName = details.getUserOffice(user.id, 1);
                userVm.officeDomain = details.getUserOffice(user.id, 2);
                allUsers.Add(userVm);
            }
            return View(allUsers);
        }
        [HttpGet]
        public IActionResult Add()
        {
            List<Roles> dbRoles = _databaseContext.Roles.ToList();
            List<RoleModel> allRoles = new List<RoleModel>();

            foreach (Roles role in dbRoles)
            {
                RoleModel userRole = new RoleModel();
                userRole.Id = role.id;
                userRole.RoleName = role.roleName;
                allRoles.Add(userRole);
            }
            return View(allRoles);
        }
        [HttpPost]
        public IActionResult Add(UsersViewModel Model)
        {
            if (ModelState.IsValid)
            {
                if(_databaseContext.Offices.Any(x=> x.officeDomain == Model.officeDomain) || _databaseContext.Users.Any(x=> x.email == Model.email))
                {
                    TempData["dangerMessage"] = "Bu bilgilerle başka kullanıcı/ofis bulunmakta. Lütfen tekrar deneyiniz.";
                }
                else
                {
                    var office = new Offices
                    {
                        officeName = Model.officeName,
                        officeDomain = Model.officeDomain
                    };

                    _databaseContext.Offices.Add(office);
                    _databaseContext.SaveChanges();

                    _databaseContext.Users.Add(new Users
                    {
                        name = Model.name,
                        surname = Model.surname,
                        email = Model.email,
                        password = MD5Hash.Hash.Content(Model.password),
                        officeId = office.id,
                        roleId = Model.roleId
                    });

                    _databaseContext.SaveChanges();

                    _databaseContext.Settings.Add(new Settings
                    {
                        title = "Lütfen Site Başlığı Girin",
                        keywords = "Lütfen Site Anahtar Kelimelerini Girin",
                        description = "Lütfen Site Açıklaması Girin",
                        email = "Lütfen Email Adresi Girin",
                        phone = "Lütfen Telefon Nuamrası Girin",
                        adress = "Lütfen Ofis Adresi Girin",
                        facebook = "#",
                        instagram = "#",
                        twitter = "#",
                        linkedin = "#",
                        smtpServer = "smtp.test.com",
                        smtpUsername = "test@test.com",
                        smtpPassword = "test",
                        smtpPort = "465",
                        logo = "logo.png",
                        useSSL = "true",
                        officeId = office.id,
                        siteColor = "#DC3545"
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
                    var dbUser = _databaseContext.Users.Where(x => x.id == Model.id).FirstOrDefault();
                    dbUser.name = Model.name;
                    dbUser.surname = Model.surname;
                    dbUser.email = Model.email;
                    dbUser.password = MD5Hash.Hash.Content(Model.password);
                    _databaseContext.SaveChanges();
                    TempData["successMessage"] = "Kullanıcı başarıyla güncellendi.";
                    return Redirect("/admin/user/index");
            }
            TempData["dangerMessage"] = "Kullanıcı güncellenirken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
            return Redirect("/admin/user/index");
        }
        [HttpPost]
        public IActionResult OfficeEdit(OfficeModel Model)
        {
            if (ModelState.IsValid)
            {
                    var dbOffice = _databaseContext.Offices.Where(x => x.id == Model.officeId).FirstOrDefault();
                    dbOffice.officeName = Model.officeName;
                    dbOffice.officeDomain = Model.officeDomain;
                    _databaseContext.SaveChanges();
                    TempData["successMessage"] = "Ofis başarıyla güncellendi.";
                    return Redirect("/admin/user/index");
            }
            TempData["dangerMessage"] = "Ofis güncellenirken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
            return Redirect("/admin/user/index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var office = _databaseContext.Offices.Where(x => x.id == id).FirstOrDefault();
            var user = _databaseContext.Users.Where(x => x.officeId == office.id).FirstOrDefault();
            var settings = _databaseContext.Settings.Where(x => x.officeId == office.id).FirstOrDefault();
            var jobs = _databaseContext.Jobs.Where(x => x.officeId == office.id).ToList();
            var applies = _databaseContext.Applies.Where(x => x.officeId == office.id).ToList();
            var contacts = _databaseContext.Contact.Where(x => x.OfficeId == office.id).ToList();
            if (office != null)
            {
                _databaseContext.Offices.Remove(office);
                _databaseContext.Users.Remove(user);
                _databaseContext.Settings.Remove(settings);
                _databaseContext.Jobs.RemoveRange(jobs);
                _databaseContext.Applies.RemoveRange(applies);
                _databaseContext.Contact.RemoveRange(contacts);
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
