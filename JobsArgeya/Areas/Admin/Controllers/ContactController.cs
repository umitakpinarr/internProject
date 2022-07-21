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
            string host = Request.Host.ToString();
            var dbOffice = _databaseContext.Offices.Where(x => x.officeDomain == host).FirstOrDefault();

            List<Contact> dbContacts = _databaseContext.Contact.Where(x => x.OfficeId == dbOffice.id).ToList();
            List<ContactViewModel> allContacts = new List<ContactViewModel>();

            foreach (Contact contact in dbContacts)
            {
                ContactViewModel model = new ContactViewModel();
                model.Id = contact.Id;
                model.Name = contact.Name;
                model.Email = contact.Email;
                model.Phone = contact.Phone;
                model.Subject = contact.Subject;
                model.Message = contact.Message;
                model.OfficeId = contact.OfficeId;
                allContacts.Add(model);
            }
            return View(allContacts);
        }
        public IActionResult Delete(int id)
        {
            int officeId = Convert.ToInt32(User.Claims.FirstOrDefault(c => c.Type == "officeId").Value);
            var contact = _databaseContext.Contact.Where(x => x.Id == id && x.OfficeId == officeId).FirstOrDefault();
            if (contact != null)
            {
                _databaseContext.Contact.Remove(contact);
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
