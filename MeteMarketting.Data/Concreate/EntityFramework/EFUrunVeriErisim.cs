using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using MeteMarketting.Core.Data.EntityFramework;
using MeteMarketting.Data.Abstract;
using MeteMarketting.Entity.SomutNesnelerim;

namespace MeteMarketting.Data.Concreate.EntityFramework
{
    public class EFUrunVeriErisim : EFEntityRepositoryBase<Product, EcommerceContext>, IUrunVeriErisimKatmani
    {
        
    }
}
