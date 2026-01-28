using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnlineShop.Data.Configurations
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            // Mapping to "Suppliers" table
            builder.ToTable("Suppliers");

            // Primary Key
            builder.HasKey(c => c.Id);

            // Properties

            // Name
            builder.Property(c => c.Name)
                .IsRequired() // Not null
                .HasMaxLength(100); // Max length 100

            // Email
            builder.Property(c => c.Email)
                .IsUnicode(false)
                .IsRequired() // Not null
                .HasMaxLength(50); // Max length 50

            // PhoneNumber
            builder.Property(c => c.PhoneNumber)
                .IsUnicode(false)
                .IsRequired() // Not null
                .HasMaxLength(50); // Max length 50

            // Address
            builder.Property(c => c.Address)
                .IsRequired() // Not null
                .HasMaxLength(500); // Max length 50


            // Unique Constraints

            // Email
            builder.HasIndex(c => c.Email)
                .IsUnique();

            // PhoneNumber
            builder.HasIndex(c => c.PhoneNumber)
                .IsUnique();

            // Relationships
            builder.HasMany(c => c.Products)
                .WithOne(p => p.Supplier)
                .HasForeignKey(p => p.SupplierId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
