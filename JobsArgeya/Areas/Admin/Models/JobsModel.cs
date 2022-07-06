using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Areas.Admin.Models
{
    public class JobsModel
    {
        public string jobTitle { get; set; }
        public string jobContent { get; set; }
        public string jobKeywords { get; set; }
        public string jobDescription { get; set; }
    }
}
