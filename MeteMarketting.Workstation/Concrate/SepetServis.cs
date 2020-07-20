using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MeteMarketting.Entity.SomutNesnelerim;
using MeteMarketting.Workstation.Abstract;

namespace MeteMarketting.Workstation.Concrate
{
    public class SepetServis:ISepetServis
    {
        public void SepetEkle(Sepet sepet, Product product)
        {
            SepetElemanlari sepetElemanlari =
                sepet.SepetElemanlaris.FirstOrDefault(s =>s.urun.UrunId == product.UrunId);
            if (sepetElemanlari!=null)
            {
                sepetElemanlari.Adet++;
                return;
            }
            sepet.SepetElemanlaris.Add(new SepetElemanlari{urun = product,Adet = 1});



        }

        public void SepetSil(Sepet sepet, int productId)
        {
            sepet.SepetElemanlaris.Remove(sepet.SepetElemanlaris.FirstOrDefault(s => s.urun.UrunId == productId));
        }

        public List<SepetElemanlari> List(Sepet sepet)
        {
            return sepet.SepetElemanlaris;
        }
    }
}
