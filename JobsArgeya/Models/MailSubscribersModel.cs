using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Models
{
    public class MailSubscribersModel
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
