using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnlineShop.Data.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            // Mapping to "Employees" table
            builder.ToTable("Employees");

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
                .HasMaxLength(500); // Max length 50


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
                .WithOne(a => a.Employee)
                .HasForeignKey<Employee>(c => c.Id)
                .OnDelete(DeleteBehavior.NoAction);

            // Orders
            builder.HasMany(c => c.Orders)
                .WithOne(o => o.Employee)
                .HasForeignKey(o => o.EmployeeId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
