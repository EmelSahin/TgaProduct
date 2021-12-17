using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TgaProduct.Entities.Concrete
{
    public class Comments
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }

        public string Comment { get; set; }

        public int UserId { get; set; }

        public int ProductId { get; set; }
    }
}
