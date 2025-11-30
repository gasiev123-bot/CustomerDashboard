using System.Collections.Generic;

namespace CustomerDashboard.Models
{
    public class SpendingTrends
    {
        public List<SpendingTrend> Trends { get; set; }
    }

    public class SpendingTrend
    {
        public string Month { get; set; }
        public double TotalSpent { get; set; }
        public int TransactionCount { get; set; }
        public double AverageTransaction { get; set; }
    }
}
