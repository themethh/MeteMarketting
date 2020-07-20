using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeteMarketting.MVCWebPageArayuz.Models;
using MeteMarketting.Workstation.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MeteMarketting.MVCWebPageArayuz.Controllers
{
    public class UrunController:Controller
    {
        private IUrunServis _urunServis;

        public UrunController(IUrunServis urunservis)
        {
            _urunServis = urunservis;
        }
        public ActionResult Index(int page=1,int category=1)


        {
            int pageSize = 10;
            var products = _urunServis.GetByCategory(category);
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products.Skip((page-1)*pageSize).Take(pageSize).ToList()
            };

            return View(model);
        }

        
    }
}
