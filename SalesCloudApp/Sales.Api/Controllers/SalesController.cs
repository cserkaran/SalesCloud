using Sales.Api.Core;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Web.Http;

namespace Sales.Api.Controllers
{
    public class SalesController : ApiController
    {
        [HttpGet]
        public async Task<IHttpActionResult> GetSales()
        {
            using (var context = new SalesDbContext())
            {
                return Ok(await context.Sales.Include("Products").ToListAsync());
            }
        }

    }
}
