using Microsoft.AspNet.Identity.EntityFramework;
using Sales.Api.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Sales.Api.Core
{
    public class SalesDbContext : IdentityDbContext
    {
        public SalesDbContext() : base("SalesDbContext")
        {
        }

        public DbSet<Sale> Sales { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //one-to-many 
            modelBuilder.Entity<Product>()
                        .HasRequired<Sale>(s => s.Sale) // Product entity requires Sale 
                        .WithMany(s => s.Products); // Sale entity includes many Product entities


        }
    }
}