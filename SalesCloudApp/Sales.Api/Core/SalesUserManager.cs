using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sales.Api.Core
{
    public class SalesUserManager : UserManager<IdentityUser>
    {
        public SalesUserManager() : base(new SalesUserStore())
        {
        }
    }
}