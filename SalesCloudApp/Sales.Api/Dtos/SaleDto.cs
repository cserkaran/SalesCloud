using Sales.Api.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Sales.Api.Dtos
{
    public class SaleDto  
    {
        public DateTime TimeStamp { get; set; }

        public string Location_Name { get; set; }

        public string Sales_Person_Name { get; set; }

        public IList<ProductDto> Products { get; set; }

        public string Total_Sale_Amount { get; set; }

        public string Currency { get; set; }

        public string Sale_Invoice_Number { get; set; }

        public SaleDto()
        {
            Products = new List<ProductDto>();
        }

        public static explicit operator Sale(SaleDto saleDto)
        {
            Sale sale = new Sale();

            sale.TimeStamp = saleDto.TimeStamp;
            sale.Location = saleDto.Location_Name;
            sale.SalesPersonName = saleDto.Sales_Person_Name;

            foreach(var productDto in saleDto.Products)
            {
                var product = (Product)productDto;
                product.Sale = sale;
                sale.Products.Add(product);
            }

            sale.TotalSalesAmount = decimal.Parse(saleDto.Total_Sale_Amount,CultureInfo.InvariantCulture);
            sale.Currency = saleDto.Currency;
            sale.SaleInvoiceNumber = saleDto.Sale_Invoice_Number;

            return sale;
        }
    }
}