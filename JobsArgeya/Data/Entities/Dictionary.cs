using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Data.Entities
{
    public class Dictionary
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(2)]
        public string LangCode { get; set; }
        [StringLength(100)]
        public string Key { get; set; }
        [StringLength(255)]
        public string Value { get; set; }
    }
}
