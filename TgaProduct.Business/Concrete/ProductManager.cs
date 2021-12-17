using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TgaProduct.Business.Abstract;
using TgaProduct.DataAccess.Abstract;
using TgaProduct.Entities.Concrete;

namespace TgaProduct.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Products entity)
        {
            _productDal.Add(entity);
        }

        public void Delete(Products entity)
        {
            _productDal.Delete(entity);
        }

        public List<Products> GetAll()
        {
            return _productDal.GetAll();
        }

        public Products GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void Update(Products entity)
        {
            _productDal.Update(entity);
        }
    }
}
