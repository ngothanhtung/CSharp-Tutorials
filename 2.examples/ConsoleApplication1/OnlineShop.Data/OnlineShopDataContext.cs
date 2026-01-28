using Microsoft.EntityFrameworkCore;

namespace OnlineShop.Data
{
    public class OnlineShopDataContext : DbContext
    {
        // ✅ THÊM constructor này để nhận configuration từ DI
        public OnlineShopDataContext(DbContextOptions<OnlineShopDataContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Product> Products { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=server.softech.cloud;database=OnlineShopEF;user=developer;password=123456789;Encrypt=True;TrustServerCertificate=True;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Tự động apply tất cả IEntityTypeConfiguration trong assembly hiện tại
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OnlineShopDataContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
