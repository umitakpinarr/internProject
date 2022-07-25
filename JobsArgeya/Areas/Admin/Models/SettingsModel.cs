using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobsArgeya.Areas.Admin.Models
{
    public class SettingsModel
    {
        public int CompanyId { get; set; } 
        [Required(ErrorMessage = "Lütfen site başlığı girin..")]
        [StringLength(100)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen anahtar kelime girin..")]
        [StringLength(255)]
        public string Keywords { get; set; }

        [Required(ErrorMessage = "Lütfen site açıklaması girin..")]
        [StringLength(255)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Lütfen telefon numarası girin..")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Lütfen email adresi girin..")]
        [StringLength(255)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen adres girin..")]
        [StringLength(100)]
        public string Adress { get; set; }

        [Required(ErrorMessage = "Lütfen Facebook adresi girin..")]
        [StringLength(255)]
        public string Facebook { get; set; }

        [Required(ErrorMessage = "Lütfen Instagram adresi girin..")]
        [StringLength(255)]
        public string Instagram { get; set; }

        [Required(ErrorMessage = "Lütfen Twitter adresi girin..")]
        [StringLength(255)]
        public string Twitter { get; set; }

        [Required(ErrorMessage = "Lütfen Linkedin adresi girin..")]
        [StringLength(255)]
        public string Linkedin { get; set; }
        public string SmtpServer { get; set; }
        public string SmtpUsername { get; set; }
        public string SmtpPassword { get; set; }
        public string SmtpPort { get; set; }
        public string UseSSL { get; set; }
        public string SiteColor { get; set; }
        public string Logo { get; set; }
        public string DarkLogo { get; set; }
    }
}
