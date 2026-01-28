namespace OnlineShop.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime? Birthday { get; set; }


        public IList<Order>? Orders { get; set; } = new List<Order>();

        public Account? Account { get; set; }
    }
}
