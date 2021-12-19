using Microsoft.AspNetCore.Mvc;
using System;
using TgaProduct.Business.Concrete;
using TgaProduct.DataAccess.Concrete.EntityFramework;
using TgaProduct.Entities.Concrete;
using TgaProduct.MvcCoreWebUI.Models;

namespace TgaProduct.MvcCoreWebUI.Controllers
{
    public class CommentController : Controller
    {
        private CommentManager _commentManager = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            var getList = _commentManager.GetAll();
            return View(getList);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ProductCommentViewModel model)
        {
            Comments comments = new Comments();

            comments.FullName = model.FullName;
            comments.CreateDate = DateTime.Now;
            comments.Comment = model.Comment;
            comments.ProductId = Convert.ToInt32(model.HiddenId);
            comments.Title = model.Title;
            _commentManager.Add(comments);
            return RedirectToAction("detail", "product", new { id = model.HiddenId });
        }
    }
}
