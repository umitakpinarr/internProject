using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Data.Entities
{
    public class Apply
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string university { get; set; }
        public string faculty { get; set; }
        public string resume { get; set; }
        public string cvPath { get; set; }
    }
}
