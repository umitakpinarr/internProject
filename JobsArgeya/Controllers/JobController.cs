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
using JobsArgeya.Business;
using Microsoft.Extensions.Configuration;
using Slugify;
using System.Text.RegularExpressions;

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
            GetDetails details = new GetDetails(_databaseContext, _configuration);
            string host = Request.Host.ToString();
            var dbOffice = _databaseContext.Offices.Where(x => x.officeDomain == host).FirstOrDefault();
            ViewData["SiteColor"] = _databaseContext.Settings.Where(x => x.officeId == dbOffice.id).Select(x => x.siteColor).FirstOrDefault();
            ViewData["SiteName"] = details.getSiteDetails(3, host);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Apply(ApplyModel id, IFormFile formFile)
        {
            CaptchaController captchaController = new CaptchaController();
            if (!captchaController.IsValid(id.captcha, HttpContext.Session))
            {
                TempData["dangerMessage"] = "Yanlış captcha girişi yaptınız. Lütfen tekrar deneyiniz.";
                return Redirect(Request.Headers["Referer"].ToString());
            }
            /*Requestin geldiği domainin tespiti, ardından gelen domain bilgisine göre office bilgisinin çekilmesi*/
            string host = Request.Host.ToString();
            var dbOffice = _databaseContext.Offices.Where(x => x.officeDomain == host).FirstOrDefault();

            if (ModelState.IsValid)
            {
                Mail mail = new Mail(_databaseContext, _configuration);
                if (formFile != null)
                {
                    if (formFile.ContentType == "application/pdf" && formFile.Length > 0)
                    {
                        string regexPattern = @"^(05(\d{9}))$";
                        if (Regex.IsMatch(id.phone, regexPattern) == true)
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
                                createdAt = DateTime.Now,
                                cvPath = fileName,
                                officeId = dbOffice.id
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
                            mail.SendMail(id.email, "Başvurunuzu Aldık", "Başvurunuzu aldık. Gerekli değerlendirmeler yapıldıktan sonra tarafınıza dönüş sağlanacaktır.", host);
                        }
                        else
                        {
                            TempData["dangerMessage"] = "Telefon numarasını istenilen formatta girmediniz (Örn. 05xxxxxxxxx). Lütfen tekrar deneyiniz.";
                        }
                    }
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
            GetDetails details = new GetDetails(_databaseContext, _configuration);
            string host = Request.Host.ToString();
            var dbOffice = _databaseContext.Offices.Where(x => x.officeDomain == host).FirstOrDefault();
            ViewData["SiteColor"] = _databaseContext.Settings.Where(x => x.officeId == dbOffice.id).Select(x => x.siteColor).FirstOrDefault();
            ViewData["SiteName"] = details.getSiteDetails(3, host);
            List<Jobs> dbJobs = _databaseContext.Jobs.Where(x => x.officeId == dbOffice.id).ToList();
            List<JobsViewModel> allJobs = new List<JobsViewModel>();

            foreach (Jobs jobs in dbJobs)
            {
                JobsViewModel jobsVm = new JobsViewModel();
                jobsVm.id = jobs.id;
                jobsVm.jobTitle = jobs.jobTitle;
                jobsVm.isActive = jobs.isActive;

                allJobs.Add(jobsVm);
            }

            return View(allJobs);

        }
        [HttpPost]
        public IActionResult Applicant(ApplyModel apply, IFormFile formFile)
        {
            CaptchaController captchaController = new CaptchaController();
            if (!captchaController.IsValid(apply.captcha, HttpContext.Session))
            {
                TempData["dangerMessage"] = "Yanlış captcha girişi yaptınız. Lütfen tekrar deneyiniz.";
                return Redirect(Request.Headers["Referer"].ToString());
            }
            SlugHelper helper = new SlugHelper();
            Mail mail = new Mail(_databaseContext, _configuration);

            /*Requestin geldiği domainin tespiti, ardından gelen domain bilgisine göre office bilgisinin çekilmesi*/
            string host = Request.Host.ToString();
            var dbOffice = _databaseContext.Offices.Where(x => x.officeDomain == host).FirstOrDefault();
            if (ModelState.IsValid)
            {
                if (formFile != null)
                {
                    if (formFile.ContentType == "application/pdf" && formFile.Length > 0)
                    {
                        string regexPattern = @"^(05(\d{9}))$";
                        if (Regex.IsMatch(apply.phone, regexPattern) == true)
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
                                createdAt = DateTime.Now,
                                jobId = apply.jobId,
                                officeId = dbOffice.id
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
                            mail.SendMail(apply.email, "Başvurunuzu Aldık", "Başvurunuzu aldık. Gerekli değerlendirmeler yapıldıktan sonra tarafınıza dönüş sağlanacaktır.", host);
                            _databaseContext.SaveChanges();
                        }
                        else
                        {
                            TempData["dangerMessage"] = "Telefon numarasını istenilen formatta girmediniz (Örn. 05xxxxxxxxx). Lütfen tekrar deneyiniz.";
                        }
                    }
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
        public IActionResult Intern()
        {
            GetDetails details = new GetDetails(_databaseContext, _configuration);
            string host = Request.Host.ToString();
            var dbOffice = _databaseContext.Offices.Where(x => x.officeDomain == host).FirstOrDefault();
            ViewData["SiteColor"] = _databaseContext.Settings.Where(x => x.officeId == dbOffice.id).Select(x => x.siteColor).FirstOrDefault();
            ViewData["SiteName"] = details.getSiteDetails(3, host);
            return View();
        }
        public IActionResult Intern(ApplyModel apply, IFormFile formFile)
        {
            CaptchaController captchaController = new CaptchaController();
            if (!captchaController.IsValid(apply.captcha, HttpContext.Session))
            {
                TempData["dangerMessage"] = "Yanlış captcha girişi yaptınız. Lütfen tekrar deneyiniz.";
                return Redirect(Request.Headers["Referer"].ToString());
            }
            SlugHelper helper = new SlugHelper();
            Mail mail = new Mail(_databaseContext, _configuration);

            /*Requestin geldiği domainin tespiti, ardından gelen domain bilgisine göre office bilgisinin çekilmesi*/
            string host = Request.Host.ToString();
            var dbOffice = _databaseContext.Offices.Where(x => x.officeDomain == host).FirstOrDefault();

            if (ModelState.IsValid)
            {
                if (formFile != null)
                {
                    if (formFile.ContentType == "application/pdf" && formFile.Length > 0)
                    {
                        string regexPattern = @"^(05(\d{9}))$";
                        if (Regex.IsMatch(apply.phone, regexPattern) == true)
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
                                jobId = apply.jobId,
                                createdAt = DateTime.Now,
                                isIntern = "1",
                                internStartDate = apply.internStartDate,
                                internEndDate = apply.internEndDate,
                                officeId = dbOffice.id
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
                            mail.SendMail(apply.email, "Başvurunuzu Aldık", "Başvurunuzu aldık. Gerekli değerlendirmeler yapıldıktan sonra tarafınıza dönüş sağlanacaktır.", host);
                            _databaseContext.SaveChanges();
                        }
                        else
                        {
                            TempData["dangerMessage"] = "Telefon numarasını istenilen formatta girmediniz (Örn. 05xxxxxxxxx). Lütfen tekrar deneyiniz.";
                        }
                    }
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
