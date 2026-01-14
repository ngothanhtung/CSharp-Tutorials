using Microsoft.EntityFrameworkCore;

namespace OnlineShop.Data
{
    public class OnlineShopDataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Product> Products { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=server.softech.cloud;database=OnlineShopEF;user=developer;password=123456789;Encrypt=True;TrustServerCertificate=True;");
        }
    }
}
