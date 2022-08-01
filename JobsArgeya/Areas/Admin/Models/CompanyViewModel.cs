using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Areas.Admin.Models
{
    public class CompanyViewModel
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDomain { get; set; }
        public string? CompanyLogo { get; set; }
        public int UserId { get; set; }
    }
}
