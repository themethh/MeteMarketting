using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MeteMarketting.Entity.SomutNesnelerim
{
    public class AlisverisDetaylari
    {
        [Required]
        public string İsim { get; set; }
        [Required]
        public string Soyisim { get; set; }
        [Required]
        public int Yas { get; set; }
        public string Cinsiyet { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Adres { get; set; }

    }
}
