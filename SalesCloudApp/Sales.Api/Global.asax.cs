using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Sales.Api.App_Start;
using Sales.Api.Core;
using System.Data.Entity;
using System.Web.Http;

namespace Sales.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configure(FilterConfig.Configure);
            Database.SetInitializer(new SalesDbContextInitializer());
            var formatters = GlobalConfiguration.Configuration.Formatters;
            var jsonFormatter = formatters.JsonFormatter;
            var settings = jsonFormatter.SerializerSettings;
            settings.Formatting = Formatting.Indented;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}
