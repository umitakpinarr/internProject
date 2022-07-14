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
            /* Method parametresinin ismini değiştirince url deki slug değerini alamıyorum. 
             * Bundan ötürü default yapıdaki id değerini alıyorum. Route yapısını düzenledim ama işin içinden çıkamadım. */
            var jobDetail = _databaseContext.Jobs.Where(x => x.jobSlug == id).FirstOrDefault();
            if(jobDetail != null)
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
                return Redirect("/");
            }
        }
    }
}