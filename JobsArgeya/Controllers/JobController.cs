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
using JobsArgeya.Areas.Admin.Models;
using JobsArgeya.Areas.Classes;
using Microsoft.Extensions.Configuration;
using Slugify;

namespace JobsArgeya.Controllers
{
    public class JobController : Controller
    {
        ApplyModel model = new ApplyModel();
        private readonly DatabaseContext _databaseContext;
        private IWebHostEnvironment _hostingEnvironment;
        private readonly IConfiguration _configuration;
        public JobController(DatabaseContext databaseContext, IWebHostEnvironment environment, IConfiguration configuration)
        {
            _databaseContext = databaseContext;
            _hostingEnvironment = environment;
            _configuration = configuration;
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
                Mail mail = new Mail(_databaseContext, _configuration);
                if (formFile != null)
                {
                    if (formFile.ContentType == "application/pdf" && formFile.Length > 0)
                    {
                        SlugHelper helper = new SlugHelper();
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
                        if (_databaseContext.MailSubscribers.Any(x => x.email == id.email))
                        {
                            TempData["successMessage"] = "Başvurunuz başarıyla oluşturuldu. En kısa zamanda size dönüş sağlayacağız.";
                        }
                        else
                        {
                            _databaseContext.MailSubscribers.Add(new MailSubscribers
                            {
                                email = id.email,
                                slug = helper.GenerateSlug(id.email)
                            });
                        }
                        _databaseContext.SaveChanges();
                        mail.SendMail(id.email, "Başvurunuzu Aldık", "Başvurunuzu aldık. Gerekli değerlendirmeler yapıldıktan sonra tarafınıza dönüş sağlanacaktır.");
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
        [HttpGet]
        public IActionResult Applicant(string id)
        {
            List<Jobs> dbJobs = _databaseContext.Jobs.ToList();
            List<JobsViewModel> allJobs = new List<JobsViewModel>();

            foreach (Jobs jobs in dbJobs)
            {
                JobsViewModel jobsVm = new JobsViewModel();
                jobsVm.id = jobs.id;
                jobsVm.jobTitle = jobs.jobTitle;

                allJobs.Add(jobsVm);
            }

            return View(allJobs);
            
        }
        [HttpPost]
        public IActionResult Applicant(ApplyModel apply, IFormFile formFile)
        {
            SlugHelper helper = new SlugHelper();
            Mail mail = new Mail(_databaseContext, _configuration);
            if (ModelState.IsValid)
            {
                if (formFile != null)
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
                            fullName = apply.fullName,
                            phone = apply.phone,
                            email = apply.email,
                            gender = apply.gender,
                            university = apply.university,
                            faculty = apply.faculty,
                            resume = apply.resume,
                            cvPath = fileName,
                            jobId = apply.jobId
                        });
                        if (_databaseContext.MailSubscribers.Any(x => x.email == apply.email))
                        {
                            TempData["successMessage"] = "Başvurunuz başarıyla oluşturuldu. En kısa zamanda size dönüş sağlayacağız.";
                        }
                        else
                        {
                            _databaseContext.MailSubscribers.Add(new MailSubscribers
                            {
                                email = apply.email,
                                slug = helper.GenerateSlug(apply.email)
                            });
                        }
                        mail.SendMail(apply.email, "Başvurunuzu Aldık", "Başvurunuzu aldık. Gerekli değerlendirmeler yapıldıktan sonra tarafınıza dönüş sağlanacaktır.");
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
