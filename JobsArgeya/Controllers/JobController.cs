using JobsArgeya.Data.Context;
using JobsArgeya.Data.Entities;
using JobsArgeya.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Controllers
{
    public class JobController : Controller
    {
        ApplyModel model = new ApplyModel();
        private readonly DatabaseContext _databaseContext;
        private IWebHostEnvironment _hostingEnvironment;
        public JobController(DatabaseContext databaseContext, IWebHostEnvironment environment)
        {
            _databaseContext = databaseContext;
            _hostingEnvironment = environment;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Apply(ApplyModel id, IFormFile formFile)
        {
            if (ModelState.IsValid)
            {
                if(formFile != null)
                {
                    if (formFile.ContentType == "application/pdf" && formFile.Length > 0)
                    {
                        /*Dosya uzantısını alıyoruz*/
                        var extension = Path.GetExtension(formFile.FileName);
                        /*Benzersiz bir dosya adı alıp uzantıyla birleştiriyoruz*/
                        var fileName = Guid.NewGuid() + extension;
                        /*Dosyanın yükleneceği klasörün yolu*/
                        var path = Directory.GetCurrentDirectory() + "\\wwwroot" + "\\uploads\\" + fileName;
                        /*Dosya oluşturuluyor*/
                        FileStream stream = new FileStream(path, FileMode.Create);
                        formFile.CopyTo(stream);

                        /*DB Insert*/
                        _databaseContext.Applies.Add(new Apply
                        {
                            fullName = id.fullName,
                            phone = id.phone,
                            email = id.email,
                            gender = id.gender,
                            university = id.university,
                            faculty = id.faculty,
                            resume = id.resume,
                            cvPath = fileName
                        });
                        _databaseContext.SaveChanges();
                    }
                    TempData["successMessage"] = "Başvurunuz başarıyla oluşturuldu. En kısa zamanda size dönüş sağlayacağız.";
                }
                else
                {
                    TempData["dangerMessage"] = "Başvurunuz oluşturulurken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
                }
                
                return Redirect(Request.Headers["Referer"].ToString());
            }
            TempData["dangerMessage"] = "Başvurunuz oluşturulurken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
