using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsArgeya.Data.Entities;
using JobsArgeya.Data.Context;
using Microsoft.Extensions.Configuration;
using JobsArgeya.Areas.Admin.Models;
using JobsArgeya.Areas.Classes;

namespace JobsArgeya.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]

    public class HomeController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        private readonly IConfiguration _configuration;

        public HomeController(DatabaseContext databaseContext, IConfiguration configuration)
        {
            _databaseContext = databaseContext;
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            /*Detayları çekmek için olşturduğum class ı türetip içersindeki methodlara erişeceğiz*/
            GetDetails details = new GetDetails(_databaseContext, _configuration);

            List<Apply> dbApplies = _databaseContext.Applies.ToList();
            List<AppliesViewModel> allApplies = new List<AppliesViewModel>();

            foreach (Apply apply in dbApplies)
            {
                AppliesViewModel applyVm = new AppliesViewModel();
                applyVm.id = apply.id;
                applyVm.fullName = apply.fullName;
                applyVm.phone = apply.phone;
                applyVm.email = apply.email;
                applyVm.gender = apply.gender;
                applyVm.university = apply.university;
                applyVm.faculty = apply.faculty;
                applyVm.resume = apply.resume;
                applyVm.cvPath = apply.cvPath;
                applyVm.jobId = apply.jobId;
                /*DB de jobId varsa classdaki methoda gidip ilgili id ile veritabanından jobTitle return ediliyor ve viewmodele basıyor*/
                if (apply.jobId != null)
                {
                    applyVm.jobTitle = details.getJobDetails((int)apply.jobId, 0);
                    applyVm.jobSlug = details.getJobDetails((int)apply.jobId, 4);
                }
                else
                {
                    applyVm.jobTitle = "Sadece CV göndermiş.";
                }
                allApplies.Add(applyVm);
            }

            return View(allApplies);
        }

        public IActionResult Delete(int id)
        {
            var apply = _databaseContext.Applies.Where(x => x.id == id).FirstOrDefault();
            
            if (apply != null)
            {
                _databaseContext.Applies.Remove(apply);
                _databaseContext.SaveChanges();
                TempData["successMessage"] = "Başvuru başarıyla silindi.";
            }
            else
            {
                TempData["dangerMessage"] = "Başvuru silinirken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
            }
            return Redirect("/admin/home/index");
        }
        public IActionResult ApplyDetail(int id)
        {
            Apply dbApply = _databaseContext.Applies.Where(x => x.id == id).FirstOrDefault();
            AppliesViewModel applyDetail = new AppliesViewModel();
            if(dbApply != null)
            {
                applyDetail.id = dbApply.id;
                applyDetail.fullName = dbApply.fullName;
                applyDetail.phone = dbApply.phone;
                applyDetail.email = dbApply.email;
                applyDetail.gender = dbApply.gender;
                applyDetail.university = dbApply.university;
                applyDetail.faculty = dbApply.faculty;
                applyDetail.resume = dbApply.resume;
                applyDetail.cvPath = dbApply.cvPath;

                return View(applyDetail);
            }
            else
            {
                TempData["dangerMessage"] = "Geçersiz kayıt! Lütfen tekrar deneyiniz.";
            }
            return Redirect("/admin/home/index");
        }
        [HttpPost]
        public IActionResult Password(ChangePasswordModel model)
        {
            var dbUser = _databaseContext.Users.Where(x => x.id == 1).FirstOrDefault();
            if(model.password == model.passwordVerify)
            {
                string passwordHashed = MD5Hash.Hash.Content(model.password);
                dbUser.password = passwordHashed;
                _databaseContext.SaveChanges();
                TempData["successMessage"] = "Şifreniz başarıyla güncellendi.";
            }
            else
            {
                TempData["dangerMessage"] = "Şifreniz güncellenirken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
            }
            return Redirect("/admin/home/index");
        }
    }
}
