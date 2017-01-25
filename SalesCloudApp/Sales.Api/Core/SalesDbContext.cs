using Microsoft.AspNet.Identity.EntityFramework;
using Sales.Api.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Sales.Api.Core
{
    public class SalesDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int,
        ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>
    {
        public SalesDbContext() : base("SalesDbContext")
        {
        }

        public DbSet<Sale> Sales { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<ApplicationUser>().ToTable("User");
            modelBuilder.Entity<ApplicationRole>().ToTable("Role");
            modelBuilder.Entity<ApplicationUserRole>().ToTable("UserRole");
            modelBuilder.Entity<ApplicationUserLogin>().ToTable("UserLogin");
            modelBuilder.Entity<ApplicationUserClaim>().ToTable("UserClaim");


            //one-to-many 
            modelBuilder.Entity<Product>()
                        .HasRequired<Sale>(s => s.Sale) // Product entity requires Sale 
                        .WithMany(s => s.Products); // Sale entity includes many Product entities


        }

        public static SalesDbContext Create()
        {
            return new SalesDbContext();
        }
    }
}