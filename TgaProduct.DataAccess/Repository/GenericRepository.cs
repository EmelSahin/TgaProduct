using System.Collections.Generic;
using System.Linq;
using TgaProduct.DataAccess.Abstract;
using TgaProduct.DataAccess.Concrete;

namespace TgaProduct.DataAccess.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public DatabaseContext _databaseContext = new DatabaseContext();

        public void Add(T entity)
        {
            _databaseContext.Add(entity);
            _databaseContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            _databaseContext.Remove(entity);
            _databaseContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _databaseContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _databaseContext.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _databaseContext.Update(entity);
            _databaseContext.SaveChanges();
        }
    }
}
