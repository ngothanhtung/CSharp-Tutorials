namespace OnlineShop.Data
{
    public class Order
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public IList<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
