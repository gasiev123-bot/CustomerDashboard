using System.Collections.Generic;

namespace CustomerDashboard.Models
{
    public class GoalsResponse
    {
        public List<SpendingGoal> Goals { get; set; }
    }

    public class SpendingGoal
    {
        public string Id { get; set; }
        public string Category { get; set; }
        public double MonthlyBudget { get; set; }
        public double CurrentSpent { get; set; }
        public double PercentageUsed { get; set; }
        public int DaysRemaining { get; set; }
        public string Status { get; set; }
    }
}
