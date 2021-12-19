using System.Collections.Generic;
using TgaProduct.Entities.Concrete;

namespace TgaProduct.Business.Abstract
{
    public interface ICommentService
    {
        void Add(Comments entity);
        void Update(Comments entity);
        void Delete(Comments entity);
        List<Comments> GetAll();
        Comments GetById(int id);

        List<Comments> CommentList(int id);

    }
}
