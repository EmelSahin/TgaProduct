using System.Collections.Generic;
using TgaProduct.Entities.Concrete;

namespace TgaProduct.MvcCoreWebUI.Models
{
    public class ProductCommentViewModel
    {
        public int Id { get; set; }
        public List<CommentViewModel> Comments { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public string Price { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }

    }
}
