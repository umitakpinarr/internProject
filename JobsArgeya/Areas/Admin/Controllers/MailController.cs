using JobsArgeya.Areas.Admin.Models;
using JobsArgeya.Data.Context;
using JobsArgeya.Data.Entities;
using JobsArgeya.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using JobsArgeya.Business;
using System.Threading.Tasks;

namespace JobsArgeya.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class MailController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        private readonly IConfiguration _configuration;


        public MailController(DatabaseContext databaseContext, IConfiguration configuration)
        {
            _databaseContext = databaseContext;
            _configuration = configuration;
        }
        [Area("Admin")]
        public IActionResult Index()
        {
            List<MailSubscribers> dbSubscribers = _databaseContext.MailSubscribers.ToList();
            List<MailSubscribersModel> allSubscribers = new List<MailSubscribersModel>();

            foreach (MailSubscribers subscriber in dbSubscribers)
            {
                MailSubscribersModel mailVm = new MailSubscribersModel();
                mailVm.id = subscriber.id;
                mailVm.email = subscriber.email;

                allSubscribers.Add(mailVm);
            }

            return View(allSubscribers);
        }
        [HttpGet]
        public IActionResult Send()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Send(SendMailModel MailCredentials)
        {
            string host = Request.Host.ToString();
            Mail mail = new Mail(_databaseContext, _configuration);
            mail.SendMailList(MailCredentials.MailSubject, MailCredentials.MailContent, host);
            TempData["successMessage"] = "Mail listesine gönderim başarıyla sağlandı.";
            return View();
        }
        public IActionResult Delete(int id)
        {
            var subscriber = _databaseContext.MailSubscribers.Where(x => x.id == id).FirstOrDefault();
            if (subscriber != null)
            {
                _databaseContext.MailSubscribers.Remove(subscriber);
                _databaseContext.SaveChanges();
                TempData["successMessage"] = "Mail adresi listeden başarıyla silindi.";
            }
            else
            {
                TempData["dangerMessage"] = "Mail adresi listeden silinirken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
            }
            return Redirect("/admin/mail/");
        }
    }
}
