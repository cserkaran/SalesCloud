using Sales.Api.Dtos;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Sales.Api.Models
{
    public class Sale
    {
        public int Id { get; set; }

        public DateTime TimeStamp { get; set; }

        public string Location { get; set; }

        public string SalesPersonName { get; set; }

        public IList<Product> Products { get; set; }

        public decimal TotalSalesAmount { get; set; }

        public string Currency { get; set; }

        public string SaleInvoiceNumber { get; set; }

        public Sale()
        {
            Products = new List<Product>();
        }

        public static explicit operator SaleDto(Sale sale)
        {
            SaleDto saleDto = new SaleDto();

            saleDto.TimeStamp = sale.TimeStamp;
            saleDto.Location_Name = sale.Location;
            saleDto.Sales_Person_Name = sale.SalesPersonName;

            foreach (var product in sale.Products)
            {
                saleDto.Products.Add((ProductDto)product);
            }

            saleDto.Total_Sale_Amount = sale.TotalSalesAmount.ToString(CultureInfo.InvariantCulture);
            saleDto.Currency = sale.Currency;
            saleDto.Sale_Invoice_Number = sale.SaleInvoiceNumber;

            return saleDto;
        }

    }
}