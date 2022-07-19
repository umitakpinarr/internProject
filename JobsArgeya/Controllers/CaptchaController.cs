using JobsArgeya.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Controllers
{
    public class CaptchaController : Controller
    {
        public FileResult GetImage()
        {
            CaptchaHelper ch = new CaptchaHelper(HttpContext.Session);
            return File(ch.Image.ToByteArray(ImageFormat.Bmp), "image/jpeg");
        }
        public bool IsValid(string inputText, ISession session)
        {
            return inputText.ToLower() == session.GetString(CaptchaHelper.CAPTCHA_SESSION_KEY).ToLower();
        }
    }
}
