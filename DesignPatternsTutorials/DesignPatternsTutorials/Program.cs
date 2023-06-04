// See https://aka.ms/new-console-template for more information

using DesignPatternsTutorials.Creational.FactoryMethod;
using DesignPatternsTutorials.Creational.FactoryMethod.ConcreteCreator;
using DesignPatternsTutorials.Creational.FactoryMethod.ConcreteProduct;

#region [- Factory Method -]
Console.WriteLine("Factory Method!");

IShapeFactory rectangle = new RectangleFactory();
Console.WriteLine(rectangle.Creator());

IShapeFactory circle = new CircleFactory();
Console.WriteLine(circle.Creator());

IShapeFactory square = new SquareFactory();
Console.WriteLine(square.Creator()); 

// you can create and draw every shapes
#endregion

Console.ReadKey();