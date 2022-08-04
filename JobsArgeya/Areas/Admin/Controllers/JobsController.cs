using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsArgeya.Areas.Admin.Models;
using Microsoft.AspNetCore.Hosting;
using JobsArgeya.Data.Context;
using JobsArgeya.Data.Entities;
using Slugify;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using JobsArgeya.Business;

namespace JobsArgeya.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class JobsController : Controller
    {
        SlugHelper Helper = new SlugHelper();
        private readonly DatabaseContext _databaseContext;
        private IWebHostEnvironment _hostingEnvironment;
        private readonly IConfiguration _configuration;
        public JobsController(DatabaseContext databaseContext, IWebHostEnvironment environment, IConfiguration configuration)
        {
            _databaseContext = databaseContext;
            _hostingEnvironment = environment;
            _configuration = configuration;
        }
        public IActionResult List(int CompanyId)
        {
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            Company Company;
            if (CompanyId != 0 && User.IsInRole("SuperAdmin"))
            {
                Company = _databaseContext.Companies.Where(x => x.Id == CompanyId).FirstOrDefault();
                if(Company != null)
                {
                    ViewData["CmsSiteName"] = Details.GetSiteDetails(3, Company.CompanyDomain);
                    ViewData["FavIcon"] = Details.GetSiteDetails(7, Company.CompanyDomain);
                    ViewData["Logo"] = Details.GetSiteDetails(5, Company.CompanyDomain);
                    ViewData["DarkLogo"] = Details.GetSiteDetails(6, Company.CompanyDomain);
                    ViewData["CompanyRoute"] = Company.Id;
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
                ViewData["CmsSiteName"] = Details.GetSiteDetails(3, Company.CompanyDomain);
                ViewData["FavIcon"] = Details.GetSiteDetails(7, Company.CompanyDomain);
                ViewData["Logo"] = Details.GetSiteDetails(5, Company.CompanyDomain);
                ViewData["DarkLogo"] = Details.GetSiteDetails(6, Company.CompanyDomain);
                ViewData["CompanyRoute"] = OfficeId;
            }
            List<Jobs> DbJobs = _databaseContext.Jobs.Where(x => x.CompanyId == Company.Id).ToList();
            List<JobsViewModel> AllJobs = new List<JobsViewModel>();

            foreach (Jobs Jobs in DbJobs)
            {
                JobsViewModel JobsVm = new JobsViewModel();
                JobsVm.Id = Jobs.Id;
                JobsVm.JobTitle = Jobs.JobTitle;
                JobsVm.JobKeywords = Jobs.JobKeywords;
                JobsVm.JobDescription = Jobs.JobDescription;
                JobsVm.JobContent = Jobs.JobContent;

                AllJobs.Add(JobsVm);
            }

            return View(AllJobs);
        }
        [HttpGet]
        public IActionResult Add(int CompanyId)
        {
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            Company Company;
            /*string Host = Request.Host.ToString();
            ViewData["CmsSiteName"] = Details.GetSiteDetails(3, Host);
            ViewData["FavIcon"] = Details.GetSiteDetails(7, Host);*/
            List<LangCode> langCode = _databaseContext.LangCodes.ToList();
            if (CompanyId != 0 && User.IsInRole("SuperAdmin"))
            {
                Company = _databaseContext.Companies.Where(x => x.Id == CompanyId).FirstOrDefault();
                ViewData["CmsSiteName"] = Details.GetSiteDetails(3, Company.CompanyDomain);
                ViewData["FavIcon"] = Details.GetSiteDetails(7, Company.CompanyDomain);
                ViewData["Logo"] = Details.GetSiteDetails(5, Company.CompanyDomain);
                ViewData["DarkLogo"] = Details.GetSiteDetails(6, Company.CompanyDomain);
                ViewData["CompanyRoute"] = Company.Id;
            }
            else
            {
                int OfficeId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "OfficeId").Value);
                Company = _databaseContext.Companies.Where(x => x.Id == OfficeId).FirstOrDefault();
                ViewData["CmsSiteName"] = Details.GetSiteDetails(3, Company.CompanyDomain);
                ViewData["FavIcon"] = Details.GetSiteDetails(7, Company.CompanyDomain);
                ViewData["Logo"] = Details.GetSiteDetails(5, Company.CompanyDomain);
                ViewData["DarkLogo"] = Details.GetSiteDetails(6, Company.CompanyDomain);
                ViewData["CompanyRoute"] = OfficeId;
            }
            return View(langCode);
        }
        [HttpGet]
        public IActionResult Edit(int Id, int CompanyId)
        {
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            string Host = Request.Host.ToString();
            ViewData["CmsSiteName"] = Details.GetSiteDetails(3, Host);
            ViewData["FavIcon"] = Details.GetSiteDetails(7, Host);
            Jobs DbJobs;
            if (User.IsInRole("SuperAdmin") && CompanyId != 0)
            {
                DbJobs = _databaseContext.Jobs.Where(x => x.Id == Id).FirstOrDefault();
                Company Company = _databaseContext.Companies.Where(x => x.Id == CompanyId).FirstOrDefault();
                if(Company != null)
                {
                    ViewData["CmsSiteName"] = Details.GetSiteDetails(3, Company.CompanyDomain);
                    ViewData["FavIcon"] = Details.GetSiteDetails(7, Company.CompanyDomain);
                    ViewData["Logo"] = Details.GetSiteDetails(5, Company.CompanyDomain);
                    ViewData["DarkLogo"] = Details.GetSiteDetails(6, Company.CompanyDomain);
                    ViewData["CompanyRoute"] = Company.Id;
                }
                else
                {
                    TempData["dangerMessage"] = "Tanımsız işyeri bilgisi. Lütfen tekrar deneyiniz.";
                    return Redirect("/admin/home/index");
                }
            }
            else
            {
                int ClaimCompany = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "OfficeId").Value);
                DbJobs = _databaseContext.Jobs.Where(x => x.Id == Id && x.CompanyId == ClaimCompany).FirstOrDefault();
                ViewData["CmsSiteName"] = Details.GetSiteDetails(3, Host);
                ViewData["FavIcon"] = Details.GetSiteDetails(7, Host);
                ViewData["Logo"] = Details.GetSiteDetails(5, Host);
                ViewData["DarkLogo"] = Details.GetSiteDetails(6, Host);
                ViewData["CompanyRoute"] = ClaimCompany;
            }
            
            JobsModel JobDetail = new JobsModel();
            if (DbJobs != null)
            {
                JobDetail.JobTitle = DbJobs.JobTitle;
                JobDetail.JobKeywords = DbJobs.JobKeywords;
                JobDetail.JobDescription = DbJobs.JobDescription;
                JobDetail.JobContent = DbJobs.JobContent;
                JobDetail.IsActive = DbJobs.IsActive;
                return View(JobDetail);
            }
            else
            {
                TempData["dangerMessage"] = "Tanımsız ilan bilgisi. Lütfen tekrar deneyiniz.";
            }
            return Redirect("/admin/home/index");
        }
        [HttpPost]
        public IActionResult Add(JobsModel Model)
        {
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            string Host = Request.Host.ToString();
            ViewData["CmsSiteName"] = Details.GetSiteDetails(3, Host);
            ViewData["FavIcon"] = Details.GetSiteDetails(7, Host);
            ViewData["CompanyRoute"] = Model.CompanyId;
            if (Model.CompanyId == null)
            {
                int OfficeId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "OfficeId").Value);
                Model.CompanyId = OfficeId;
                ViewData["CompanyRoute"] = OfficeId;
            }
            if (ModelState.IsValid)
            {
                _databaseContext.Jobs.Add(new Jobs
                {
                    JobTitle = Model.JobTitle,
                    JobKeywords = Model.JobKeywords,
                    JobDescription = Model.JobDescription,
                    JobContent = Model.JobContent,
                    JobSlug = Helper.GenerateSlug(Model.JobTitle),
                    IsActive = "true",
                    CompanyId = (int)Model.CompanyId,
                    LangCode = Model.LangCode
                });
                _databaseContext.SaveChanges();
                TempData["successMessage"] = "İlan başarıyla eklendi.";
                return Redirect(Request.Headers["Referer"].ToString());
            }
            else
            {
                TempData["dangerMessage"] = "Lütfen zorunlu alanları doldurup tekrar deneyiniz.";
            }
            return Redirect(Request.Headers["Referer"].ToString());
        }
        [HttpPost]
        public IActionResult Edit(JobsModel Model, int Id)
        {
            if (ModelState.IsValid)
            {
                Jobs DbJobs;
                int CompanyId;
                if (User.IsInRole("SuperAdmin"))
                {
                    DbJobs = _databaseContext.Jobs.Where(x => x.Id == Id).FirstOrDefault();
                }
                else
                {
                    CompanyId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "OfficeId").Value);
                    DbJobs = _databaseContext.Jobs.Where(x => x.Id == Id && x.CompanyId == CompanyId).FirstOrDefault();
                }
                DbJobs.JobTitle = Model.JobTitle;
                DbJobs.JobKeywords = Model.JobKeywords;
                DbJobs.JobDescription = Model.JobDescription;
                DbJobs.JobContent = Model.JobContent;
                DbJobs.IsActive = Model.IsActive;
                DbJobs.JobSlug = Helper.GenerateSlug(Model.JobTitle);
                _databaseContext.SaveChanges();
                TempData["successMessage"] = "İlan başarıyla güncellendi.";
                return Redirect(Request.Headers["Referer"].ToString());
            }
            else
            {
                TempData["dangerMessage"] = "Lütfen zorunlu alanları doldurup tekrar deneyiniz.";
            }
            return Redirect(Request.Headers["Referer"].ToString());
        }
        public IActionResult Delete(int CompanyId)
        {
            Jobs DbJobs;
            int OfficeId;
            if (User.IsInRole("SuperAdmin"))
            {
                DbJobs = _databaseContext.Jobs.Where(x => x.Id == CompanyId).FirstOrDefault();
            }
            else
            {
                OfficeId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "OfficeId").Value);
                DbJobs = _databaseContext.Jobs.Where(x => x.Id == CompanyId && x.CompanyId == OfficeId).FirstOrDefault();
            }
            if (DbJobs != null)
            {
                _databaseContext.Jobs.Remove(DbJobs);
                _databaseContext.SaveChanges();
                TempData["successMessage"] = "İlan başarıyla silindi.";
            }
            else
            {
                TempData["dangerMessage"] = "Geçersiz ilanı silmeye çalıştınız. Lütfen tekrar deneyiniz.";
            }
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
