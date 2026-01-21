namespace OnlineShop.Data
{
    public class OrderDetail
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; } = 0;
        public decimal Discount { get; set; } = 0;
    }
}
