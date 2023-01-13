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
        #region Get All Transactions
        /// <summary>
        /// Get All Transactions - Home Screen
        /// </summary>
        /// <returns></returns>
        Task<ResultModel> GetAllTransaction();
        #endregion
        #region Add Transaction
        /// <summary>
        /// Add Transaction - Home Screen
        /// </summary>
        /// <returns></returns>
        Task<ResultModel> AddTransaction();
        #endregion
        #region Update Transaction
        /// <summary>
        /// Update Transaction - Home Screen
        /// </summary>
        /// <returns></returns>
        Task<ResultModel> UpdateTransaction();
        #endregion
        #region Delete Transactions
        /// <summary>
        /// Delete Transactions - Home Screen
        /// </summary>
        /// <returns></returns>
        Task<ResultModel> DeleteTransaction();
        #endregion
    }
}
