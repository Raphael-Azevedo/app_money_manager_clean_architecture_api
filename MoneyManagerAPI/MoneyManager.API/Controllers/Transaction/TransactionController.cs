using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoneyManager.Core.Managers.Transaction;
using MoneyManager.Core.Models.Result;
using MoneyManager.Core.Models.System;

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
    }
}
