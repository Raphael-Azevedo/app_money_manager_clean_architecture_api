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
    }
}
