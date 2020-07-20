using MeteMarketting.Core.Data.EntityFramework;
using MeteMarketting.Data.Abstract;
using MeteMarketting.Entity.SomutNesnelerim;

namespace MeteMarketting.Data.Concreate.EntityFramework
{
    public class EFKategoriVeriErisim : EFEntityRepositoryBase<Category, EcommerceContext>,IKategoriVeriErisimKatmani
    {

    }
}