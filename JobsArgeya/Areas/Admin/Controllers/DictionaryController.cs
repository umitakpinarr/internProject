using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsArgeya.Data.Context;
using JobsArgeya.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using JobsArgeya.Business;

namespace JobsArgeya.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin")]
    public class DictionaryController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        private IWebHostEnvironment _hostingEnvironment;
        private readonly IConfiguration _configuration;
        private readonly ILocalizer _localizer;
        public DictionaryController(DatabaseContext databaseContext, IWebHostEnvironment environment, IConfiguration configuration, ILocalizer localizer)
        {
            _databaseContext = databaseContext;
            _hostingEnvironment = environment;
            _configuration = configuration;
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            string Host = Request.Host.ToString();
            ViewData["CmsSiteName"] = Details.GetSiteDetails(3, Host);
            ViewData["FavIcon"] = Details.GetSiteDetails(7, Host);
            ViewData["Logo"] = Details.GetSiteDetails(5, Host);
            ViewData["DarkLogo"] = Details.GetSiteDetails(6, Host);
            List<LangCode> Languages = _databaseContext.LangCodes.ToList();
            ViewBag.Languages = Languages;
            List<string> AllKeys = _databaseContext.Dictionaries.OrderBy(x => x.Key).Select(x => x.Key).Distinct().ToList();
            List<List<Dictionary>> DictionaryTable = new List<List<Dictionary>>();
            foreach (string key in AllKeys)
            {
                List<Dictionary> List = new List<Dictionary>();
                foreach (LangCode Language in Languages)
                {
                    Dictionary Dictionary = _databaseContext.Dictionaries.Where(x => x.Key == key && x.LangCode == Language.Code).FirstOrDefault();
                    if(Dictionary == null)
                    {
                        Dictionary = new Dictionary();
                        Dictionary.Key = key;
                        Dictionary.Value = "";
                        Dictionary.LangCode = Language.Code;
                    }
                    List.Add(Dictionary);
                }
                DictionaryTable.Add(List);
            }
            return View(DictionaryTable);
        }
        [HttpPost]
        public IActionResult SaveKey(string keyList)
        {
            string[] keys = keyList.Split("\r\n", System.StringSplitOptions.RemoveEmptyEntries);

            foreach (string key in keys)
            {
                Dictionary Entry = _databaseContext.Dictionaries.Where(x => x.Key == key).FirstOrDefault();
                if (Entry == null)
                {
                    Dictionary NewEntry = new Dictionary();
                    NewEntry.Key = key;
                    NewEntry.LangCode = "tr";
                    NewEntry.Value = "";

                    _databaseContext.Dictionaries.Add(NewEntry);
                }
            }
            _databaseContext.SaveChanges();

            return Redirect("/admin/dictionary/index");
        }
        [HttpPost]
        [RequestFormLimits(ValueCountLimit = 10000)]
        public IActionResult SaveLang(List<List<Dictionary>> DictionaryTable)
        {
            foreach (List<Dictionary> DictionaryList in DictionaryTable)
            {
                foreach (Dictionary entry in DictionaryList)
                {
                    Dictionary DbEntry = _databaseContext.Dictionaries.Where(x => x.Key == entry.Key && x.LangCode == entry.LangCode).FirstOrDefault();
                    if (DbEntry == null)
                    {
                        _databaseContext.Dictionaries.Add(entry);
                    }
                    else
                    {
                        DbEntry.Value = entry.Value;
                        _databaseContext.Dictionaries.Update(DbEntry);
                    }
                }
            }
            _databaseContext.SaveChanges();

            _localizer.Reset();

            return Redirect("/admin/dictionary/index");
        }
        public IActionResult AddDictionary()
        {
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            string Host = Request.Host.ToString();
            ViewData["CmsSiteName"] = Details.GetSiteDetails(3, Host);
            ViewData["FavIcon"] = Details.GetSiteDetails(7, Host);
            ViewData["Logo"] = Details.GetSiteDetails(5, Host);
            ViewData["DarkLogo"] = Details.GetSiteDetails(6, Host);
            return View();
        }
        [HttpPost]
        public IActionResult AddDictionary(LangCode model)
        {
            if (ModelState.IsValid)
            {
                if (_databaseContext.LangCodes.Any(x => x.Language == model.Language))
                {
                    TempData["dangerMessage"] = "Bu dil daha önceden kayıt edilmiş.";
                }
                else
                {
                    _databaseContext.LangCodes.Add(new LangCode
                    {
                        Language = model.Language,
                        Code = model.Code,
                    });

                    _databaseContext.SaveChanges();
                    TempData["successMessage"] = "Dil başarıyla eklendi.";
                    return Redirect("/admin/Dictionary/index");
                }
            }
            //TempData["dangerMessage"] = "Kullanıcı eklenirken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
            return Redirect("/admin/Dictionary/index");
        }
    }
}
