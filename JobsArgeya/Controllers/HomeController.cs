using JobsArgeya.Models;
using JobsArgeya.Business;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using JobsArgeya.Data.Context;
using Microsoft.Extensions.Configuration;


namespace JobsArgeya.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        
        private readonly DatabaseContext _databaseContext;
        private readonly IConfiguration _configuration;

        public HomeController(DatabaseContext databaseContext, IConfiguration configuration)
        {
            _databaseContext = databaseContext;
            _configuration = configuration;
        }
        /*public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/

        public IActionResult Index()
        {
            string Host = Request.Host.ToString();
            GetDetails Details = new GetDetails(_databaseContext, _configuration);
            ViewData["SiteName"] = Details.GetSiteDetails(3, Host);
            ViewData["PageKeywords"] = Details.GetSiteDetails(0, Host);
            ViewData["PageDescription"] = Details.GetSiteDetails(1, Host);
            ViewData["FavIcon"] = Details.GetSiteDetails(7, Host);
            return View();
        }
        public IActionResult Unsubscribe(string Id)
        {
            var Subscriber = _databaseContext.MailSubscribers.Where(x => x.Slug == Id).FirstOrDefault();
            if (Subscriber != null && Id != null)
            {
                _databaseContext.MailSubscribers.Remove(Subscriber);
                _databaseContext.SaveChanges();
                TempData["successMessage"] = "Mail adresi listeden başarıyla silindi.";
            }
            else
            {
                TempData["dangerMessage"] = "Mail adresi listeden silinirken hatayla karşılaşıldı. Lütfen tekrar deneyiniz.";
            }
            return Redirect("/");
        }
       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
