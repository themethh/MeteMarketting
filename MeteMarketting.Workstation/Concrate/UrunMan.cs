
using System.Collections.Generic;

using MeteMarketting.Data.Abstract;

using MeteMarketting.Entity.SomutNesnelerim;
using MeteMarketting.Workstation.Abstract;

namespace MeteMarketting.Workstation.Concrate
{
    public class UrunMan: IUrunServis
    {
        private IUrunVeriErisimKatmani _urunVeriErisimKatmani;

        public UrunMan(IUrunVeriErisimKatmani urunVeriErisimKatmani)
        {
            _urunVeriErisimKatmani = urunVeriErisimKatmani;
        }

        public List<Product> GetAll()
        {
            return _urunVeriErisimKatmani.GetList();
        }

        public List<Product> GetByCategory(int KategoriId)
        {
            return _urunVeriErisimKatmani.GetList(p => p.KategoriId == KategoriId);
        }

        public void Add(Product product)
        {
            _urunVeriErisimKatmani.Add(product);
        }

        public void Delete(int productId)
        {
            _urunVeriErisimKatmani.Delete(new Product {UrunId = productId});
        }

        public void Update(Product product)
        {
            _urunVeriErisimKatmani.Update(product);
        }

        public Product GetById(int productId)
        {
           return _urunVeriErisimKatmani.Get(p => p.UrunId == productId);
        }

       
    }
}
