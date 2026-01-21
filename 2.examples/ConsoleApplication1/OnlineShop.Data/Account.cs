namespace OnlineShop.Data
{
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime LastLogin { get; set; }

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}
