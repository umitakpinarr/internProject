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
        SlugHelper helper = new SlugHelper();
        private readonly DatabaseContext _databaseContext;
        private IWebHostEnvironment _hostingEnvironment;
        public JobsController(DatabaseContext databaseContext, IWebHostEnvironment environment)
        {
            _databaseContext = databaseContext;
            _hostingEnvironment = environment;
        }
        public IActionResult List()
        {
            List<Jobs> dbJobs = _databaseContext.Jobs.ToList();
            List<JobsViewModel> allJobs = new List<JobsViewModel>();

            foreach (Jobs jobs in dbJobs)
            {
                JobsViewModel jobsVm = new JobsViewModel();
                jobsVm.id = jobs.id;
                jobsVm.jobTitle = jobs.jobTitle;
                jobsVm.jobKeywords = jobs.jobKeywords;
                jobsVm.jobDescription = jobs.jobDescription;
                jobsVm.jobContent = jobs.jobContent;

                allJobs.Add(jobsVm);
            }

            return View(allJobs);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {   
            Jobs dbJobs = _databaseContext.Jobs.Where(x => x.id == id).FirstOrDefault();
            JobsModel jobDetail = new JobsModel();
            if (dbJobs != null)
            {
                jobDetail.jobTitle = dbJobs.jobTitle;
                jobDetail.jobKeywords = dbJobs.jobKeywords;
                jobDetail.jobDescription = dbJobs.jobDescription;
                jobDetail.jobContent = dbJobs.jobContent;
                return View(jobDetail);
            }
            else
            {
                TempData["dangerMessage"] = "Tanımsız ilan bilgisi. Lütfen tekrar deneyiniz.";
            }
            return Redirect("/admin/home/index");
        }
        [HttpPost]
        public IActionResult Add(JobsModel jobsModel)
        {
            if (ModelState.IsValid)
            {
                _databaseContext.Jobs.Add(new Jobs
                {
                    jobTitle = jobsModel.jobTitle,
                    jobKeywords = jobsModel.jobKeywords,
                    jobDescription = jobsModel.jobDescription,
                    jobContent = jobsModel.jobContent,
                    jobSlug = helper.GenerateSlug(jobsModel.jobTitle)
                });
                _databaseContext.SaveChanges();
                TempData["successMessage"] = "İlan başarıyla eklendi.";
                return Redirect(Request.Headers["Referer"].ToString());
            }
            TempData["dangerMessage"] = "İlan eklenirken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
            return Redirect(Request.Headers["Referer"].ToString());
        }
        [HttpPost]
        public IActionResult Edit(JobsModel jobsModel, int id)
        {
            if (ModelState.IsValid)
            {
                var dbJobs = _databaseContext.Jobs.Where(x => x.id == id).FirstOrDefault();
                dbJobs.jobTitle = jobsModel.jobTitle;
                dbJobs.jobKeywords = jobsModel.jobKeywords;
                dbJobs.jobDescription = jobsModel.jobDescription;
                dbJobs.jobContent = jobsModel.jobContent;
                dbJobs.jobSlug = helper.GenerateSlug(jobsModel.jobTitle);
                _databaseContext.SaveChanges();
                TempData["successMessage"] = "İlan başarıyla güncellendi.";
                return Redirect(Request.Headers["Referer"].ToString());
            }
            TempData["dangerMessage"] = "İlan güncellenirken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
            return Redirect(Request.Headers["Referer"].ToString());
        }
        public IActionResult Delete(int id)
        {
            var job = _databaseContext.Jobs.Where(x => x.id == id).FirstOrDefault();
            if (job != null)
            {
                _databaseContext.Jobs.Remove(job);
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
