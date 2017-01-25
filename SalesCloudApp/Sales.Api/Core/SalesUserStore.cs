﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sales.Api.Core
{
    public class SalesUserStore : UserStore<IdentityUser>

    {
        public SalesUserStore() : base(new SalesDbContext())
        {
        }
    }
}