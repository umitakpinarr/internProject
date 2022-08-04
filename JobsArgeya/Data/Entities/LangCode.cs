using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Data.Entities
{
    public class LangCode
    {
        [Key, StringLength(2)]
        public string Code { get; set; }
        [StringLength(10)]
        public string Language { get; set; }
    }
}
