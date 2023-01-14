using MoneyManager.Core.Models.Result;
using MoneyManager.Core.Models.Transaction;
using MoneyManager.Core.Providers.Transaction;
using System.Data.Common;
using System.Transactions;

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
        public async Task<ResultModel> AddTransaction(TransactionBaselineModel transaction)
        {
            try
            {
                var result = await _transactionDAL.AddTransaction(transaction);

                return new ResultModel { Error = null, Success = true, ResultData = result };

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ResultModel> DeleteTransaction(TransactionBaselineModel transaction)
        {
            try
            {
                var result = await _transactionDAL.DeleteTransaction(transaction);

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
        public async Task<ResultModel> UpdateTransaction(TransactionBaselineModel transaction)
        {
            try
            {
                var result = await _transactionDAL.UpdateTransaction(transaction);

                return new ResultModel { Error = null, Success = true, ResultData = result };

            }
            catch (Exception)
            {
                throw;
            }
        }
       
    }
}
