using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace ExpenseTracker.Models
{
    public class FinanceData
    {
        public String Id { get; set; } = Guid.NewGuid().ToString();
        public List<Category> Category { get; set; }
        public List<IncomeSource> IncomeSources { get; set; }
        public List<SavingsGoal> SavingsGoals{ get; set; }
        public List<Transaction> Transactions { get; set; }
        public string userId { get; set; }
        //public string Email { get; internal set; }
        //public string Username { get; internal set; }
        //public string PasswordHash { get; internal set; }
    }
}
