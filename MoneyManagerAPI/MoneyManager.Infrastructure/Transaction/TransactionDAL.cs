using Microsoft.WindowsAzure.Storage.Table;
using MoneyManager.Core.Models.Transaction;
using MoneyManager.Core.Providers.Transaction;
using MoneyManager.Infrastructure.Base;
using Microsoft.WindowsAzure.Storage;

namespace MoneyManager.Infrastructure.Transaction
{
    public class TransactionDAL : BaseDAL, ITransactionDAL
    {
        public TransactionDAL(IWebHostEnvironment environment, IConfiguration configuration) : base(environment, configuration)
        {
        }

        public Task<TransactionBaselineModel> AddTransaction()
        {
            throw new NotImplementedException();
        }

        public Task<TransactionBaselineModel> DeleteTransaction()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TransactionBaselineModel>> GetAllTransaction()
        {
            try
            {
                var storageAccount = CloudStorageAccount.Parse(GetAzureBlobStorageConnectionString());
                var tableClient = storageAccount.CreateCloudTableClient();
                var table = tableClient.GetTableReference("Transactions");
                await table.CreateIfNotExistsAsync();

                string partitionKey = "transactions";
                var query = new TableQuery<TransactionBaselineModel>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, partitionKey));

                var transactions = await table.ExecuteQuerySegmentedAsync(query, null);
                return transactions;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// GetMonthTransaction - Return the Transaction List filtered by actual month
        /// App =>  - method => 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<TransactionBaselineModel>> GetMonthTransaction()
        {
            var transaction = new TransactionBaselineModel
            {
                Title = "teste",
                Description = "teste",
                Value = 22.3,
                Date = DateTime.Now,
                Category = "Moradia"
            };

            try
            {
                var storageAccount = CloudStorageAccount.Parse(GetAzureBlobStorageConnectionString());
                var tableClient = storageAccount.CreateCloudTableClient();
                var table = tableClient.GetTableReference("Transactions");
                await table.CreateIfNotExistsAsync();

                string partitionKey = "transactions";
                var query = new TableQuery<TransactionBaselineModel>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, partitionKey));

                var transactions = await table.ExecuteQuerySegmentedAsync(query, null);
                return transactions;
            }
            catch (Exception )
            {
                throw;
            }
           
        }

        public Task<TransactionBaselineModel> UpdateTransaction()
        {
            throw new NotImplementedException();
        }
    }
}

