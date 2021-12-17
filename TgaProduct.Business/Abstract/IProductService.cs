using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
