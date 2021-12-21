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
        public IActionResult Add(CommentViewModel model)
        {
            Comments comments = new Comments();
            comments.FullName = model.FullName;
            comments.CreateDate = DateTime.Now;
            comments.Comment = model.Comment;
            comments.ProductId = Convert.ToInt32(model.ProductId);
            comments.Title = model.Title;


            //if (!string.IsNullOrEmpty(model.Comment))
            //{
            //    var client = new RestClient("https://twinword-emotion-analysis-v1.p.rapidapi.com/analyze/");
            //    var request = new RestRequest(Method.POST);
            //    request.AddHeader("content-type", "application/x-www-form-urlencoded");
            //    request.AddHeader("x-rapidapi-host", "twinword-emotion-analysis-v1.p.rapidapi.com");
            //    request.AddHeader("x-rapidapi-key", "7722330e52msh5ea2575efa9153ep19b9edjsn04fb23efd4fe");
            //    request.AddParameter("application/x-www-form-urlencoded", "text=" + model.Comment + "", ParameterType.RequestBody);
            //    IRestResponse response = client.Execute(request);

            //    dynamic data = JObject.Parse(response.Content);
            //    string resultData = data.data;
            //}

            _commentManager.Add(comments);
            return RedirectToAction("detail", "product", new { id = model.ProductId });
        }
    }
}
