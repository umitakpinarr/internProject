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
        public IViewComponentResult Invoke()
        {
            string Host = Request.Host.ToString();
            var DbCompany = _databaseContext.Companies.Where(x => x.CompanyDomain == Host).FirstOrDefault();
            List<Jobs> DbJobs = _databaseContext.Jobs.Where(x => x.CompanyId == DbCompany.Id).ToList();
            List<JobsViewModel> AllJobs = new List<JobsViewModel>();
            var SiteColor = _databaseContext.Settings.Where(x => x.CompanyId == DbCompany.Id).Select(x => x.SiteColor).FirstOrDefault();
            ViewData["SiteColor"] = SiteColor.ToString();
            foreach (Jobs Jobs in DbJobs)
            {
                JobsViewModel JobsVm = new JobsViewModel();
                JobsVm.Id = Jobs.Id;
                JobsVm.JobTitle = Jobs.JobTitle;
                JobsVm.JobKeywords = Jobs.JobKeywords;
                JobsVm.JobDescription = Jobs.JobDescription;
                JobsVm.JobContent = Jobs.JobContent;
                JobsVm.JobSlug = Jobs.JobSlug;
                JobsVm.IsActive = Jobs.IsActive;
                JobsVm.LangCode = Jobs.LangCode;

                AllJobs.Add(JobsVm);
            }

            return View(AllJobs);
        }
    }
}
