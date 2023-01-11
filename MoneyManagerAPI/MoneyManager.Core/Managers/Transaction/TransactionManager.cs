using MoneyManager.Core.Models.Result;
using MoneyManager.Core.Providers.Transaction;

namespace MoneyManager.Core.Managers.Transaction
{
    public class TransactionManager : ITransactionManager
    {
        #region Properties
        private readonly ITransactionDAL _transactionDAL;
        #endregion

        #region Constructor
        public TransactionManager(ITransactionDAL transactionDAL)
        {
            _transactionDAL = transactionDAL;
        }
        #endregion

        #region Get Month Transactions
        public async Task<ResultModel> GetMonthTransaction()
        {
            try
            {
                var result = await _transactionDAL.GetMonthTransaction();

                return new ResultModel { Error = null, Success = true, ResultData = result };

            } catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
