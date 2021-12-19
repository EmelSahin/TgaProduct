using System.Collections.Generic;
using TgaProduct.Entities.Concrete;

namespace TgaProduct.Business.Abstract
{
    public interface IUserService
    {
        void Add(Users entity);
        void Update(Users entity);
        void Delete(Users entity);
        List<Users> GetAll();
        Users GetById(int id);
    }
}
