using System.Collections.Generic;
using TgaProduct.Entities.Concrete;

namespace TgaProduct.MvcCoreWebUI.Models
{
    public class ProductCommentViewModel
    {
        public Products Products { get; set; }
        public List<Comments> Comments { get; set; }

        public string HiddenId { get; set; }
        public string FullName { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string CreateDate { get; set; }
    }
}
