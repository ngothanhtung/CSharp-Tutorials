using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnlineShop.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Mapping to "Products" table
            builder.ToTable("Products", tb =>
            {
                // Contraints

                // [Price] > 0
                tb.HasCheckConstraint("CK_OrderDetails_Price", "[Price] > 0");

                // [Quantity] > 0
                tb.HasCheckConstraint("CK_OrderDetails_Quantity", "[Quantity] > 0");

                // [Discount] >= 0 and [Discount] < 90
                tb.HasCheckConstraint("CK_OrderDetails_Discount", "[Discount] >= 0 AND [Discount] < 90");
            });

            // Primary Key
            builder.HasKey(c => c.Id);

            // Properties

            // Name property configuration
            builder.Property(c => c.Name)
                .IsRequired() // Not null
                .HasMaxLength(100); // Max length 100

            // Price property configuration
            builder.Property(od => od.Price)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            // Discount property configuration
            builder.Property(od => od.Discount)
                .IsRequired()
                .HasColumnType("decimal(18,2)")
                .HasDefaultValue(0);

            // Stock property configuration
            builder.Property(od => od.Stock)
                .IsRequired()
                .HasColumnType("decimal(18,2)")
                .HasDefaultValue(0);

            // Description property configuration
            //nvarchar(max)
            builder.Property(c => c.Description)
                .IsRequired(false);

            // Relationships
            // Category - Product (One-to-Many)
            builder.HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            // Supplier - Product (One-to-Many)
            builder.HasOne(p => p.Supplier)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.SupplierId)
                .OnDelete(DeleteBehavior.NoAction);


        }
    }
}
