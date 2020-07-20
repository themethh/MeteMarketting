using System;
using System.Collections.Generic;
using System.Text;
using MeteMarketting.Entity.SomutNesnelerim;

namespace MeteMarketting.Workstation.Abstract
{
    public interface IUrunServis
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int KategoriId);
        void Add(Product product);
        void Delete(int productId);
        void Update(Product productId);
        Product GetById(int productId);
        

    }

    


}
