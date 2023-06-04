using DesignPatternsTutorials.Creational.AbstractFactory.AbstractFactories;
using DesignPatternsTutorials.Creational.AbstractFactory.AbstractProduct;
using DesignPatternsTutorials.Creational.AbstractFactory.Product;

namespace DesignPatternsTutorials.Creational.AbstractFactory.ConcreteFactory
{
    public class Nokia : IMobilePhone
    {
        public ISmartPhone GetSmartPhone()
        {
            return new NokiaPixel();
        }

        public INormalPhone GetNormalPhone()
        {
            return new Nokia1600();
        }
    }
}
