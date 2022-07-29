using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Areas.Admin.Models
{
    public class MailLogModel
    {
        public int Id { get; set; }
        public string Mail { get; set; }
        public string Status { get; set; }
        public string StatusMessage { get; set; }
    }
}
