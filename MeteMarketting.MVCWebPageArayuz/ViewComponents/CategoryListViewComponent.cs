using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeteMarketting.MVCWebPageArayuz.Models;
using MeteMarketting.Workstation.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace MeteMarketting.MVCWebPageArayuz.ViewComponents
{
    public class CategoryListViewComponent:ViewComponent
    {
        private IKategoriServis _kategoriServis;

        public CategoryListViewComponent(IKategoriServis kategoriServis)
        {
            _kategoriServis = kategoriServis;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel
            {
                Categories = _kategoriServis.GetAll(),
                
            };

            return View(model);
        }
    }
}
