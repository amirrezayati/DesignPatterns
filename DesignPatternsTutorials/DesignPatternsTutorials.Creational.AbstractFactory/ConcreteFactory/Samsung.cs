using DesignPatternsTutorials.Creational.AbstractFactory.AbstractFactories;
using DesignPatternsTutorials.Creational.AbstractFactory.AbstractProduct;
using DesignPatternsTutorials.Creational.AbstractFactory.Product;

namespace DesignPatternsTutorials.Creational.AbstractFactory.ConcreteFactory;

public class Samsung : IMobilePhone
{
    public ISmartPhone GetSmartPhone()
    {
        return new SamsungGalaxy();
    }

    public INormalPhone GetNormalPhone()
    {
        return new SamsungGuru();
    }
}