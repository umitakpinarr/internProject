using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Models
{
    public class MailSubscribersModel
    {
        public int id { get; set; }
        [Required]
        public string email { get; set; }
    }
}
