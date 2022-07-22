using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace JobsArgeya.Models
{
    public class ApplyModel
    {
        [Required(ErrorMessage = "Lütfen adınız ve soyadınızı girin..")]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Lütfen telefonunuzu girin..")]
        [StringLength(11)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Lütfen email adresinizi girin..")]
        [StringLength(100)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen cinsiyet seçimi yapın..")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Lütfen üniversite bilginizi girin..")]
        [StringLength(100)]
        public string University { get; set; }

        [Required(ErrorMessage = "Lütfen bölüm bilginizi girin..")]
        [StringLength(100)]
        public string Faculty { get; set; }

        [Required(ErrorMessage = "Lütfen özgeçmişinizi girin..")]
        [StringLength(255)]
        public string Resume { get; set; }
        public int? JobId { get; set; }
        public string? JobSlug { get; set; }
        public string captcha { get; set; }
        public string? IsIntern { get; set; }
        public DateTime? InternStartDate { get; set; }
        public DateTime? InternEndDate { get; set; }
    }
}
