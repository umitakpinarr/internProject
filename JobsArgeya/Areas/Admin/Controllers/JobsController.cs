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
        public IActionResult List(int Id)
        {
            int CompanyId;
            if (Id != 0)
            {
                CompanyId = _databaseContext.Companies.Where(x => x.Id == Id).Select(x => x.Id).FirstOrDefault();
            }
            else
            {
                CompanyId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "OfficeId").Value);
            }
            List<Jobs> DbJobs = _databaseContext.Jobs.Where(x => x.CompanyId == CompanyId).ToList();
            List<JobsViewModel> AllJobs = new List<JobsViewModel>();
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            string Host = Request.Host.ToString();
            ViewData["CmsSiteName"] = Details.GetSiteDetails(3, Host);
            ViewData["FavIcon"] = Details.GetSiteDetails(7, Host);
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
        public IActionResult Add()
        {
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            string Host = Request.Host.ToString();
            ViewData["CmsSiteName"] = Details.GetSiteDetails(3, Host);
            ViewData["FavIcon"] = Details.GetSiteDetails(7, Host);
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            string Host = Request.Host.ToString();
            ViewData["CmsSiteName"] = Details.GetSiteDetails(3, Host);
            ViewData["FavIcon"] = Details.GetSiteDetails(7, Host);
            //int OfficeId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "OfficeId").Value);
            Jobs DbJobs = _databaseContext.Jobs.Where(x => x.Id == Id).FirstOrDefault();
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
            int OfficeId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "OfficeId").Value);
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
                    CompanyId = OfficeId
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
                int OfficeId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "OfficeId").Value);
                var DbJobs = _databaseContext.Jobs.Where(x => x.Id == Id).FirstOrDefault();
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
        public IActionResult Delete(int Id)
        {
            int OfficeId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "OfficeId").Value);
            var Job = _databaseContext.Jobs.Where(x => x.Id == Id && x.CompanyId == OfficeId).FirstOrDefault();
            if (Job != null)
            {
                _databaseContext.Jobs.Remove(Job);
                _databaseContext.SaveChanges();
                TempData["successMessage"] = "İlan başarıyla silindi.";
            }
            else
            {
                TempData["dangerMessage"] = "Geçersiz ilanı silmeye çalıştınız. Lütfen tekrar deneyiniz.";
            }
            return Redirect("/admin/jobs/list");
        }
    }
}
