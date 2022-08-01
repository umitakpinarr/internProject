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
using JobsArgeya.Business;
using Microsoft.AspNetCore.Http;

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

        [HttpGet]
        public IActionResult Index(int CompanyId)
        {
            /*Detayları çekmek için olşturduğum class ı türetip içersindeki methodlara erişeceğiz*/
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            string Host = Request.Host.ToString();
            Company Company;
            List<Apply> DbApplies;
            if (CompanyId != 0 && User.IsInRole("SuperAdmin"))
            {
                Company = _databaseContext.Companies.Where(x => x.Id == CompanyId).FirstOrDefault();
                DbApplies = _databaseContext.Applies.Where(x => x.CompanyId == Company.Id).ToList();
                if(DbApplies != null)
                {
                    ViewData["CmsSiteName"] = Details.GetSiteDetails(3, Company.CompanyDomain);
                    ViewData["FavIcon"] = Details.GetSiteDetails(7, Company.CompanyDomain);
                    ViewData["Logo"] = Details.GetSiteDetails(5, Company.CompanyDomain);
                    ViewData["DarkLogo"] = Details.GetSiteDetails(6, Company.CompanyDomain);
                }
                else
                {
                    TempData["dangerMessage"] = "Tanımsız işyeri bilgisi. Lütfen tekrar deneyiniz.";
                    return Redirect("/admin/home/index");
                }
            }
            else
            {
                int OfficeId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "OfficeId").Value);
                Company = _databaseContext.Companies.Where(x => x.Id == OfficeId).FirstOrDefault();
                DbApplies = _databaseContext.Applies.Where(x => x.CompanyId == Company.Id).ToList();
                ViewData["CmsSiteName"] = Details.GetSiteDetails(3, Company.CompanyDomain);
                ViewData["FavIcon"] = Details.GetSiteDetails(7, Company.CompanyDomain);
                ViewData["Logo"] = Details.GetSiteDetails(5, Company.CompanyDomain);
                ViewData["DarkLogo"] = Details.GetSiteDetails(6, Company.CompanyDomain);
            }
            List<AppliesViewModel> AllApplies = new List<AppliesViewModel>();

            foreach (Apply Apply in DbApplies)
            {
                AppliesViewModel ApplyVm = new AppliesViewModel();
                ApplyVm.Id = Apply.Id;
                ApplyVm.FullName = Apply.FullName;
                ApplyVm.Phone = Apply.Phone;
                ApplyVm.Email = Apply.Email;
                ApplyVm.Gender = Apply.Gender;
                ApplyVm.University = Apply.University;
                ApplyVm.Faculty = Apply.Faculty;
                ApplyVm.Resume = Apply.Resume;
                ApplyVm.CvPath = Apply.CvPath;
                ApplyVm.CreatedAt = Apply.CreatedAt;
                ApplyVm.JobId = Apply.JobId;
                /*DB de jobId varsa classdaki methoda gidip ilgili id ile veritabanından jobTitle return ediliyor ve viewmodele basıyor*/
                if (Apply.JobId != null)
                {
                    ApplyVm.JobTitle = Details.GetJobDetails((int)Apply.JobId, 0);
                    ApplyVm.JobSlug = Details.GetJobDetails((int)Apply.JobId, 4);
                }
                else if (Apply.IsIntern == "1")
                {
                    ApplyVm.InternStartDate = Apply.InternStartDate;
                    ApplyVm.InternEndDate = Apply.InternEndDate;
                    ApplyVm.JobTitle = "Stajyer Başvurusu";
                }
                else
                {
                    ApplyVm.JobTitle = "Sadece CV Göndermiş";
                }
                AllApplies.Add(ApplyVm);
            }

            return View(AllApplies);
        }

        public IActionResult Delete(int Id)
        {
            int CompanyId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "OfficeId").Value);
            var Apply = _databaseContext.Applies.Where(x => x.Id == Id && x.CompanyId == CompanyId).FirstOrDefault();

            if (Apply != null)
            {
                _databaseContext.Applies.Remove(Apply);
                _databaseContext.SaveChanges();
                TempData["successMessage"] = "Başvuru başarıyla silindi.";
            }
            else
            {
                TempData["dangerMessage"] = "Başvuru silinirken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
            }
            return Redirect("/admin/home/index");
        }

        public IActionResult ApplyDetail(int Id)
        {
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            string Host = Request.Host.ToString();
            ViewData["CmsSiteName"] = Details.GetSiteDetails(3, Host);
            ViewData["FavIcon"] = Details.GetSiteDetails(7, Host);
            Apply DbApply;
            int CompanyId;
            
            if (User.IsInRole("SuperAdmin"))
            {
                DbApply = _databaseContext.Applies.Where(x => x.Id == Id).FirstOrDefault();
            }
            else
            {
                CompanyId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "OfficeId").Value);
                DbApply = _databaseContext.Applies.Where(x => x.Id == Id && x.CompanyId == CompanyId).FirstOrDefault();
            }
            AppliesViewModel ApplyDetail = new AppliesViewModel();
            if (DbApply != null)
            {
                ApplyDetail.Id = DbApply.Id;
                ApplyDetail.FullName = DbApply.FullName;
                ApplyDetail.Phone = DbApply.Phone;
                ApplyDetail.Email = DbApply.Email;
                ApplyDetail.Gender = DbApply.Gender;
                ApplyDetail.University = DbApply.University;
                ApplyDetail.Faculty = DbApply.Faculty;
                ApplyDetail.Resume = DbApply.Resume;
                ApplyDetail.CvPath = DbApply.CvPath;
                ApplyDetail.CreatedAt = DbApply.CreatedAt;
                if (DbApply.JobId != null)
                {
                    ApplyDetail.JobTitle = Details.GetJobDetails((int)DbApply.JobId, 0);
                    ApplyDetail.JobSlug = Details.GetJobDetails((int)DbApply.JobId, 4);
                }
                else if (DbApply.IsIntern == "1")
                {
                    ApplyDetail.IsIntern = "1";
                    ApplyDetail.InternStartDate = DbApply.InternStartDate;
                    ApplyDetail.InternEndDate = DbApply.InternEndDate;
                    ApplyDetail.JobTitle = "Stajyer Başvurusu";
                }
                else
                {
                    ApplyDetail.JobTitle = "Sadece CV göndermiş.";
                }

                return View(ApplyDetail);
            }
            else
            {
                TempData["dangerMessage"] = "Geçersiz kayıt! Lütfen tekrar deneyiniz.";
            }
            return Redirect("/admin/home/index");

        }
        [HttpPost]
        public IActionResult Password(ChangePasswordModel Model)
        {
            int UserId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "UserId").Value);
            var DbUser = _databaseContext.Users.Where(x => x.Id == UserId).FirstOrDefault();
            if (Model.Password == Model.PasswordVerify)
            {
                string PasswordHashed = MD5Hash.Hash.Content(Model.Password);
                DbUser.Password = PasswordHashed;
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
