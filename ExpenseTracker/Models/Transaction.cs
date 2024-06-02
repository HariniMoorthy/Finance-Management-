namespace ExpenseTracker.Models
{
    public class Transaction
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime? Date { get; set; }
        public bool IsIncome { get; set; }
        public string CategoryName { get; set; }
    }
}
