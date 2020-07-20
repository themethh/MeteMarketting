using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeteMarketting.Entity.SomutNesnelerim;

namespace MeteMarketting.MVCWebPageArayuz.Servisler
{
    public interface ISepetSessionServis
    {
        Sepet GetSepet();
        void SetSepet(Sepet sepet);
    }
}
