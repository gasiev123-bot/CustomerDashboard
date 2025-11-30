using System.Collections.Generic;

namespace CustomerDashboard.Models
{
    public class SpendingByCategory
    {
        public DateRange DateRange { get; set; }
        public double TotalAmount { get; set; }
        public List<CategoryBreakdown> Categories { get; set; }
    }

    public class DateRange
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }

    public class CategoryBreakdown
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public double Percentage { get; set; }
        public int TransactionCount { get; set; }
        public string Color { get; set; }
        public string Icon { get; set; }
    }
}
