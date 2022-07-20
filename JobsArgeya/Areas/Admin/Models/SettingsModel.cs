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
        [Required(ErrorMessage = "Lütfen site başlığı girin..")]
        [StringLength(100)]
        public string title { get; set; }

        [Required(ErrorMessage = "Lütfen anahtar kelime girin..")]
        [StringLength(255)]
        public string keywords { get; set; }

        [Required(ErrorMessage = "Lütfen site açıklaması girin..")]
        [StringLength(255)]
        public string description { get; set; }

        [Required(ErrorMessage = "Lütfen telefon numarası girin..")]
        public string phone { get; set; }

        [Required(ErrorMessage = "Lütfen email adresi girin..")]
        [StringLength(255)]
        public string email { get; set; }

        [Required(ErrorMessage = "Lütfen adres girin..")]
        [StringLength(100)]
        public string adress { get; set; }

        [Required(ErrorMessage = "Lütfen Facebook adresi girin..")]
        [StringLength(255)]
        public string facebook { get; set; }

        [Required(ErrorMessage = "Lütfen Instagram adresi girin..")]
        [StringLength(255)]
        public string instagram { get; set; }

        [Required(ErrorMessage = "Lütfen Twitter adresi girin..")]
        [StringLength(255)]
        public string twitter { get; set; }

        [Required(ErrorMessage = "Lütfen Linkedin adresi girin..")]
        [StringLength(255)]
        public string linkedin { get; set; }
        public string smtpServer { get; set; }
        public string smtpUsername { get; set; }
        public string smtpPassword { get; set; }
        public string smtpPort { get; set; }
        public string useSSL { get; set; }
        public string siteColor { get; set; }
        public string logo { get; set; }
    }
}
