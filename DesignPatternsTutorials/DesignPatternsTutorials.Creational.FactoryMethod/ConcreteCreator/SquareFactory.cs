using DesignPatternsTutorials.Creational.FactoryMethod.ConcreteProduct;
using DesignPatternsTutorials.Creational.FactoryMethod.Creator;
using DesignPatternsTutorials.Creational.FactoryMethod.Product;

namespace DesignPatternsTutorials.Creational.FactoryMethod.ConcreteCreator
{
    public class SquareFactory : IShapeFactory
    {
        public IShape CreateShape()
        {
            return new Square();
        }
    }
}
