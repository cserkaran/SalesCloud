using System.Data.Entity;

namespace Sales.Api.Core
{
    public class SalesDbContextInitializer :
        MigrateDatabaseToLatestVersion<SalesDbContext,SalesDbConfiguration>
    {
    }
}