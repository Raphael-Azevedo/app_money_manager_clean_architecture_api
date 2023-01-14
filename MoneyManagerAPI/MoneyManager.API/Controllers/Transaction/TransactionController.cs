using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoneyManager.Core.Managers.Transaction;
using MoneyManager.Core.Models.Result;
using MoneyManager.Core.Models.System;
using MoneyManager.Core.Models.Transaction;

namespace MoneyManager.API.Controllers.Transaction
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionManager _transactionManager;

        public TransactionController(ITransactionManager transactionManager)
        {
            _transactionManager = transactionManager;
        }

        #region Get Month Transactions
        /// <summary>
        /// Get Month Transactions - Home Screen
        /// </summary>
        /// <returns></returns>
         [HttpGet]
        [Route("GetMonthTransaction")]
        public async Task<IActionResult> GetMonthTransaction()
        {
            try
            {
                return Ok(await _transactionManager.GetMonthTransaction());
            }
            catch (Exception )
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ResultModel { Error = new ErrorModel { ErrorCode = "5", ErrorMessage = "Internal Server Error" } });
            }
        }
        #endregion
        #region Get All Transactions
        /// <summary>
        /// Get All Transactions - Home Screen
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAllTransactions")]
        public async Task<IActionResult> GetAllTransactions()
        {
            try
            {
                return Ok(await _transactionManager.GetAllTransaction());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ResultModel { Error = new ErrorModel { ErrorCode = "5", ErrorMessage = "Internal Server Error" } });
            }
        }
        #endregion
        #region Add Transaction
        /// <summary>
        /// Add Transactions - Home Screen
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("AddTransaction")]
        public async Task<IActionResult> AddTransaction(TransactionBaselineModel transaction)
        {
            try
            {
                return Ok(await _transactionManager.AddTransaction(transaction));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ResultModel { Error = new ErrorModel { ErrorCode = "5", ErrorMessage = "Internal Server Error" } });
            }
        }
        #endregion
        #region Update Transaction
        /// <summary>
        /// Update Transactions - Home Screen
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdateTransaction")]
        public async Task<IActionResult> UpdateTransaction(TransactionBaselineModel transaction)
        {
            try
            {
                return Ok(await _transactionManager.UpdateTransaction(transaction));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ResultModel { Error = new ErrorModel { ErrorCode = "5", ErrorMessage = "Internal Server Error" } });
            }
        }
        #endregion
        #region Delete Transactions
        /// <summary>
        /// Delete Transactions - Home Screen
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("DeleteTransaction")]
        public async Task<IActionResult> DeleteTransaction(TransactionBaselineModel transaction)
        {
            try
            {
                return Ok(await _transactionManager.DeleteTransaction(transaction));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ResultModel { Error = new ErrorModel { ErrorCode = "5", ErrorMessage = "Internal Server Error" } });
            }
        }
        #endregion
    }
}
