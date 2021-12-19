using System;
using System.ComponentModel.DataAnnotations;

namespace TgaProduct.Entities.Concrete
{
    public class Comments
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Comment { get; set; }
        public string FullName { get; set; }
        public string Title { get; set; }
        public int ProductId { get; set; }
    }
}
