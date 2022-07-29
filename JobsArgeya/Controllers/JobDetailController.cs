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
        public IActionResult Index(string Id)
        {
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            string Host = Request.Host.ToString();
            var DbCompany = _databaseContext.Companies.Where(x => x.CompanyDomain == Host).FirstOrDefault();
            var SiteColor = _databaseContext.Settings.Where(x => x.CompanyId == DbCompany.Id).Select(x => x.SiteColor).FirstOrDefault();
            ViewData["SiteColor"] = SiteColor.ToString();
            ViewData["SiteName"] = Details.GetSiteDetails(3, Host);
            ViewData["FavIcon"] = Details.GetSiteDetails(7, Host);
            /* Method parametresinin ismini değiştirince url deki slug değerini alamıyorum. 
             * Bundan ötürü default yapıdaki id değerini alıyorum. Route yapısını düzenledim ama işin içinden çıkamadım. */
            var JobDetail = _databaseContext.Jobs.Where(x => x.JobSlug == Id && x.CompanyId == DbCompany.Id).FirstOrDefault();
            if (JobDetail != null && JobDetail.IsActive == "true")
            {
                JobsViewModel JobsVm = new JobsViewModel();
                JobsVm.Id = JobDetail.Id;
                JobsVm.JobTitle = JobDetail.JobTitle;
                JobsVm.JobKeywords = JobDetail.JobKeywords;
                JobsVm.JobDescription = JobDetail.JobDescription;
                JobsVm.JobContent = JobDetail.JobContent;
                JobsVm.JobSlug = JobDetail.JobSlug;
                return View(JobsVm);
            }
            else
            {
                TempData["dangerMessage"] = "İlan Bulunamadı";
            }
            return Redirect("/");
        }
    }
}