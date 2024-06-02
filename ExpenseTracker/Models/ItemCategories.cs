namespace ExpenseTracker.Models
{
    public class ItemCategories
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public List<Category> Categories { get; set;} = new List<Category>();

    }
}
