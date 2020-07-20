using System;
using System.Collections.Generic;
using System.Text;
using MeteMarketting.Data.Abstract;
using MeteMarketting.Entity.SomutNesnelerim;
using MeteMarketting.Workstation.Abstract;

namespace MeteMarketting.Workstation.Concrate
{
    public class KategoriMan : IKategoriServis
    {
        private IKategoriVeriErisimKatmani _kategoriVeriErisimKatmani;
        public KategoriMan(IKategoriVeriErisimKatmani kategoriVeriErisimKatmani)
        {
            _kategoriVeriErisimKatmani = kategoriVeriErisimKatmani;
        }


        public List<Category> GetAll()
        {
            return _kategoriVeriErisimKatmani.GetList();
        }
    }
}

