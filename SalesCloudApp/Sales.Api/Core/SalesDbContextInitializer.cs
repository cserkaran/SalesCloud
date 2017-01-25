using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sales.Api.Core
{
    public class SalesDbContextInitializer :
        MigrateDatabaseToLatestVersion<SalesDbContext,SalesDbConfiguration>
    {
    }
}