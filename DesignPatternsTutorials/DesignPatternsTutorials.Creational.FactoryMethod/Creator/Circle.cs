using DesignPatternsTutorials.Creational.FactoryMethod.Product;

namespace DesignPatternsTutorials.Creational.FactoryMethod.Creator;

public class Circle : IShape
{
    public string Draw()
    {
        return "Draw Circle";
    }
}