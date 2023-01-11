using Microsoft.Extensions.Configuration;

namespace MoneyManager.Infrastructure.Base
{
    public class BaseDAL
    {
        #region Properties
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _environment;

        public BaseDAL(IWebHostEnvironment environment, IConfiguration configuration)
        {
            _environment = environment;
            _configuration = configuration;
        }
        #endregion

        #region Get Connection
        public string GetConnectionString(string connection = "UserSaiyan")
        {
            string connectionString = string.Empty;

            try
            {
                if (_environment.EnvironmentName.Equals("Development"))
                    connectionString = _configuration.GetSection("ConnectionStringDevelopment").GetValue(typeof(String), connection).ToString()!;
                else
                    connectionString = Environment.GetEnvironmentVariable("FarmFitAPIDb", EnvironmentVariableTarget.Machine)!;

                return connectionString;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
