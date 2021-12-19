using Microsoft.AspNetCore.Mvc;
using System;
using TgaProduct.Business.Concrete;
using TgaProduct.DataAccess.Concrete.EntityFramework;
using TgaProduct.MvcCoreWebUI.Models;

namespace TgaProduct.MvcCoreWebUI.Controllers
{
    public class ProductController : Controller
    {
        private ProductManager _productManager = new ProductManager(new EfProductRepository());
        private CommentManager _commentManager = new CommentManager(new EfCommentRepository());


        public IActionResult Index()
        {
            var getList = _productManager.GetAll();

            return View(getList);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("index", "product");
            }
            int getId = Convert.ToInt32(id);
            var getProduct = _productManager.GetById(getId);
            var getComment = _commentManager.CommentList(getId);

            var model = new ProductCommentViewModel
            {
                Comments = getComment,
                Products = getProduct
            };
            return View(model);
        }


        public IActionResult CommentById(int id)
        {
            var getProduct = _commentManager.CommentList(id);
            return View(getProduct);
        }
    }
}
