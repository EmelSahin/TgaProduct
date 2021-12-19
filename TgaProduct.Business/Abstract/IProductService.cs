using System.Collections.Generic;
using TgaProduct.Entities.Concrete;

namespace TgaProduct.Business.Abstract
{
    public interface IProductService
    {
        void Add(Products entity);
        void Update(Products entity);
        void Delete(Products entity);
        List<Products> GetAll();
        Products GetById(int id);
    }
}
