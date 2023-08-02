using DesignPatternsTutorials.Structural.Decorator.AbstractDecorator;

namespace DesignPatternsTutorials.Structural.Decorator.ConcreteDecorator;

public class BasicAccessories : CarAccessoriesDecorator
{
    public BasicAccessories(ICar car) : base(car)
    {
    }

    public override string GetDescription()
    {
        return base.GetDescription() + "Basic Accessory Description";
    }

    public override double GetCost()
    {
        return base.GetCost() + 150;
    }
}