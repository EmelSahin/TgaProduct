using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TgaProduct.DataAccess.Abstract;
using TgaProduct.DataAccess.Repository;
using TgaProduct.Entities.Concrete;

namespace TgaProduct.DataAccess.Concrete.EntityFramework
{
    public class EfProductRepository : GenericRepository<Products>, IProductDal
    {
    }
}
