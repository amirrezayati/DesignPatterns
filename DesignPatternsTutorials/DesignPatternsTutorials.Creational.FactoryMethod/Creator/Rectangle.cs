using DesignPatternsTutorials.Creational.FactoryMethod.Product;

namespace DesignPatternsTutorials.Creational.FactoryMethod.Creator;

public class Rectangle : IShape
{
    public string Draw()
    {
        return "Draw Rectangle";
    }
}