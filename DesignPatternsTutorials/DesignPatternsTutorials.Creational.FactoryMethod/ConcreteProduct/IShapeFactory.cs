﻿using DesignPatternsTutorials.Creational.FactoryMethod.Product;

namespace DesignPatternsTutorials.Creational.FactoryMethod.ConcreteProduct
{
    public interface IShapeFactory
    {
        IShape CreateShape();
    }

    public interface ISmsManagerFactory
    {
        ISmsManager CreateManager();
    }
}
