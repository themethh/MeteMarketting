using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeteMarketting.MVCWebPageArayuz.Models
{
    public class GirisViewModel
    {
        [Required]
        
        public string KullaniciAdi { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Parola { get; set; }

        public bool RememberMe { get; set; }
    }
}
