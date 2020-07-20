using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeteMarketting.Entity.SomutNesnelerim;
using MeteMarketting.MVCWebPageArayuz.SessionMethod;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;

namespace MeteMarketting.MVCWebPageArayuz.Servisler
{
    public class SepetSessionServis:ISepetSessionServis
    {
        private IHttpContextAccessor _httpContextAccessor;

        public SepetSessionServis(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public Sepet GetSepet()
        {
            Sepet sepetKontrol = _httpContextAccessor.HttpContext.Session.GetObject<Sepet>("sepet");
            if (sepetKontrol == null)
            {
                _httpContextAccessor.HttpContext.Session.SetObject("sepet",new Sepet());
                sepetKontrol = _httpContextAccessor.HttpContext.Session.GetObject<Sepet>("sepet");
            }

            return sepetKontrol;
        }
    
        public void SetSepet(Sepet sepet)
        {
            _httpContextAccessor.HttpContext.Session.SetObject("sepet",sepet);
        }
    }
}
