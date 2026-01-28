namespace OnlineShop.Data
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime? ShippedDate { get; set; }

        public string Status { get; set; }

        public string PaymentType { get; set; }

        public string? ShippingAddress { get; set; }

        public string? ShippingCity { get; set; }

        public string? Description { get; set; }

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }

        public IList<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
