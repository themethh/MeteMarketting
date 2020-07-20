using MeteMarketting.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MeteMarketting.Entity.SomutNesnelerim
{
    public class Product:IEntity
    {
        

        [Key]
        [Required]
        public int UrunId { get; set; }
        [Required]
        public string UrunAd { get; set; }
        [Required]
        public int KategoriId { get; set; }
        [Required]
        public decimal BirimFiyat { get; set; }
        [Required]
        public short StokBirimi { get; set; }


    }
}
