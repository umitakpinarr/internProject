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
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit()
        {
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
    }
}
