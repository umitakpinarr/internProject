using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Slugify;
using JobsArgeya.Data.Context;
using JobsArgeya.Areas.Admin.Models;
using Microsoft.AspNetCore.Hosting;
using JobsArgeya.Business;
using Microsoft.Extensions.Configuration;

namespace JobsArgeya.Controllers
{
    public class JobDetailController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        private IWebHostEnvironment _hostingEnvironment;
        private readonly IConfiguration _configuration;
        public JobDetailController(DatabaseContext databaseContext, IWebHostEnvironment environment, IConfiguration configuration)
        {
            _databaseContext = databaseContext;
            _hostingEnvironment = environment;
            _configuration = configuration;
        }
        [HttpGet]
        public IActionResult Index(string id)
        {
            GetDetails details = new GetDetails(_databaseContext, _configuration);
            string host = Request.Host.ToString();
            var dbOffice = _databaseContext.Offices.Where(x => x.officeDomain == host).FirstOrDefault();
            var siteColor = _databaseContext.Settings.Where(x => x.officeId == dbOffice.id).Select(x => x.siteColor).FirstOrDefault();
            ViewData["SiteColor"] = siteColor.ToString();
            ViewData["SiteName"] = details.getSiteDetails(3, host);
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