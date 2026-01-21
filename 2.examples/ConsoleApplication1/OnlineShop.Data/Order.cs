namespace OnlineShop.Data
{
    public class Order
    {
        public Order(IList<OrderDetail> orderDetails)
        {
            OrderDetails = orderDetails;
        }

        public int Id { get; set; }

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public IList<OrderDetail> OrderDetails { get; set; }
    }
}
