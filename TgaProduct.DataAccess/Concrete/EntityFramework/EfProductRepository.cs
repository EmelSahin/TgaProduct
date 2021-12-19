using TgaProduct.DataAccess.Abstract;
using TgaProduct.DataAccess.Repository;
using TgaProduct.Entities.Concrete;

namespace TgaProduct.DataAccess.Concrete.EntityFramework
{
    public class EfProductRepository : GenericRepository<Products>, IProductDal
    {
    }
}
