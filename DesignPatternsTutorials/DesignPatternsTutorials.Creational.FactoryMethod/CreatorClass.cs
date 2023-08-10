using DesignPatternsTutorials.Creational.FactoryMethod.ConcreteProduct;
using DesignPatternsTutorials.Creational.FactoryMethod.Product;

namespace DesignPatternsTutorials.Creational.FactoryMethod
{
    public static class CreatorClass
    {
        public static string Creator(this IShapeFactory shapeFactory)
        {
             var factory = shapeFactory.CreateShape();
             return factory.Draw();
        }

        public static string Creator(this ISmsManagerFactory smsManagerFactory, SmsDto dto)
        {
            var factory = smsManagerFactory.CreateManager();
            return factory.Send(dto);
        }
    }
}
