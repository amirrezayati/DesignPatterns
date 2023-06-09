using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTutorials.Creational.Builder.ProductBuilder
{
    public class ProductBuilder : Builder.Builder<Product.Product>
    {
        private Guid Id { get; set; }
        private string Name { get; set; }
        private string Brand { get; set; }
        private double Price { get; set; }

        public ProductBuilder WithName(string name)
        {
            Name = name;
            return this;
        }
        public ProductBuilder WithBrand(string brand)
        {
            Brand = brand;
            return this;
        }
        public ProductBuilder WithPrice(double price)
        {
            Price = price;
            return this;
        }
        public override Product.Product Build()
        {
            return new Product.Product(Id, Name, Brand, Price);
        }
    }
}
