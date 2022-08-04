using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Areas.Admin.Models
{
    public class JobsModel
    {
        public int Id { get; set; }
        [Required]
        public string JobTitle { get; set; }
        [Required]
        public string JobContent { get; set; }
        [Required]
        public string JobKeywords { get; set; }
        [Required]
        public string JobDescription { get; set; }
        public string IsActive { get; set; }
        public int? CompanyId { get; set; }
        public string LangCode { get; set; }
        public string Language { get; set; }
    }
}
