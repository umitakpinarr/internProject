using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Data.Entities
{
    public class MailLog
    {
        public int Id { get; set; }
        public string Mail { get; set; }
        public string Status { get; set; }
        public string StatusMessage { get; set; }
    }
}
