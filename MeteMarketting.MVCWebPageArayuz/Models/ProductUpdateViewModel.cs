using System.Collections.Generic;
using MeteMarketting.Entity.SomutNesnelerim;

namespace MeteMarketting.MVCWebPageArayuz.Models
{
    public class ProductUpdateViewModel
    {
        public Product Product { get; set; }
        public List<Product> Categories { get; set; }
    }
}