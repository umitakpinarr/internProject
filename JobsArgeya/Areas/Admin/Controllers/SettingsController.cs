using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsArgeya.Areas.Admin.Models;
using JobsArgeya.Data.Entities;
using JobsArgeya.Data.Context;
using Microsoft.AspNetCore.Hosting;

namespace JobsArgeya.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SettingsController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        private IWebHostEnvironment _hostingEnvironment;
        public SettingsController(DatabaseContext databaseContext, IWebHostEnvironment environment)
        {
            _databaseContext = databaseContext;
            _hostingEnvironment = environment;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Settings> dbSettings = _databaseContext.Settings.ToList();
            List<SettingsViewModel> allSettings = new List<SettingsViewModel>();

            foreach (Settings settings in dbSettings)
            {
                SettingsViewModel settingsVm = new SettingsViewModel();
                settingsVm.key = settings.key;
                settingsVm.value = settings.value;

                allSettings.Add(settingsVm);
            }

            return View(allSettings);
        }

        [HttpPost]
        public IActionResult Index(SettingsModel settings)
        {
            List<Settings> dbSettings = _databaseContext.Settings.ToList();
            
            return View();
        }
    }
}
