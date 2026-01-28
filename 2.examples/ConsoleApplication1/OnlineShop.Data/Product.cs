using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Data
{
    [Table("Products")]
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public decimal Discount { get; set; }

        public decimal Stock { get; set; }

        public string? Description { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; }

        public int SupplierId { get; set; }

        public Supplier? Supplier { get; set; }

        public IList<OrderDetail>? OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
