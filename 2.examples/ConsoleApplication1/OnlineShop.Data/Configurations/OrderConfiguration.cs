using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnlineShop.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            // Map to "Orders" table
            builder.ToTable("Orders", tb =>
            {
                // ShippedDate >= OrderDate constraint
                tb.HasCheckConstraint("CK_Orders_ShippedDate_OrderDate", "[ShippedDate] >= [OrderDate]");

                // Status allowed values constraint
                tb.HasCheckConstraint("CK_Orders_Status", "[Status]='CANCELED' OR [Status]='COMPLETED' OR [Status]='WAITING'");

                // PaymentType allowed values constraint
                tb.HasCheckConstraint("CHK_Orders_PaymentType", "[PaymentType]='CREDIT CARD' OR [PaymentType]='CASH'");
            });

            // Primary Key
            builder.HasKey(o => o.Id);

            // Default value for OrderDate
            builder.Property(o => o.OrderDate)
                   .HasDefaultValueSql("GETDATE()");

            // Relationship between Order and Customer
            builder.HasOne(o => o.Customer)
                   .WithMany(c => c.Orders)
                   .HasForeignKey(o => o.CustomerId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Relationship between Order and Employee
            builder.HasOne(o => o.Employee)
                   .WithMany(e => e.Orders)
                   .HasForeignKey(o => o.EmployeeId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Relationship between Order and OrderDetails
            builder.HasMany(o => o.OrderDetails)
                   .WithOne(od => od.Order)
                   .HasForeignKey(od => od.OrderId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
