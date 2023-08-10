namespace DesignPatternsTutorials.Creational.Builder.Product
{
    public class ProductBuilder
    {
        public string Name { get; set; }
        public string PartOne { get; set; }
        public string PartTwo { get; set; }

        public void Display()
        {
            Console.WriteLine($"Product Name {Name} \n" +
                              $"Part One {PartOne} \n" +
                              $"Part Two {PartTwo}");
        }
    }
}
