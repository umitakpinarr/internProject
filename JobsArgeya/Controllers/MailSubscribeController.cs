﻿using JobsArgeya.Data.Context;
using JobsArgeya.Data.Entities;
using JobsArgeya.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Controllers
{
    public class MailSubscribeController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        private IWebHostEnvironment _hostingEnvironment;
        public MailSubscribeController(DatabaseContext databaseContext, IWebHostEnvironment environment)
        {
            _databaseContext = databaseContext;
            _hostingEnvironment = environment;
        }
        [HttpPost]
        public IActionResult Index(MailSubscribersModel model)
        {
            if (ModelState.IsValid)
            {
                _databaseContext.MailSubscribers.Add(new MailSubscribers
                {
                    email = model.email
                });
                _databaseContext.SaveChanges();
                TempData["successMessage"] = "Mail listesine kaydınız başarıyla oluşturuldu.";
            }
            else
            {
                TempData["dangerMessage"] = "Kaydınız oluşturulurken hatayla karşlılaşıldı. Lütfen tekrar deneyiniz..";
            }
            return Redirect("/");
        }
    }
}