using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Areas.Admin.Models
{
    public class ChangePasswordModel
    {
        public string Password { get; set; }
        public string PasswordVerify { get; set; }
    }
}
