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
    }
}