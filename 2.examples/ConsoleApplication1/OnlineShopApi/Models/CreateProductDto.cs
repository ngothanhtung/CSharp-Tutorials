using System.ComponentModel.DataAnnotations;

namespace OnlineShopApi.Models
{
    public class CreateProductDto
    {
        [Required()]
        [StringLength(100)]
        public required string Name { get; set; }


        [Required()]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be a positive value.")]
        public required decimal Price { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Price must be a non-negative value.")]
        public decimal? Stock { get; set; } = 0;


        [Range(0, 90, ErrorMessage = "Discount must be between 0 and 90.")]
        public decimal? Discount { get; set; } = 0;

        [Required()]
        public required int CategoryId { get; set; }

        [Required()]
        public required int SupplierId { get; set; }


        public string Description { get; set; }
    }
}
