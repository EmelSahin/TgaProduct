using System.Collections.Generic;
using TgaProduct.Business.Abstract;
using TgaProduct.DataAccess.Abstract;
using TgaProduct.Entities.Concrete;

namespace TgaProduct.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(Users entity)
        {
            _userDal.Add(entity);
        }

        public void Delete(Users entity)
        {
            _userDal.Delete(entity);
        }

        public List<Users> GetAll()
        {
            return _userDal.GetAll();
        }

        public Users GetById(int id)
        {
            return _userDal.GetById(id);
        }

        public void Update(Users entity)
        {
            _userDal.Update(entity);
        }
    }
}
