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
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            string Host = Request.Host.ToString();
            var DbCompany = _databaseContext.Companies.Where(x => x.CompanyDomain == Host).FirstOrDefault();
            ViewData["SiteColor"] = _databaseContext.Settings.Where(x => x.CompanyId == DbCompany.Id).Select(x => x.SiteColor).FirstOrDefault();
            ViewData["SiteName"] = Details.GetSiteDetails(3, Host);
            ViewData["FavIcon"] = Details.GetSiteDetails(7, Host);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(ApplyModel Model, IFormFile FormFile)
        {
            CaptchaController CaptchaController = new CaptchaController();
            if (!CaptchaController.IsValid(Model.captcha, HttpContext.Session))
            {
                TempData["dangerMessage"] = "Yanlış captcha girişi yaptınız. Lütfen tekrar deneyiniz.";
                return Redirect("/job");
            }
            /*Requestin geldiği domainin tespiti, ardından gelen domain bilgisine göre office bilgisinin çekilmesi*/
            string Host = Request.Host.ToString();
            var DbCompany = _databaseContext.Companies.Where(x => x.CompanyDomain == Host).FirstOrDefault();

            if (ModelState.IsValid)
            {
                Mail Mail = new Mail(_databaseContext, _configuration);
                if (FormFile != null)
                {
                    if (FormFile.ContentType == "application/pdf" && FormFile.Length > 0)
                    {
                        string RegexPattern = @"^(05(\d{9}))$";
                        if (Regex.IsMatch(Model.Phone, RegexPattern) == true)
                        {
                            SlugHelper Helper = new SlugHelper();
                            /*Dosya uzantısını alıyoruz*/
                            var Extension = System.IO.Path.GetExtension(FormFile.FileName);
                            /*Benzersiz bir dosya adı alıp uzantıyla birleştiriyoruz*/
                            var FileName = Helper.GenerateSlug(Model.FullName + "-" + DateTime.Today) + Extension;
                            /*Dosyanın yükleneceği klasörün yolu*/
                            var Path = Directory.GetCurrentDirectory() + "\\wwwroot" + "\\uploads" + "\\cv\\" + "\\job\\" + FileName;
                            /*Dosya oluşturuluyor*/
                            FileStream Stream = new FileStream(Path, FileMode.Create);
                            FormFile.CopyTo(Stream);

                            /*DB Insert*/
                            _databaseContext.Applies.Add(new Apply
                            {
                                FullName = Model.FullName,
                                Phone = Model.Phone,
                                Email = Model.Email,
                                Gender = Model.Gender,
                                University = Model.University,
                                Faculty = Model.Faculty,
                                Resume = Model.Resume,
                                CreatedAt = DateTime.Now,
                                CvPath = FileName,
                                CompanyId = DbCompany.Id
                            });
                            if (_databaseContext.MailSubscribers.Any(x => x.Email == Model.Email))
                            {
                                TempData["successMessage"] = "Başvurunuz başarıyla oluşturuldu. En kısa zamanda size dönüş sağlayacağız.";
                            }
                            else
                            {
                                _databaseContext.MailSubscribers.Add(new MailSubscribers
                                {
                                    Email = Model.Email,
                                    Slug = Helper.GenerateSlug(Model.Email)
                                });
                            }
                            _databaseContext.SaveChanges();
                            Mail.SendMail(Model.Email, "Başvurunuzu Aldık", "Başvurunuzu aldık. Gerekli değerlendirmeler yapıldıktan sonra tarafınıza dönüş sağlanacaktır.", Host);
                            TempData["successMessage"] = "Başvurunuz başarıyla oluşturuldu. En kısa zamanda size dönüş sağlayacağız.";
                        }
                        else
                        {
                            TempData["dangerMessage"] = "Telefon numarasını istenilen formatta girmediniz (Örn. 05xxxxxxxxx). Lütfen tekrar deneyiniz.";
                        }
                    }
                    else
                    {
                        TempData["dangerMessage"] = "Sadece .pdf uzantılı dosyaları kabul etmekteyiz. Lütfen tekrar deneyiniz.";
                    }
                }
                else
                {
                    TempData["dangerMessage"] = "CV/Özgeçmiş yüklemediniz. Lütfen tekrar deneyiniz.";
                }

                return Redirect(Request.Headers["Referer"].ToString());
            }
            TempData["dangerMessage"] = "Başvurunuz oluşturulurken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
            return View();
        }
        [HttpGet]
        public IActionResult Applicant(string Id)
        {
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            string Host = Request.Host.ToString();
            var DbCompany = _databaseContext.Companies.Where(x => x.CompanyDomain == Host).FirstOrDefault();
            ViewData["SiteColor"] = _databaseContext.Settings.Where(x => x.CompanyId == DbCompany.Id).Select(x => x.SiteColor).FirstOrDefault();
            ViewData["SiteName"] = Details.GetSiteDetails(3, Host);
            ViewData["FavIcon"] = Details.GetSiteDetails(7, Host);
            List<Jobs> DbJobs = _databaseContext.Jobs.Where(x => x.CompanyId == DbCompany.Id && x.JobSlug == Id).ToList();
            List<JobsViewModel> allJobs = new List<JobsViewModel>();

            foreach (Jobs Jobs in DbJobs)
            {
                JobsViewModel JobsVm = new JobsViewModel();
                JobsVm.Id = Jobs.Id;
                JobsVm.JobTitle = Jobs.JobTitle;
                JobsVm.IsActive = Jobs.IsActive;

                allJobs.Add(JobsVm);
            }

            return View(allJobs);

        }
        [HttpPost]
        public IActionResult Applicant(ApplyModel Apply, IFormFile FormFile)
        {
            CaptchaController CaptchaController = new CaptchaController();
            if (!CaptchaController.IsValid(Apply.captcha, HttpContext.Session))
            {
                TempData["dangerMessage"] = "Yanlış captcha girişi yaptınız. Lütfen tekrar deneyiniz.";
                return Redirect(Request.Headers["Referer"].ToString());
            }
            SlugHelper Helper = new SlugHelper();
            Mail Mail = new Mail(_databaseContext, _configuration);

            /*Requestin geldiği domainin tespiti, ardından gelen domain bilgisine göre office bilgisinin çekilmesi*/
            string Host = Request.Host.ToString();
            var DbCompany = _databaseContext.Companies.Where(x => x.CompanyDomain == Host).FirstOrDefault();
            if (ModelState.IsValid)
            {
                if (FormFile != null)
                {
                    if (FormFile.ContentType == "application/pdf" && FormFile.Length > 0)
                    {
                        string RegexPattern = @"^(05(\d{9}))$";
                        if (Regex.IsMatch(Apply.Phone, RegexPattern) == true)
                        {
                            /*Dosya uzantısını alıyoruz*/
                            var Extension = System.IO.Path.GetExtension(FormFile.FileName);
                            /*Benzersiz bir dosya adı alıp uzantıyla birleştiriyoruz*/
                            var FileName = Helper.GenerateSlug(Apply.FullName + "-" + DateTime.Today) + Extension;
                            /*Dosyanın yükleneceği klasörün yolu*/
                            var Path = Directory.GetCurrentDirectory() + "\\wwwroot" + "\\uploads" + "\\cv\\" + "\\applicant\\" + FileName;
                            /*Dosya oluşturuluyor*/
                            FileStream Stream = new FileStream(Path, FileMode.Create);
                            FormFile.CopyTo(Stream);

                            /*DB Insert*/
                            _databaseContext.Applies.Add(new Apply
                            {
                                FullName = Apply.FullName,
                                Phone = Apply.Phone,
                                Email = Apply.Email,
                                Gender = Apply.Gender,
                                University = Apply.University,
                                Faculty = Apply.Faculty,
                                Resume = Apply.Resume,
                                CvPath = FileName,
                                CreatedAt = DateTime.Now,
                                JobId = Apply.JobId,
                                CompanyId = DbCompany.Id
                            });
                            if (_databaseContext.MailSubscribers.Any(x => x.Email == Apply.Email))
                            {
                                TempData["successMessage"] = "Başvurunuz başarıyla oluşturuldu. En kısa zamanda size dönüş sağlayacağız.";
                            }
                            else
                            {
                                _databaseContext.MailSubscribers.Add(new MailSubscribers
                                {
                                    Email = Apply.Email,
                                    Slug = Helper.GenerateSlug(Apply.Email)
                                });
                            }
                            Mail.SendMail(Apply.Email, "Başvurunuzu Aldık", "Başvurunuzu aldık. Gerekli değerlendirmeler yapıldıktan sonra tarafınıza dönüş sağlanacaktır.", Host);
                            TempData["successMessage"] = "Başvurunuz başarıyla oluşturuldu. En kısa zamanda size dönüş sağlayacağız.";
                            _databaseContext.SaveChanges();
                        }
                        else
                        {
                            TempData["dangerMessage"] = "Telefon numarasını istenilen formatta girmediniz (Örn. 05xxxxxxxxx). Lütfen tekrar deneyiniz.";
                        }
                    }
                    else
                    {
                        TempData["dangerMessage"] = "Sadece .pdf uzantılı dosyaları kabul etmekteyiz. Lütfen tekrar deneyiniz.";
                    }
                }
                else
                {
                    TempData["dangerMessage"] = "CV/Özgeçmiş yüklemediniz. Lütfen tekrar deneyiniz.";
                }

                return Redirect(Request.Headers["Referer"].ToString());
            }
            TempData["dangerMessage"] = "Başvurunuz oluşturulurken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
            return Redirect(Request.Headers["Referer"].ToString());
        }
        [HttpGet]
        public IActionResult Intern()
        {
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            string Host = Request.Host.ToString();
            var DbCompany = _databaseContext.Companies.Where(x => x.CompanyDomain == Host).FirstOrDefault();
            ViewData["SiteColor"] = _databaseContext.Settings.Where(x => x.CompanyId == DbCompany.Id).Select(x => x.SiteColor).FirstOrDefault();
            ViewData["SiteName"] = Details.GetSiteDetails(3, Host);
            ViewData["FavIcon"] = Details.GetSiteDetails(7, Host);
            return View();
        }
        public IActionResult Intern(ApplyModel Apply, IFormFile FormFile)
        {
            CaptchaController CaptchaController = new CaptchaController();
            if (!CaptchaController.IsValid(Apply.captcha, HttpContext.Session))
            {
                TempData["dangerMessage"] = "Yanlış captcha girişi yaptınız. Lütfen tekrar deneyiniz.";
                return Redirect(Request.Headers["Referer"].ToString());
            }
            SlugHelper Helper = new SlugHelper();
            Mail Mail = new Mail(_databaseContext, _configuration);

            /*Requestin geldiği domainin tespiti, ardından gelen domain bilgisine göre office bilgisinin çekilmesi*/
            string Host = Request.Host.ToString();
            var DbCompany = _databaseContext.Companies.Where(x => x.CompanyDomain == Host).FirstOrDefault();

            if (ModelState.IsValid)
            {
                if (FormFile != null)
                {
                    if (FormFile.ContentType == "application/pdf" && FormFile.Length > 0)
                    {
                        string RegexPattern = @"^(05(\d{9}))$";
                        if (Regex.IsMatch(Apply.Phone, RegexPattern) == true)
                        {
                            /*Dosya uzantısını alıyoruz*/
                            var Extension = System.IO.Path.GetExtension(FormFile.FileName);
                            /*Benzersiz bir dosya adı alıp uzantıyla birleştiriyoruz*/
                            var FileName = Helper.GenerateSlug(Apply.FullName + "-" + DateTime.Today) + Extension;
                            /*Dosyanın yükleneceği klasörün yolu*/
                            var Path = Directory.GetCurrentDirectory() + "\\wwwroot" + "\\uploads" + "\\cv\\" + "\\intern\\" + FileName;
                            /*Dosya oluşturuluyor*/
                            FileStream Stream = new FileStream(Path, FileMode.Create);
                            FormFile.CopyTo(Stream);

                            /*DB Insert*/
                            _databaseContext.Applies.Add(new Apply
                            {
                                FullName = Apply.FullName,
                                Phone = Apply.Phone,
                                Email = Apply.Email,
                                Gender = Apply.Gender,
                                University = Apply.University,
                                Faculty = Apply.Faculty,
                                Resume = Apply.Resume,
                                CvPath = FileName,
                                JobId = Apply.JobId,
                                CreatedAt = DateTime.Now,
                                IsIntern = "1",
                                InternStartDate = Apply.InternStartDate,
                                InternEndDate = Apply.InternEndDate,
                                CompanyId = DbCompany.Id
                            });
                            if (_databaseContext.MailSubscribers.Any(x => x.Email == Apply.Email))
                            {
                                TempData["successMessage"] = "Başvurunuz başarıyla oluşturuldu. En kısa zamanda size dönüş sağlayacağız.";
                            }
                            else
                            {
                                _databaseContext.MailSubscribers.Add(new MailSubscribers
                                {
                                    Email = Apply.Email,
                                    Slug = Helper.GenerateSlug(Apply.Email)
                                });
                            }
                            Mail.SendMail(Apply.Email, "Başvurunuzu Aldık", "Başvurunuzu aldık. Gerekli değerlendirmeler yapıldıktan sonra tarafınıza dönüş sağlanacaktır.", Host);
                            TempData["successMessage"] = "Başvurunuz başarıyla oluşturuldu. En kısa zamanda size dönüş sağlayacağız.";
                            _databaseContext.SaveChanges();
                        }
                        else
                        {
                            TempData["dangerMessage"] = "Telefon numarasını istenilen formatta girmediniz (Örn. 05xxxxxxxxx). Lütfen tekrar deneyiniz.";
                        }
                    }
                    else
                    {
                        TempData["dangerMessage"] = "Sadece .pdf uzantılı dosyaları kabul etmekteyiz. Lütfen tekrar deneyiniz.";
                    }
                }
                else
                {
                    TempData["dangerMessage"] = "CV/Özgeçmiş yüklemediniz. Lütfen tekrar deneyiniz.";
                }

                return Redirect(Request.Headers["Referer"].ToString());
            }
            TempData["dangerMessage"] = "Başvurunuz oluşturulurken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
