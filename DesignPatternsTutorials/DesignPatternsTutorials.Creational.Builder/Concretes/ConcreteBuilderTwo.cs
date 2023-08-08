using DesignPatternsTutorials.Creational.Builder.Builder;

namespace DesignPatternsTutorials.Creational.Builder.Concretes;

public class ConcreteBuilderTwo : AbstractBuilder
{
    public override void BuildPartOne()
    {
        ProductBuilder.PartOne = "ConcreteBuilderTwo Part One";
    }

    public override void BuildPartTwo()
    {
        ProductBuilder.PartTwo = "ConcreteBuilderTwo Part Two";
    }

    public override Product.ProductBuilder GetResult()
    {
        ProductBuilder.Name = nameof(ConcreteBuilderTwo);
        Console.WriteLine(nameof(ConcreteBuilderTwo));
        return base.GetResult();
    }
}