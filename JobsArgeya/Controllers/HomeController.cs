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
            string host = Request.Host.ToString();
            GetDetails details = new GetDetails(_databaseContext, _configuration);
            ViewData["PageKeywords"] = details.getSiteDetails(0, host);
            ViewData["PageDescription"] = details.getSiteDetails(1, host);
            return View();
        }
        public IActionResult Unsubscribe(string id)
        {
            var subscriber = _databaseContext.MailSubscribers.Where(x => x.slug == id).FirstOrDefault();
            if (subscriber != null && id != null)
            {
                _databaseContext.MailSubscribers.Remove(subscriber);
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
