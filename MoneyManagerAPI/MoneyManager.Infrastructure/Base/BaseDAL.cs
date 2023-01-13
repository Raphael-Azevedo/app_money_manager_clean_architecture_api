using Microsoft.Extensions.Configuration;
using System.Xml.Linq;

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
        public string GetAzureBlobStorageConnectionString(string connection = "UserBlobStorage")
        {
            string azureBlobStorageString = string.Empty;

            try
            {
                azureBlobStorageString = "";
                    /* _configuration.GetSection("ConnectionBlobDevelopment").GetValue(typeof(string), "UserBlobStorage").ToString()!;*/

                return azureBlobStorageString;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
