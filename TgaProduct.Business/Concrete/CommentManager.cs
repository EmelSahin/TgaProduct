using System.Collections.Generic;
using TgaProduct.Business.Abstract;
using TgaProduct.DataAccess.Abstract;
using TgaProduct.Entities.Concrete;

namespace TgaProduct.Business.Concrete
{
    public class CommentManager : ICommentService
    {
        private ICommentsDal _commentsDal;

        public CommentManager(ICommentsDal commentsDal)
        {
            _commentsDal = commentsDal;
        }

        public void Add(Comments entity)
        {
            _commentsDal.Add(entity);
        }

        public void Delete(Comments entity)
        {
            _commentsDal.Delete(entity);
        }

        public List<Comments> GetAll()
        {
            return _commentsDal.GetAll();
        }

        public Comments GetById(int id)
        {
            return _commentsDal.GetById(id);
        }

        public List<Comments> CommentList(int id)
        {
            return _commentsDal.GetByProductComment(id);
        }

        public void Update(Comments entity)
        {
            _commentsDal.Update(entity);
        }
    }
}
