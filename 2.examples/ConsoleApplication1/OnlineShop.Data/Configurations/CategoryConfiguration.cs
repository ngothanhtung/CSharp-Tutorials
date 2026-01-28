using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnlineShop.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // Mapping to "Categories" table
            builder.ToTable("Categories");

            // Primary Key
            builder.HasKey(c => c.Id);

            // Properties
            builder.Property(c => c.Name)
                .IsRequired() // Not null
                .HasMaxLength(100); // Max length 100

            builder.Property(c => c.Description)
                .HasMaxLength(500); // Max length 500

            // Unique constraint on Name
            builder.HasIndex(c => c.Name)
                .IsUnique();

            // Relationships
            builder.HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
