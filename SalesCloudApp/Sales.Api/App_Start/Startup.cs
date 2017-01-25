using Microsoft.Owin;
using Owin;
using Sales.Api.App_Start;

[assembly: OwinStartup(typeof(Startup))]
namespace Sales.Api.App_Start
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureOAuth(app);
        }
    }
}