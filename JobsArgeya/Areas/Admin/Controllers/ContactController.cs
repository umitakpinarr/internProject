using JobsArgeya.Areas.Admin.Models;
using JobsArgeya.Data.Context;
using JobsArgeya.Data.Entities;
using JobsArgeya.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using JobsArgeya.Business;

namespace JobsArgeya.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize]
    public class ContactController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        private IWebHostEnvironment _hostingEnvironment;
        private readonly IConfiguration _configuration;
        public ContactController(DatabaseContext databaseContext, IWebHostEnvironment environment, IConfiguration configuration)
        {
            _databaseContext = databaseContext;
            _hostingEnvironment = environment;
            _configuration = configuration;
        }
        [HttpGet]
        public IActionResult Index()
        {
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            string Host = Request.Host.ToString();
            ViewData["CmsSiteName"] = Details.GetSiteDetails(3, Host);
            ViewData["FavIcon"] = Details.GetSiteDetails(7, Host);
            ViewData["Logo"] = Details.GetSiteDetails(5, Host);
            ViewData["DarkLogo"] = Details.GetSiteDetails(6, Host);
            var DbCompany = _databaseContext.Companies.Where(x => x.CompanyDomain == Host).FirstOrDefault();

            List<Contact> DbContacts = _databaseContext.Contact.Where(x => x.CompanyId == DbCompany.Id).ToList();
            List<ContactViewModel> AllContacts = new List<ContactViewModel>();

            foreach (Contact Contact in DbContacts)
            {
                ContactViewModel ContactVm = new ContactViewModel();
                ContactVm.Id = Contact.Id;
                ContactVm.Name = Contact.Name;
                ContactVm.Email = Contact.Email;
                ContactVm.Phone = Contact.Phone;
                ContactVm.Subject = Contact.Subject;
                ContactVm.Message = Contact.Message;
                ContactVm.CompanyId = Contact.CompanyId;
                AllContacts.Add(ContactVm);
            }
            return View(AllContacts);
        }
        public IActionResult Delete(int Id)
        {
            int OfficeId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "OfficeId").Value);
            var Contact = _databaseContext.Contact.Where(x => x.Id == Id && x.CompanyId == OfficeId).FirstOrDefault();
            if (Contact != null)
            {
                _databaseContext.Contact.Remove(Contact);
                _databaseContext.SaveChanges();
                TempData["successMessage"] = "Mesaj başarıyla silindi.";
            }
            else
            {
                TempData["dangerMessage"] = "Geçersiz mesaj silmeye çalıştınız. Lütfen tekrar deneyiniz.";
            }
            return Redirect("/admin/contact/index");
        }
    }
}
