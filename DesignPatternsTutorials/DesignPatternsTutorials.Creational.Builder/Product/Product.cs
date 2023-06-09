namespace DesignPatternsTutorials.Creational.Builder.Product
{
    public class Product
    {
        public Product(Guid id, string name, string brand, double price)
        {
            Id = id;
            Name = name;
            Brand = brand;
            Price = price;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
    }
}
