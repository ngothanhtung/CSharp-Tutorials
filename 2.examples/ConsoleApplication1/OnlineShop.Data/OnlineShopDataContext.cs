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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Write Fluent API configurations here

            // Property Configurations
            modelBuilder.Entity<Customer>()
                .Property(c => c.FirstName)
                .HasColumnName("FirstName")
                // Rất cụ thể về kiểu dữ liệu cho MSSQL Server
                .HasColumnType("nvarchar")
                // Unicode support: MSSQL/MySQl/PostgreSQL
                .IsUnicode(true) // true by default, false
                .HasMaxLength(100)
                .IsRequired();

            // Primary Key Configuration
            modelBuilder.Entity<Customer>().HasKey(c => c.Id);

            // Table Mapping
            modelBuilder.Entity<Customer>().ToTable("Customers");



            // Table Mapping
            // New method syntax
            // Within ToTable, you can also configure Check Constraints
            // Many check constraints can be defined for a table: Price> 0, Discount >= 0, Stock >= 0

            //modelBuilder.Entity<Product>()
            //    .ToTable("Products", tb => tb.HasCheckConstraint("CK_Product_Price", "[Price] >= 0"));

            //// Another Check Constraint
            //modelBuilder.Entity<Product>()
            //    .ToTable("Products", tb => tb.HasCheckConstraint("CK_Product_Discount", "[Discount] >= 0 AND [Discount] <= 90"));


            // Cách viết gộp:
            modelBuilder.Entity<Product>()
                .ToTable("Products", tb =>
                {
                    tb.HasCheckConstraint("CK_Product_Price", "[Price] >= 0");
                    tb.HasCheckConstraint("CK_Product_Discount", "[Discount] >= 0 AND [Discount] <= 90");
                });


            // Default Values
            modelBuilder.Entity<Product>()
                .Property(p => p.Stock)
                // Has total 18 digits
                // Has 4 decimal places
                .HasPrecision(18, 4)
                .HasDefaultValue(0);
            // Configure Check contraint: Product.Price > 0

            // Old method syntax
            //modelBuilder.Entity<Product>()
            //    .HasCheckConstraint("CK_Product_Price", "[Price] >= 0");

            // Relationships configurations can be done here as well

            // One Category has many Products
            // Or Many Products belongs to one Category
            modelBuilder.Entity<Product>()
                .HasOne<Category>(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            // One Account, one Customer
            modelBuilder.Entity<Customer>()
                .HasOne<Account>(c => c.Account)
                .WithOne(a => a.Customer)
                .HasForeignKey<Account>(a => a.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);


            // Many to many relationship between Product and Order via OrderDetail
            modelBuilder.Entity<OrderDetail>()
                // Primary Key configuration for OrderDetail: has composite key
                .HasKey(od => new { od.OrderId, od.ProductId });

            // Order - OrderDetail : One to Many
            modelBuilder.Entity<OrderDetail>()
                .HasOne<Order>(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            // Product - OrderDetail : One to Many
            modelBuilder.Entity<OrderDetail>()
                .HasOne<Product>(od => od.Product)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(od => od.ProductId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
