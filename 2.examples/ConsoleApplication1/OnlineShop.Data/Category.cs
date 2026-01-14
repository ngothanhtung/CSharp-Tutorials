using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Data
{
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public IList<Product> Products { get; set; }
    }
}
