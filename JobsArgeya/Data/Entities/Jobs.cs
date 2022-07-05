using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Data.Entities
{
    public class Jobs
    {
        public int id { get; set; }
        public string jobContent { get; set; }
        public string jobKeywords { get; set; }
        public string jobDescription { get; set; }
    }
}
