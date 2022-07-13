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
        [Required(ErrorMessage ="Lütfen adınız ve soyadınızı girin..")]
        [StringLength(100)]
        public string fullName { get; set; }

        [Required(ErrorMessage = "Lütfen telefonunuzu girin..")]
        [StringLength(11)]
        public string phone { get; set; }

        [Required(ErrorMessage = "Lütfen email adresinizi girin..")]
        [StringLength(100)]
        public string email { get; set; }

        [Required(ErrorMessage = "Lütfen cinsiyet seçimi yapın..")]
        public string gender { get; set; }

        [Required(ErrorMessage = "Lütfen üniversite bilginizi girin..")]
        [StringLength(100)]
        public string university { get; set; }

        [Required(ErrorMessage = "Lütfen bölüm bilginizi girin..")]
        [StringLength(100)]
        public string faculty { get; set; }

        [Required(ErrorMessage = "Lütfen özgeçmişinizi girin..")]
        [StringLength(255)]
        public string resume { get; set; }
        public int? jobId { get; set; }
    }
}
