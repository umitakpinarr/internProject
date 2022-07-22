using JobsArgeya.Areas.Admin.Models;
using JobsArgeya.Business;
using JobsArgeya.Data.Context;
using JobsArgeya.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Areas.Admin.ViewComponents
{
    [Area("Admin")]
    public class NavBar : ViewComponent
    {
        private readonly DatabaseContext _databaseContext;
        private IWebHostEnvironment _hostingEnvironment;
        private readonly IConfiguration _configuration;
        public NavBar(DatabaseContext databaseContext, IWebHostEnvironment environment, IConfiguration configuration)
        {
            _databaseContext = databaseContext;
            _hostingEnvironment = environment;
            _configuration = configuration;
        }
        public IViewComponentResult Invoke()
        {
            string Host = Request.Host.ToString();
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            ViewData["NavBarLogo"] = Details.GetSiteDetails(5, Host);
            return View();
        }
    }
}
