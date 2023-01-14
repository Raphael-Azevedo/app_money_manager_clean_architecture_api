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

        public async Task<TransactionBaselineModel> AddTransaction(TransactionBaselineModel transaction)
        {
            try
            {
                var storageAccount = CloudStorageAccount.Parse(GetAzureBlobStorageConnectionString());
                var tableClient = storageAccount.CreateCloudTableClient();
                var table = tableClient.GetTableReference("Transactions");
                await table.CreateIfNotExistsAsync();

                string partitionKey = "transactions";
                transaction.PartitionKey = partitionKey;

                var transactionsOperation = TableOperation.Insert(transaction);
                await table.ExecuteAsync(transactionsOperation);
                return transaction;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<TransactionBaselineModel> DeleteTransaction(TransactionBaselineModel transaction)
        {
            try
            {
                var storageAccount = CloudStorageAccount.Parse(GetAzureBlobStorageConnectionString());
                var tableClient = storageAccount.CreateCloudTableClient();
                var table = tableClient.GetTableReference("Transactions");
                await table.CreateIfNotExistsAsync();

                string partitionKey = "transactions";
                transaction.PartitionKey = partitionKey;

                var transactionsOperation = TableOperation.Delete(transaction);
                await table.ExecuteAsync(transactionsOperation);
                return transaction;
            }
            catch (Exception)
            {
                throw;
            }
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

        public async Task<TransactionBaselineModel> UpdateTransaction(TransactionBaselineModel transaction)
        {
            try
            {
                var storageAccount = CloudStorageAccount.Parse(GetAzureBlobStorageConnectionString());
                var tableClient = storageAccount.CreateCloudTableClient();
                var table = tableClient.GetTableReference("Transactions");
                await table.CreateIfNotExistsAsync();

                string partitionKey = "transactions";
                transaction.PartitionKey = partitionKey;

                var transactionsOperation = TableOperation.Replace(transaction);
                await table.ExecuteAsync(transactionsOperation);
                return transaction;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

