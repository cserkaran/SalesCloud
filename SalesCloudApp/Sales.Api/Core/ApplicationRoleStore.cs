using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Sales.Api.Models;
using System;
using System.Data.Entity;

namespace Sales.Api.Core
{
    public class ApplicationRoleStore
    : RoleStore<ApplicationRole, int, ApplicationUserRole>,
    IQueryableRoleStore<ApplicationRole, int>,
    IRoleStore<ApplicationRole, int>, IDisposable
    {
        public ApplicationRoleStore()
            : base(new IdentityDbContext())
        {
            DisposeContext = true;
        }

        public ApplicationRoleStore(DbContext context)
            : base(context)
        {
        }
    }
}