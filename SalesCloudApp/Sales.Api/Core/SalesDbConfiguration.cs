using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Sales.Api.Core
{
    public class SalesDbConfiguration : DbMigrationsConfiguration<SalesDbContext>
    {
        public SalesDbConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }
    }
}