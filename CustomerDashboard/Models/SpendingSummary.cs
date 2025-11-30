namespace CustomerDashboard.Models
{
    public class SpendingSummary
    {
        public string Period { get; set; }
        public double TotalSpent { get; set; }
        public int TransactionCount { get; set; }
        public double AverageTransaction { get; set; }
        public string TopCategory { get; set; }
        public ComparedPeriod ComparedToPrevious { get; set; }
    }

    public class ComparedPeriod
    {
        public double SpentChange { get; set; }
        public double TransactionChange { get; set; }
    }
}
