﻿using System.Web.Http;

namespace Sales.Api.App_Start
{
    public class FilterConfig
    {
        public static void Configure(HttpConfiguration config)
        {
            config.Filters.Add(new AuthorizeAttribute());
        }

    }
}