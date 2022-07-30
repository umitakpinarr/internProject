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
        public IActionResult Index(int Id)
        {
            /*Detayları çekmek için olşturduğum class ı türetip içersindeki methodlara erişeceğiz*/
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            string Host = Request.Host.ToString();
            ViewData["CmsSiteName"] = Details.GetSiteDetails(3, Host);
            ViewData["FavIcon"] = Details.GetSiteDetails(7, Host);
            ViewData["Logo"] = Details.GetSiteDetails(5, Host);
            ViewData["DarkLogo"] = Details.GetSiteDetails(6, Host);
            int CompanyId;
            if(Id != 0)
            {
                CompanyId = _databaseContext.Companies.Where(x => x.Id == Id).Select(x=>x.Id).FirstOrDefault();
            }
            else
            {
               CompanyId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "OfficeId").Value);
            }
            List<Apply> DbApplies = _databaseContext.Applies.Where(x => x.CompanyId == CompanyId).ToList();
            int UserId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "OfficeId").Value);
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

        [HttpPost]
        public IActionResult Index(AppliesViewModel Model)
        {
            
            /*Detayları çekmek için olşturduğum class ı türetip içersindeki methodlara erişeceğiz*/
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            string Host = Request.Host.ToString();
            ViewData["CmsSiteName"] = Details.GetSiteDetails(3, Host);
            Settings DbCompany = _databaseContext.Settings.Where(x => x.CompanyId == Model.Id).FirstOrDefault();
            if (DbCompany.CompanyId == 2)
            {
                ViewData["DarkLogo"] = Details.GetSiteDetails(6, "localhost:5003");
            }
            else
            {
                ViewData["DarkLogo"] = Details.GetSiteDetails(6, "localhost:5001");
            }
            ViewData["Logo"] = Details.GetSiteDetails(5, Host);
            int CompanyId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "OfficeId").Value);
            List<Apply> DbApplies = _databaseContext.Applies.Where(x => x.CompanyId == Model.Id).ToList();
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
            int CompanyId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "OfficeId").Value);
            int RoleId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "UserId").Value);
            
            Users DbUsers = _databaseContext.Users.Where(x => x.Id == RoleId).FirstOrDefault();
            AppliesViewModel ApplyDetail = new AppliesViewModel();
            if(DbUsers.RoleId == 1)
            {
                Apply DbApply = _databaseContext.Applies.Where(x => x.Id == Id).FirstOrDefault();

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
            else
            {
                Apply DbApply = _databaseContext.Applies.Where(x => x.Id == Id && x.CompanyId == CompanyId).FirstOrDefault();
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
