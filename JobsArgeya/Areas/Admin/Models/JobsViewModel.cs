using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Areas.Admin.Models
{
    public class JobsViewModel
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string JobContent { get; set; }
        public string JobKeywords { get; set; }
        public string JobDescription { get; set; }
        public string? JobSlug { get; set; }
        public string IsActive { get; set; }
    }
}
