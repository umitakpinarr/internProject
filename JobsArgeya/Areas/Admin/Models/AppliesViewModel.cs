using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Areas.Admin.Models
{
    public class AppliesViewModel
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
        public DateTime createdAt { get; set; }
        public int? jobId { get; set; }
        public string? jobTitle { get; set; }
        public string? jobSlug { get; set; }
        public string? isIntern { get; set; }
        public DateTime? internStartDate { get; set; }
        public DateTime? internEndDate { get; set; }
    }
}
