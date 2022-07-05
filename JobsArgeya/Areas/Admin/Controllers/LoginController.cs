using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }

    }
}
