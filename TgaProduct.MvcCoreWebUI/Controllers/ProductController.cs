using Microsoft.AspNetCore.Mvc;
using System;
using TgaProduct.Business.Concrete;
using TgaProduct.DataAccess.Concrete.EntityFramework;
using TgaProduct.MvcCoreWebUI.Models;
using TgaProductML.Model;

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
            var model = new ProductCommentViewModel
            {
                Id=getProduct.Id,
                Name = getProduct.Name,
                Color = getProduct.Color,
                Description = getProduct.Description,
                Photo = getProduct.Photo,
                Price=getProduct.Price,
                Size=getProduct.Size
            };
            var getComment = _commentManager.CommentList(getId);
            model.Comments = new System.Collections.Generic.List<CommentViewModel>();
            foreach (var item in getComment)
            {
                var com = new CommentViewModel()
                {
                    Comment = item.Comment,
                    CreateDate = item.CreateDate,
                    FullName = item.FullName,
                    Title = item.Title,
                    ProductId = getId

                };
                ModelInput sampleData = new ModelInput()
                {
                    Metin =item.Comment,
                };

                // Make a single prediction on the sample data and print results
                var predictionResult = ConsumeModel.Predict(sampleData);

                com._state = predictionResult.Prediction;
                
               
                model.Comments.Add(com);
            }
           
            return View(model);
        }


        public IActionResult CommentById(int id)
        {
            var getProduct = _commentManager.CommentList(id);
            return View(getProduct);
        }
    }
}
