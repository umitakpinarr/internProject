using JobsArgeya.Data.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsArgeya.Data.Entities;
using JobsArgeya.Areas.Admin.Models;

namespace JobsArgeya.ViewComponents
{
    public class JobsList : ViewComponent
    {
        private readonly DatabaseContext _databaseContext;
        private IWebHostEnvironment _hostingEnvironment;
        public JobsList(DatabaseContext databaseContext, IWebHostEnvironment environment)
        {
            _databaseContext = databaseContext;
            _hostingEnvironment = environment;
        }
        public IViewComponentResult Invoke(string officeSlug)
        {
            var dbOffice = _databaseContext.Offices.Where(x => x.officeSlug == officeSlug).FirstOrDefault();
            List<Jobs> dbJobs = _databaseContext.Jobs.Where(x=> x.officeId == dbOffice.id).ToList();
            List<JobsViewModel> allJobs = new List<JobsViewModel>();

            foreach (Jobs jobs in dbJobs)
            {
                JobsViewModel jobsVm = new JobsViewModel();
                jobsVm.id = jobs.id;
                jobsVm.jobTitle = jobs.jobTitle;
                jobsVm.jobKeywords = jobs.jobKeywords;
                jobsVm.jobDescription = jobs.jobDescription;
                jobsVm.jobContent = jobs.jobContent;
                jobsVm.jobSlug = jobs.jobSlug;
                jobsVm.isActive = jobs.isActive;

                allJobs.Add(jobsVm);
            }

            return View(allJobs);
        }
    }
}
