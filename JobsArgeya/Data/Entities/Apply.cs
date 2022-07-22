using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Data.Entities
{
    public class Apply
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string University { get; set; }
        public string Faculty { get; set; }
        public string Resume { get; set; }
        public string CvPath { get; set; }
        public int? JobId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? IsIntern { get; set; }
        public DateTime? InternStartDate { get; set; }
        public DateTime? InternEndDate { get; set; }
        public int CompanyId { get; set; }
    }
}
