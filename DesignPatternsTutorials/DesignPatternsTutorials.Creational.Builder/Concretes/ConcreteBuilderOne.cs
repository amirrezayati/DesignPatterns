using DesignPatternsTutorials.Creational.Builder.Builder;

namespace DesignPatternsTutorials.Creational.Builder.Concretes
{
    public class ConcreteBuilderOne : AbstractBuilder
    {
        public override void BuildPartOne()
        {
            ProductBuilder.PartOne = "ConcreteBuilderOne Part One";
        }

        public override void BuildPartTwo()
        {
            ProductBuilder.PartTwo = "ConcreteBuilderOne Part Two";
        }

        public override Product.ProductBuilder GetResult()
        {
            ProductBuilder.Name = nameof(ConcreteBuilderOne);
            Console.WriteLine(nameof(ConcreteBuilderOne));
            return base.GetResult();
        }
    }
}
