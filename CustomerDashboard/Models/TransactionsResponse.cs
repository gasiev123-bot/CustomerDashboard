using System.Collections.Generic;

namespace CustomerDashboard.Models
{
    public class TransactionsResponse
    {
        public List<Transaction> Transactions { get; set; }
        public Pagination Pagination { get; set; }
    }

    public class Transaction
    {
        public string Id { get; set; }
        public string Date { get; set; }
        public string Merchant { get; set; }
        public string Category { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public string PaymentMethod { get; set; }
        public string Icon { get; set; }
        public string CategoryColor { get; set; }
    }

    public class Pagination
    {
        public int Total { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
        public bool HasMore { get; set; }
    }
}
