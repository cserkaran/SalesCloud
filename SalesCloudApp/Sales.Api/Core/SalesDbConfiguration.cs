using Sales.Api.Models;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Sales.Api.Core
{
    public class SalesDbConfiguration : DbMigrationsConfiguration<SalesDbContext>
    {
        public SalesDbConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(SalesDbContext context)
        {
            int adminRoleId;

            if (!context.Roles.Any())
            {
                adminRoleId = context.Roles.Add(new ApplicationRole("Administrator")).Id;
            }
            else
            {
                adminRoleId = context.Roles.First(c => c.Name == "Administrator").Id;
            }

            if (!context.Users.Any())
            {
                var administrator = context.Users.Add(new ApplicationUser()
                {
                    UserName = "administrator",
                    Email = "admin@somesite.com",
                    EmailConfirmed = true
                });

                administrator.Roles.Add(new ApplicationUserRole { RoleId = adminRoleId });
                var store = new ApplicationUserStore();
                store.SetPasswordHashAsync(administrator, new ApplicationUserManager(store).PasswordHasher.HashPassword("administrator123"));

            }

            context.SaveChanges();
            base.Seed(context);
        }
    }
}