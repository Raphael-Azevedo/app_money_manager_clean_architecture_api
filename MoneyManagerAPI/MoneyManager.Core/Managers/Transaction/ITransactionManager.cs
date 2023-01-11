using MoneyManager.Core.Models.Result;

namespace MoneyManager.Core.Managers.Transaction
{
    public interface ITransactionManager
    {
        #region Get Month Transactions
        /// <summary>
        /// Get Month Transactions - Home Screen
        /// </summary>
        /// <returns></returns>
        Task<ResultModel> GetMonthTransaction();
        #endregion
    }
}
