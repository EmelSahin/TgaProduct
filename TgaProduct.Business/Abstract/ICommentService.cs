using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
