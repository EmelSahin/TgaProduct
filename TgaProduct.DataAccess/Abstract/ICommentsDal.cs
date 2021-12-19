using System.Collections.Generic;
using TgaProduct.Entities.Concrete;

namespace TgaProduct.DataAccess.Abstract
{
    public interface ICommentsDal : IGenericDal<Comments>
    {
        List<Comments> GetByProductComment(int id);

    }
}
