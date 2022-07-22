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

namespace JobsArgeya.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize]
    public class ContactController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        private IWebHostEnvironment _hostingEnvironment;
        public ContactController(DatabaseContext databaseContext, IWebHostEnvironment environment)
        {
            _databaseContext = databaseContext;
            _hostingEnvironment = environment;
        }
        [HttpGet]
        public IActionResult Index()
        {
            string Host = Request.Host.ToString();
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
                TempData["dangerMessage"] = "Mesaj silinirken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
            }
            return Redirect("/admin/contact/index");
        }
    }
}
