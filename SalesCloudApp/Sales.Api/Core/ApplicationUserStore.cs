using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Sales.Api.Models;
using System;
using System.Data.Entity;

namespace Sales.Api.Core
{
    public class ApplicationUserStore : UserStore<ApplicationUser, ApplicationRole, int,
            ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>, IUserStore<ApplicationUser, int>, IDisposable

    {
        public ApplicationUserStore()
            : this(new IdentityDbContext())
        {
            DisposeContext = true;
        }

        public ApplicationUserStore(DbContext context)
            : base(context)
        {
        }
    }
}