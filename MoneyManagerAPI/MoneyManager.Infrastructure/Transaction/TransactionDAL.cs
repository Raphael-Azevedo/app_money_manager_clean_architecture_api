using Dapper;
using Microsoft.Data.SqlClient;
using MoneyManager.Core.Models.Transaction;
using MoneyManager.Core.Providers.Transaction;
using MoneyManager.Infrastructure.Base;
using System.Text;

namespace MoneyManager.Infrastructure.Transaction
{
    public class TransactionDAL : BaseDAL, ITransactionDAL
    {
        public TransactionDAL(IWebHostEnvironment environment, IConfiguration configuration) : base(environment, configuration)
        {
        }

        /// <summary>
        /// GetMonthTransaction - Return the Transaction List filtered by actual month
        /// App =>  - method => 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<TransactionBaselineModel>> GetMonthTransaction()
        {
            StringBuilder sqlBuilder = new StringBuilder();

            // Construir a consulta SQL
            sqlBuilder.AppendLine("SELECT id, title, description, value, date, category FROM Transactions");
            sqlBuilder.AppendLine("WHERE MONTH(date) = MONTH(CURRENT_TIMESTAMP)");

            string sql = sqlBuilder.ToString();

            // Executar a consulta SQL
            using (var connection = new SqlConnection(GetConnectionString()))
            {
                return await connection.QueryAsync<TransactionBaselineModel>(sql);
            }
        }
    }
}
