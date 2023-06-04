using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsTutorials.Creational.FactoryMethod.ConcreteProduct;

namespace DesignPatternsTutorials.Creational.FactoryMethod
{
    public static class CreatorClass
    {
        public static string Creator(this IShapeFactory shapeFactory)
        {
             var factory = shapeFactory.CreateShape();
             return factory.Draw();
        }
    }
}
