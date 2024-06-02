namespace ExpenseTracker.Models
{
    public class IncomeSource
    {
           public string Id { get; set; } = Guid.NewGuid().ToString();
            public string SourceName { get; set; }
            public decimal Amount { get; set; }
            public int FrequencyId { get; set; }
            public IncomeFrequency Frequency { get; set; }
        }

        // IncomeFrequency.cs
        public enum IncomeFrequency
        {
            Weekly,
            Biweekly,
            Monthly,
            Yearly
        }
    }

