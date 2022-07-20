using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Data.Entities
{
    public class Offices
    {
        public int id { get; set; }
        public string officeName { get; set; }
        public string officeSlug { get; set; }
        public string officeDomain { get; set; }
    }
}
