using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsArgeya.Areas.Admin.Models;
using Microsoft.AspNetCore.Hosting;
using JobsArgeya.Data.Context;
using JobsArgeya.Data.Entities;

namespace JobsArgeya.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class JobsController : Controller
    {
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
        public IActionResult Edit()
        {   /*TO DO*/
            /* Güncelleme yapıyor lakin sayfa ilk yüklendiğinde veriler boş geliyor. 
             * ilgili veriler inputlara çekilemiyor */
            /*Jobs dbJobs = _databaseContext.Jobs.Where(x => x.id == id).FirstOrDefault();

            return View(dbJobs);*/
            return View();
        }
        [HttpPost]
        public IActionResult Add(JobsModel jobsModel)
        {
            if(ModelState.IsValid)
            {
                _databaseContext.Jobs.Add(new Jobs
                {
                    jobTitle = jobsModel.jobTitle,
                    jobKeywords = jobsModel.jobKeywords,
                    jobDescription = jobsModel.jobDescription,
                    jobContent = jobsModel.jobContent
                });
                _databaseContext.SaveChanges();
                return Redirect(Request.Headers["Referer"].ToString());
            }
            return Redirect(Request.Headers["Referer"].ToString());
        }
        [HttpPost]
        public IActionResult Edit(JobsModel jobsModel, int id)
        {
            var dbJobs = _databaseContext.Jobs.Where(x => x.id == id).FirstOrDefault();
            dbJobs.jobTitle = jobsModel.jobTitle;
            dbJobs.jobKeywords = jobsModel.jobKeywords;
            dbJobs.jobDescription = jobsModel.jobDescription;
            dbJobs.jobContent = jobsModel.jobContent;
            _databaseContext.SaveChanges();
            return Redirect(Request.Headers["Referer"].ToString());
        }
        public IActionResult Delete(int id)
        {
            var job = _databaseContext.Jobs.Where(x => x.id == id).FirstOrDefault();
            _databaseContext.Jobs.Remove(job);
            _databaseContext.SaveChanges();

            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
