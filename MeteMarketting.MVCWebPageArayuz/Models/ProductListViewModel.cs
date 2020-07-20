using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeteMarketting.Entity.SomutNesnelerim;

namespace MeteMarketting.MVCWebPageArayuz.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; internal set; }
    }
}
