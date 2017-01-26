using Sales.Api.Dtos;
using System.Globalization;

namespace Sales.Api.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ProductType ProductType { get; set; }

        public int Quantity { get; set; }

        public decimal SaleAmount { get; set; }

        public Sale Sale { get; set; }

        public static explicit operator ProductDto(Product product)
        {
            ProductDto productDto = new ProductDto();

            productDto.Name = product.Name;
            productDto.Quantity = product.Quantity.ToString(CultureInfo.InvariantCulture);
            productDto.Product_Type = product.ProductType.ToString();
            productDto.Sale_Amount = product.SaleAmount.ToString(CultureInfo.InvariantCulture);

            return productDto;
        }
    }
}