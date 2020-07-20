using System.Collections.Generic;
using System.Linq;

namespace MeteMarketting.Entity.SomutNesnelerim
{
    public class Sepet
    {
        public Sepet()
        {
            SepetElemanlaris=new  List<SepetElemanlari>();
        }
        public List<SepetElemanlari> SepetElemanlaris { get; set; }

        public decimal Toplam
        {
            get { return SepetElemanlaris.Sum(s => s.urun.BirimFiyat * s.Adet); }
        }
    }
}