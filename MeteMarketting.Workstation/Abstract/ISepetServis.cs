using System;
using System.Collections.Generic;
using System.Text;
using MeteMarketting.Entity.SomutNesnelerim;

namespace MeteMarketting.Workstation.Abstract
{
    public interface ISepetServis
    {
        void SepetEkle(Sepet sepet, Product product);
        void SepetSil(Sepet sepet, int productId);
        List<SepetElemanlari> List(Sepet sepet);
    }
}
