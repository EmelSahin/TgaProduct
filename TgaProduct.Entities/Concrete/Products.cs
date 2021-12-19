using System.ComponentModel.DataAnnotations;

namespace TgaProduct.Entities.Concrete
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public string Price { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
    }
}
