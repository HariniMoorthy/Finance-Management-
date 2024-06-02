namespace ExpenseTracker.Models
{
    public class SavingsGoal
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string GoalName { get; set; }
        public decimal TargetAmount { get; set; }
        public decimal CurrentAmount { get; set; }
        public DateTime TargetDate { get; set; }
    }
}
