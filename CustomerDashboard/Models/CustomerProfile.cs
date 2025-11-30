namespace CustomerDashboard.Models
{
    public class CustomerProfile
    {
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string JoinDate { get; set; }
        public string AccountType { get; set; }
        public double TotalSpent { get; set; }
        public string Currency { get; set; }
    }
}
