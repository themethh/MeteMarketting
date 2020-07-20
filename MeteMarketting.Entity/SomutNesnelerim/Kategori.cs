using MeteMarketting.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MeteMarketting.Entity.SomutNesnelerim
{
    public class Category:IEntity
    {
        [Key]
        public int KategoriId { get; set; }
        public string KategoriAd { get; set; }
    }
}
