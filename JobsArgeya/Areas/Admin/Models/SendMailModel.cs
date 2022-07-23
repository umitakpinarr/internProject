using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Areas.Admin.Models
{
    public class SendMailModel
    {
        [Required]
        public string MailSubject { get; set; }
        [Required]
        public string MailContent { get; set; }
    }
}
