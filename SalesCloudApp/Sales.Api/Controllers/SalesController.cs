using Sales.Api.Core;
using Sales.Api.Dtos;
using Sales.Api.ModelBinders;
using Sales.Api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace Sales.Api.Controllers
{
    [RoutePrefix("api/sales")]
    public class SalesController : ApiController
    {
        [HttpGet]
        [Route("all")]
        public async Task<IHttpActionResult> GetSales()
        {
            using (var context = new SalesDbContext())
            {
                var sales = await context.Sales.Include("Products").ToListAsync();

                IList<SaleDto> saleDto = new List<SaleDto>();
                foreach(var sale in sales)
                {
                    saleDto.Add((SaleDto)sale);
                }

                return Ok(saleDto);
            }
        }

        [HttpGet]
        [Route("{range}")]
        public async Task<IHttpActionResult> GetSalesInRange([ModelBinder(typeof(DateRangeModelBinder))]DateRange range)
        {
            using (var context = new SalesDbContext())
            {
                var sales = await context.Sales.Include("Products").ToListAsync();

                IList<SaleDto> saleDto = new List<SaleDto>();
                foreach (var sale in sales)
                {
                    //sale within given range..
                    if (range.Includes(sale.TimeStamp))
                    {
                        saleDto.Add((SaleDto)sale);
                    }
                }

                return Ok(saleDto);
            }
        }

        [HttpPost]
        public void PostSale([FromBody] SaleDto saleDto)
        {
            Sale sale = (Sale)saleDto;
            using (var context = new SalesDbContext())
            {
                context.Sales.Add(sale);
                context.SaveChanges();
            }
        }

    }
}
