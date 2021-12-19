using System.ComponentModel.DataAnnotations;

namespace TgaProduct.Entities.Concrete
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Photo { get; set; }
    }
}
