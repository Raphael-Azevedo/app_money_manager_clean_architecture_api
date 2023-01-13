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
        public async Task<ResultModel> AddTransaction()
        {
            try
            {
                var result = await _transactionDAL.AddTransaction();

                return new ResultModel { Error = null, Success = true, ResultData = result };

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ResultModel> DeleteTransaction()
        {
            try
            {
                var result = await _transactionDAL.DeleteTransaction();

                return new ResultModel { Error = null, Success = true, ResultData = result };

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ResultModel> GetAllTransaction()
        {
            try
            {
                var result = await _transactionDAL.GetAllTransaction();

                return new ResultModel { Error = null, Success = true, ResultData = result };

            }
            catch (Exception)
            {
                throw;
            }
        }

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
        public async Task<ResultModel> UpdateTransaction()
        {
            try
            {
                var result = await _transactionDAL.UpdateTransaction();

                return new ResultModel { Error = null, Success = true, ResultData = result };

            }
            catch (Exception)
            {
                throw;
            }
        }
       
    }
}
