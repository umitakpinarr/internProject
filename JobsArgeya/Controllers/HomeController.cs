using JobsArgeya.Models;
using JobsArgeya.Areas.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using JobsArgeya.Data.Context;
using Microsoft.Extensions.Configuration;

namespace JobsArgeya.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        private readonly DatabaseContext _databaseContext;
        private readonly IConfiguration _configuration;

        public HomeController(DatabaseContext databaseContext, IConfiguration configuration)
        {
            _databaseContext = databaseContext;
            _configuration = configuration;
        }
        /*public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/

        public IActionResult Index()
        {
            GetDetails details = new GetDetails(_databaseContext, _configuration);
            ViewData["PageKeywords"] = details.getSiteDetails(0);
            ViewData["PageDescription"] = details.getSiteDetails(1);
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
