using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeteMarketting.Entity.SomutNesnelerim;
using MeteMarketting.MVCWebPageArayuz.Models;
using MeteMarketting.Workstation.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MeteMarketting.MVCWebPageArayuz.Controllers
{
    [Authorize]
    public class AdminController:Controller
    {
        private IUrunServis _urunServis;

        public AdminController(IUrunServis urunServis)
        {
            _urunServis = urunServis;
        }

        public ActionResult Index()
        {
            var ProductListLiewModel = new ProductListViewModel
            {
                Products = _urunServis.GetAll()
            };
            return View(ProductListLiewModel);
        }

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                _urunServis.Add(product);
                TempData.Add("message", "Ürün Eklendi");
            }
           
            return View("Add");
        }

        public ActionResult Update(int productId)
        {
            var model = new ProductUpdateViewModel
            {
                Product = _urunServis.GetById(productId),
                Categories =_urunServis.GetAll()
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                _urunServis.Update(product);
                TempData.Add("message", "Ürün Güncellendi");
            }

            return View("Update");
        }

        public ActionResult Delete(int productId)
        {
            _urunServis.Delete(productId);
            TempData.Add("message", "Ürün Silindi");
            return RedirectToAction("Index");
        }


    }
}
