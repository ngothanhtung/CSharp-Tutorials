using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnlineShop.Data.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            // Mapping to "Customers" table
            builder.ToTable("Customers", tb =>
            {
                // Birthday >= 18 years constraint
                tb.HasCheckConstraint("CK_Customers_Birthday", "YEAR(Birthday) <= YEAR(GETDATE()) - 18 OR Birthday IS NULL");
            });

            // Primary Key
            builder.HasKey(c => c.Id);

            // Properties

            // First Name
            builder.Property(c => c.FirstName)
                .IsRequired() // Not null
                .HasMaxLength(50); // Max length 50

            // Last Name
            builder.Property(c => c.LastName)
                .IsRequired() // Not null
                .HasMaxLength(50); // Max length 50

            // PhoneNumber
            builder.Property(c => c.PhoneNumber)
                .IsUnicode(false)
                .HasMaxLength(15); // Max length 15

            // Email
            builder.Property(c => c.Email)
                .IsUnicode(false)
                .IsRequired() // Not null
                .HasMaxLength(50); // Max length 50


            // Address
            builder.Property(c => c.Address)
                .IsRequired() // Not null
                .HasMaxLength(500); // Max length 500


            // Birthday
            builder.Property(c => c.Birthday)
                .IsRequired(false);


            // Unique Constraints

            // Email
            builder.HasIndex(c => c.Email)
                .IsUnique();

            // PhoneNumber
            builder.HasIndex(c => c.PhoneNumber)
                .IsUnique();

            // Relationships
            builder.HasOne(c => c.Account)
                .WithOne(a => a.Customer)
                .HasForeignKey<Customer>(c => c.Id)
                .OnDelete(DeleteBehavior.NoAction);

            // Orders
            builder.HasMany(c => c.Orders)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
