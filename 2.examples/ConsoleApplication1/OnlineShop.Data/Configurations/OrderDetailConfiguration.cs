using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnlineShop.Data.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            // Mapping to "OrderDetails" table
            builder.ToTable("OrderDetails", tb =>
            {
                // Contraints

                // [Price] > 0
                tb.HasCheckConstraint("CK_OrderDetails_Price", "[Price] > 0");

                // [Quantity] > 0
                tb.HasCheckConstraint("CK_OrderDetails_Quantity", "[Quantity] > 0");

                // [Discount] >= 0 and [Discount] < 90
                tb.HasCheckConstraint("CK_OrderDetails_Discount", "[Discount] >= 0 AND [Discount] < 90");
            });

            // Composite primary key
            builder.HasKey(od => new { od.OrderId, od.ProductId });


            // Quantity property configuration
            builder.Property(od => od.Quantity)
                   .IsRequired();


            // Price property configuration
            builder.Property(od => od.Price)
                   .IsRequired()
                   .HasColumnType("decimal(18,2)");

            // Discount property configuration
            builder.Property(od => od.Discount)
                   .IsRequired()
                   .HasColumnType("decimal(18,2)");

            // Relationships


            // Order - OrderDetail (One-to-Many)
            builder.HasOne(od => od.Order)
                   .WithMany(o => o.OrderDetails)
                   .HasForeignKey(od => od.OrderId)
                   .OnDelete(DeleteBehavior.NoAction);

            // Product - OrderDetail (One-to-Many)
            builder.HasOne(od => od.Product)
                     .WithMany(p => p.OrderDetails)
                     .HasForeignKey(od => od.ProductId)
                     .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
