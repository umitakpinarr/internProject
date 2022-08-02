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
            string Host = Request.Host.ToString();
            ViewData["CmsSiteName"] = Details.GetSiteDetails(3, Host);
            ViewData["FavIcon"] = Details.GetSiteDetails(7, Host);
            ViewData["Logo"] = Details.GetSiteDetails(5, Host);
            ViewData["DarkLogo"] = Details.GetSiteDetails(6, Host);
            List<Users> DbUsers = _databaseContext.Users.ToList();
            List<UsersViewModel> AllUsers = new List<UsersViewModel>();

            foreach (Users User in DbUsers)
            {
                UsersViewModel UserVm = new UsersViewModel();
                UserVm.Id = User.Id;
                UserVm.Name = User.Name;
                UserVm.Surname = User.Surname;
                UserVm.Email = User.Email;
                UserVm.IsActive = User.IsActive;
                if (User.CompanyId != 0)
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
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            string Host = Request.Host.ToString();
            ViewData["CmsSiteName"] = Details.GetSiteDetails(3, Host);
            ViewData["FavIcon"] = Details.GetSiteDetails(7, Host);
            List<Company> DBCompany = _databaseContext.Companies.ToList();
            List<CompanyViewModel> AllCompany = new List<CompanyViewModel>();

            foreach (Company Company in DBCompany)
            {
                CompanyViewModel Model = new CompanyViewModel();
                Model.Id = Company.Id;
                Model.CompanyName = Company.CompanyName;
                Model.CompanyDomain = Company.CompanyDomain;
                AllCompany.Add(Model);
            }
            return View(AllCompany);
        }
        [HttpPost]
        public IActionResult Add(UsersViewModel Model)
        {
            if (ModelState.IsValid)
            {
                if (_databaseContext.Users.Any(x => x.Email == Model.Email))
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
                        RoleId = 2,
                        CompanyId = (int)Model.CompanyId
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
                DbUser.Password = MD5Hash.Hash.Content(Model.Password);
                DbUser.CompanyId = Model.CompanyId;
                _databaseContext.SaveChanges();
                TempData["successMessage"] = "Kullanıcı başarıyla güncellendi.";
                return Redirect("/admin/user/index");
            }
            TempData["dangerMessage"] = "Kullanıcı güncellenirken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
            return Redirect("/admin/user/index");
        }
        [HttpGet]
        public IActionResult Delete(int CompanyId)
        {
            if (CompanyId != 0)
            {
                var User = _databaseContext.Users.Where(x => x.Id == CompanyId).FirstOrDefault();
                if (User != null)
                {
                    _databaseContext.Users.Remove(User);
                    _databaseContext.SaveChanges();
                    TempData["successMessage"] = "Kayıt başarıyla silindi.";
                }
                else
                {
                    TempData["dangerMessage"] = "Kullanıcı bulunamadı. Lütfen tekrar deneyiniz.";
                }
            }
            else
            {
                TempData["dangerMessage"] = "Geçersiz ID bilgisi. Lütfen tekrar deneyiniz.";
            }

            return Redirect("/admin/user/index");
        }
        [HttpGet]
        public IActionResult SetStatus(int CompanyId)
        {
            if(CompanyId != 0)
            {
                var User = _databaseContext.Users.Where(x => x.Id == CompanyId).FirstOrDefault();
                if(User != null)
                {
                    if(User.IsActive == 0)
                    {
                        User.IsActive = 1;
                        _databaseContext.SaveChanges();
                    }
                    else
                    {

                        User.IsActive = 0;
                        _databaseContext.SaveChanges();
                    }
                }
                else
                {
                    TempData["dangerMessage"] = "Kullanıcı bulunamadı. Lütfen tekrar deneyiniz.";
                }
            }
            else
            {
                TempData["dangerMessage"] = "Geçersiz ID bilgisi. Lütfen tekrar deneyiniz.";
            }
            return Redirect("/admin/user/index");
        }
    }
}
