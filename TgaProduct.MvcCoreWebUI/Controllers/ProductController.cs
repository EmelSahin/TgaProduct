using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TgaProduct.Business.Concrete;
using TgaProduct.DataAccess.Concrete.EntityFramework;

namespace TgaProduct.MvcCoreWebUI.Controllers
{
    public class ProductController : Controller
    {
        private ProductManager _productManager = new ProductManager(new EfProductRepository());

        public IActionResult Index()
        {
            var getList = _productManager.GetAll();

            return View();
        }
    }
}
