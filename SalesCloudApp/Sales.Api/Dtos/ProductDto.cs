using Sales.Api.Models;
using System;

namespace Sales.Api.Dtos
{
    public class ProductDto
    {
        public string Name { get; set; }

        public string Quantity { get; set; }

        public string Product_Type { get; set; }

        public string Sale_Amount { get; set; }

        public static explicit operator Product(ProductDto productDto)
        {
            Product product = new Product();

            product.Name = productDto.Name;
            product.Quantity = int.Parse(productDto.Quantity);
            product.ProductType = (ProductType)Enum.Parse(typeof(ProductType),productDto.Product_Type);
            product.SaleAmount = decimal.Parse(productDto.Sale_Amount);

            return product;
        }
    }
}