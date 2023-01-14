using MoneyManager.Core.Models.Transaction;

namespace MoneyManager.Core.Providers.Transaction
{
    public interface ITransactionDAL
    {
        /// <summary>
        /// Get Month Transaction List
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TransactionBaselineModel>> GetMonthTransaction();
        Task<IEnumerable<TransactionBaselineModel>> GetAllTransaction();
        Task<TransactionBaselineModel> AddTransaction(TransactionBaselineModel transaction);
        Task<TransactionBaselineModel> UpdateTransaction(TransactionBaselineModel transaction);
        Task<TransactionBaselineModel> DeleteTransaction(TransactionBaselineModel transaction);
    }
}
