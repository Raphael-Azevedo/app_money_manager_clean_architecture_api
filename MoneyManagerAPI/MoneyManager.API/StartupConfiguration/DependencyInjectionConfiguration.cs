using MoneyManager.Core.Managers.Transaction;
using MoneyManager.Core.Providers.Transaction;
using MoneyManager.Infrastructure.Transaction;

namespace MoneyManager.API.StartupConfiguration
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            #region Managers
            services.AddTransient<ITransactionManager, TransactionManager>();
            #endregion

            #region Providers
            services.AddTransient<ITransactionDAL, TransactionDAL>();
            #endregion
        }

    }
}
