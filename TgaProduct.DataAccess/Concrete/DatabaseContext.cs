using Microsoft.EntityFrameworkCore;
using TgaProduct.Entities.Concrete;

namespace TgaProduct.DataAccess.Concrete
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=LAPTOP-GL11H99T\SQLEXPRESS;database=TgaData;integrated security=true;");
        }
        public DbSet<Products> Products { get; set; }

        public DbSet<Users> Users { get; set; }

        public DbSet<Comments> Comments { get; set; }
    }
}
