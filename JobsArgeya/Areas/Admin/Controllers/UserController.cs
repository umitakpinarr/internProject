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
                if(User.CompanyId != 0)
                {
                    UserVm.CompanyId = Convert.ToInt32(Details.GetUserCompany(User.Id, 3));
                    UserVm.CompanyName = Details.GetUserCompany(User.Id, 1);
                    UserVm.CompanyDomain = Details.GetUserCompany(User.Id, 2);
                }
                else
                {
                    UserVm.CompanyId = 0;
                    UserVm.CompanyName = "Şirket Atanmamış";
                    UserVm.CompanyDomain = "Şirket Atanmamış";
                }
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
                if(_databaseContext.Users.Any(x=> x.Email == Model.Email))
                {
                    TempData["dangerMessage"] = "Bu bilgilerle başka kullanıcı bulunmakta. Lütfen tekrar deneyiniz.";
                }
                else
                {
                    _databaseContext.Users.Add(new Users
                    {
                        Name = Model.Name,
                        Surname = Model.Surname,
                        Email = Model.Email,
                        Password = MD5Hash.Hash.Content(Model.Password),
                        RoleId = Model.RoleId
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
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            if (Id != 0)
            {
                var User = _databaseContext.Users.Where(x => x.Id == Id).FirstOrDefault();
                if (_databaseContext.Companies.Any(x => x.Id == User.CompanyId))
                {
                    TempData["dangerMessage"] = "Kullanıcı kaydını silebilmek için Ofis kaydını silmeniz gerekmekte. Lütfen tekrar deneyiniz.";
                }
                else
                {
                    if (User != null)
                    {
                        _databaseContext.Users.Remove(User);
                        _databaseContext.SaveChanges();
                        TempData["successMessage"] = "Kayıt başarıyla silindi.";
                    }
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
