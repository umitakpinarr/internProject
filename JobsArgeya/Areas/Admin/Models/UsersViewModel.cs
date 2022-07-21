using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Areas.Admin.Models
{
    public class UsersViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int roleId { get; set; }
        public string roleName { get; set; }
        public int officeId { get; set; }
        public string officeName { get; set; }
        public string officeDomain { get; set; }
    }
}
