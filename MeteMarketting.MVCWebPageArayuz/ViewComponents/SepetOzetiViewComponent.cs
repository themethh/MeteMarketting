using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeteMarketting.Entity.SomutNesnelerim;
using MeteMarketting.MVCWebPageArayuz.Models;
using MeteMarketting.MVCWebPageArayuz.Servisler;
using MeteMarketting.Workstation.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace MeteMarketting.MVCWebPageArayuz.ViewComponents
{
    public class SepetOzetiViewComponent : ViewComponent
    {
        private ISepetSessionServis _sepetSessionServis;

        public SepetOzetiViewComponent(ISepetSessionServis sepetSessionServis)
        {
            _sepetSessionServis = sepetSessionServis;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new SepetOzetiViewModel
            {
                 Sepet = _sepetSessionServis.GetSepet()
            };
            return View(model);
        }


        
    }
}

    
