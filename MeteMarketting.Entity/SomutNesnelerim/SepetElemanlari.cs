using System;
using System.Text;

namespace MeteMarketting.Entity.SomutNesnelerim
{
    public class SepetElemanlari
    {
        public Product urun { get; set; }
        public int Adet { get; set; }

        public int StokBirimi { get; set; }

        public int BirimFiyat { get; set; }
    }
}
