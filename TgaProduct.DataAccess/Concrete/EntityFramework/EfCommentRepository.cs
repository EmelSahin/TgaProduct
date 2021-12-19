using System.Collections.Generic;
using System.Linq;
using TgaProduct.DataAccess.Abstract;
using TgaProduct.DataAccess.Repository;
using TgaProduct.Entities.Concrete;

namespace TgaProduct.DataAccess.Concrete.EntityFramework
{
    public class EfCommentRepository : GenericRepository<Comments>, ICommentsDal
    {
        public List<Comments> GetByProductComment(int id)
        {
            return _databaseContext.Comments.Where(x => x.ProductId == id).ToList();
        }
    }
}
