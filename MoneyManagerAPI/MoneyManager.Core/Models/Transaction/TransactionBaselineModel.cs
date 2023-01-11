namespace MoneyManager.Core.Models.Transaction
{
    public class TransactionBaselineModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public double Value { get; set; }
        public string? Category { get; set; }
        public DateTime Date { get; set; }

    }
}
