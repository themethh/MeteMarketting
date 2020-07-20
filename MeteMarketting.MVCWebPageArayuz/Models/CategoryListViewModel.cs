using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeteMarketting.Entity.SomutNesnelerim;


namespace MeteMarketting.MVCWebPageArayuz.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get;  set; }
        public int CurrentCategory { get; set; }
    }
    public class SepetOzetiViewModel
    {
        public Sepet Sepet { get; set; }
    }
}
