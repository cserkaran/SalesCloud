using Sales.Api.App_Start;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Sales.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //Enable Cross-Origin Resource Sharing
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);
            config.MessageHandlers.Add(new PreflightRequestsHandler());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
