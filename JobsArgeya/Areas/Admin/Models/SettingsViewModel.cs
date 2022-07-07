using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Areas.Admin.Models
{
    public class SettingsViewModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public string keywords { get; set; }
        public string description { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string adress { get; set; }
        public string facebook { get; set; }
        public string instagram { get; set; }
        public string twitter { get; set; }
        public string linkedin { get; set; }
        public string smtpServer { get; set; }
        public string smtpUsername { get; set; }
        public string smtpPassword { get; set; }
        public string smtpPort { get; set; }
        public string logo { get; set; }
    }
}
