using System;
using System.Collections.Generic;

namespace Sales.Api.Models
{
    public class Sale
    {
        public int Id { get; set; }

        public DateTime TimeStamp { get; set; }

        public string Location { get; set; }

        public string SalesPersonName { get; set; }

        public IList<Product> Products { get; set; }

        public int TotalSalesAmount { get; set; }

        public string Currency { get; set; }

        public string SaleInvoiceNumber { get; set; }

        public Sale()
        {
            Products = new List<Product>();
        }

    }
}