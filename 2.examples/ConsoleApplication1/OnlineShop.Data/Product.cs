using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Data
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public decimal Discount { get; set; }

        public decimal Stock { get; set; }

        // Foreign keys
        public int CategoryId { get; set; }

        // Many products belongs to one category
        public Category? Category { get; set; }


        public int SupplierId { get; set; }

        public Supplier? Supplier { get; set; }

        public IList<OrderDetail> OrderDetails { get; set; }
    }
}
