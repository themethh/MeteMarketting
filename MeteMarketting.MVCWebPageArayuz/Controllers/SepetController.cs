using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeteMarketting.Entity.SomutNesnelerim;
using MeteMarketting.MVCWebPageArayuz.Models;
using MeteMarketting.MVCWebPageArayuz.Servisler;
using MeteMarketting.Workstation.Abstract;
using MeteMarketting.Workstation.Concrate;
using Microsoft.AspNetCore.Mvc;


namespace MeteMarketting.MVCWebPageArayuz.Controllers
{
    public class SepetController : Controller
    {
        private ISepetSessionServis _sepetSessionServis;
        private ISepetServis _sepetServis;
        private IUrunServis _urunServis;

        public SepetController(ISepetSessionServis sepetSessionServis, ISepetServis sepetServis, IUrunServis urunServis)
        {
            _sepetSessionServis = sepetSessionServis;
            _sepetServis = sepetServis;
            _urunServis = urunServis;
        }

        public ActionResult SepetEkle(int productId)
        {

            var urunEklendi = _urunServis.GetById(productId);

            var sepet = _sepetSessionServis.GetSepet();

            _sepetServis.SepetEkle(sepet, urunEklendi);

            _sepetSessionServis.SetSepet(sepet);

            TempData.Add("message", String.Format("Urununuz, {0}  basaralı bir sekilde eklendi", urunEklendi.UrunAd));

            return RedirectToAction("Index", "Urun");


        }

        public ActionResult List()
        {
            var sepet = _sepetSessionServis.GetSepet();
            SepetOzetiViewModel sepetOzetiViewModel = new SepetOzetiViewModel
            {
                Sepet = sepet
            };
            return View(sepetOzetiViewModel);
        }

        public ActionResult Remove(int productId)
        {
            var sepet = _sepetSessionServis.GetSepet();
            _sepetServis.SepetSil(sepet,productId);
            _sepetSessionServis.SetSepet(sepet);
            TempData.Add("message", String.Format("Urununuz, basaralı bir sekilde silindi"));
            return RedirectToAction("List");
        }

        public ActionResult Finish()
        {
            var AlisverisDetaylariViewModel = new AlisverisDetaylariViewModel
            {
                AlisverisDetaylari = new AlisverisDetaylari()
            };
            return View(AlisverisDetaylariViewModel);
        }

        [HttpPost]
        public ActionResult Finish(AlisverisDetaylari alisverisDetaylari)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            TempData.Add("message",String.Format( "{0} , Siparişiniz Tamamlandı.Siparisiniz en kısa sürede tarafınıza ulaşacaktır.", alisverisDetaylari.İsim));
            return View();

        }
    }












}

    

