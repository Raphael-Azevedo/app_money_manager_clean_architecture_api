using Microsoft.WindowsAzure.Storage.Table;

namespace MoneyManager.Core.Models.Transaction
{
    public class TransactionBaselineModel : TableEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public double Value { get; set; }
        public string? Category { get; set; }
        public DateTime Date { get; set; }

        public TransactionBaselineModel()
        {
            this.PartitionKey = "transactions";
            this.RowKey = Guid.NewGuid().ToString();
        }

    }
}
