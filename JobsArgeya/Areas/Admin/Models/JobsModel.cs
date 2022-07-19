using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Areas.Admin.Models
{
    public class JobsModel
    {
        public int id { get; set; }
        [Required]
        public string jobTitle { get; set; }
        [Required]
        public string jobContent { get; set; }
        [Required]
        public string jobKeywords { get; set; }
        [Required]
        public string jobDescription { get; set; }
        public string isActive { get; set; }
    }
}
