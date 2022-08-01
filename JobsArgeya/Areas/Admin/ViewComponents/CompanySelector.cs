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
    public class CompanySelector : ViewComponent
    {
        private readonly DatabaseContext _databaseContext;
        private IWebHostEnvironment _hostingEnvironment;
        private readonly IConfiguration _configuration;
        public CompanySelector(DatabaseContext databaseContext, IWebHostEnvironment environment, IConfiguration configuration)
        {
            _databaseContext = databaseContext;
            _hostingEnvironment = environment;
            _configuration = configuration;
        }
        public IViewComponentResult Invoke()
        {
            string Host = Request.Host.ToString();
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            //ViewData["LightLogo"] = Details.GetSiteDetails(5, Host);
            List<Company> DbCompanies = _databaseContext.Companies.ToList();
            List<CompanyViewModel> AllCompanies = new List<CompanyViewModel>();

            foreach (Company Company in DbCompanies)
            {
                CompanyViewModel CompanyVm = new CompanyViewModel();
                CompanyVm.Id = Company.Id;
                CompanyVm.CompanyName = Company.CompanyName;
                CompanyVm.CompanyDomain = Company.CompanyDomain;
                CompanyVm.CompanyLogo = Details.GetSiteDetails(5,Company.CompanyDomain);

                AllCompanies.Add(CompanyVm);
            }
            return View(AllCompanies);
        }
    }
}
