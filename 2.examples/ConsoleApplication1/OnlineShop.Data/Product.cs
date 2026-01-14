using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Data
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public decimal Discount { get; set; }

        public decimal Stock { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; }


        public int SupplierId { get; set; }

        public Supplier? Supplier { get; set; }
    }
}
