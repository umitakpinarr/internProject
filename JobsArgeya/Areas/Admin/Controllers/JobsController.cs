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

namespace JobsArgeya.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class JobsController : Controller
    {
        SlugHelper Helper = new SlugHelper();
        private readonly DatabaseContext _databaseContext;
        private IWebHostEnvironment _hostingEnvironment;
        public JobsController(DatabaseContext databaseContext, IWebHostEnvironment environment)
        {
            _databaseContext = databaseContext;
            _hostingEnvironment = environment;
        }
        public IActionResult List()
        {
            int OfficeId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "OfficeId").Value);
            List<Jobs> DbJobs = _databaseContext.Jobs.Where(x=> x.CompanyId == OfficeId).ToList();
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
        public IActionResult Add()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            int OfficeId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "OfficeId").Value);
            Jobs DbJobs = _databaseContext.Jobs.Where(x => x.Id == Id && x.CompanyId == OfficeId).FirstOrDefault();
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
            TempData["dangerMessage"] = "İlan eklenirken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
            return Redirect(Request.Headers["Referer"].ToString());
        }
        [HttpPost]
        public IActionResult Edit(JobsModel Model, int Id)
        {
            if (ModelState.IsValid)
            {
                int OfficeId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "OfficeId").Value);
                var DbJobs = _databaseContext.Jobs.Where(x => x.Id == Id && x.CompanyId == OfficeId).FirstOrDefault();
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
            TempData["dangerMessage"] = "İlan güncellenirken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
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
                TempData["dangerMessage"] = "İlan silinirken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
            }
            return Redirect("/admin/jobs/list");
        }
    }
}
