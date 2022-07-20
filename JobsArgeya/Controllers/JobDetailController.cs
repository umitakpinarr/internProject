using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Slugify;
using JobsArgeya.Data.Context;
using JobsArgeya.Areas.Admin.Models;
using Microsoft.AspNetCore.Hosting;

namespace JobsArgeya.Controllers
{
    public class JobDetailController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        private IWebHostEnvironment _hostingEnvironment;
        public JobDetailController(DatabaseContext databaseContext, IWebHostEnvironment environment)
        {
            _databaseContext = databaseContext;
            _hostingEnvironment = environment;
        }
        [HttpGet]
        public IActionResult Index(string id)
        {
            string host = Request.Host.ToString();
            var dbOffice = _databaseContext.Offices.Where(x => x.officeDomain == host).FirstOrDefault();
            var siteColor = _databaseContext.Settings.Where(x => x.officeId == dbOffice.id).Select(x => x.siteColor).FirstOrDefault();
            ViewData["SiteColor"] = siteColor.ToString();
            /* Method parametresinin ismini değiştirince url deki slug değerini alamıyorum. 
             * Bundan ötürü default yapıdaki id değerini alıyorum. Route yapısını düzenledim ama işin içinden çıkamadım. */
            var jobDetail = _databaseContext.Jobs.Where(x => x.jobSlug == id && x.officeId == dbOffice.id).FirstOrDefault();
            if (jobDetail != null && jobDetail.isActive == "true")
            {
                JobsViewModel jobsVm = new JobsViewModel();
                jobsVm.id = jobDetail.id;
                jobsVm.jobTitle = jobDetail.jobTitle;
                jobsVm.jobKeywords = jobDetail.jobKeywords;
                jobsVm.jobDescription = jobDetail.jobDescription;
                jobsVm.jobContent = jobDetail.jobContent;
                jobsVm.jobSlug = jobDetail.jobSlug;
                return View(jobsVm);
            }
            else
            {
                TempData["dangerMessage"] = "İlan Bulunamadı";
            }
            return Redirect("/");
        }
    }
}