namespace DesignPatternsTutorials.Structural.Decorator.AbstractDecorator;

public abstract class CarAccessoriesDecorator : ICar
{
    private readonly ICar _car;

    protected CarAccessoriesDecorator(ICar car)
    {
        _car = car;
    }
    public virtual string GetDescription()
    {
        return _car.GetDescription();
    }

    public virtual double GetCost()
    {
        return _car.GetCost();
    }
}