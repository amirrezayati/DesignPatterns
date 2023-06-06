﻿// See https://aka.ms/new-console-template for more information

using DesignPatternsTutorials.Creational.AbstractFactory.AbstractFactories;
using DesignPatternsTutorials.Creational.AbstractFactory.Client;
using DesignPatternsTutorials.Creational.AbstractFactory.ConcreteFactory;
using DesignPatternsTutorials.Creational.Builder.ProductBuilder;
using DesignPatternsTutorials.Creational.FactoryMethod;
using DesignPatternsTutorials.Creational.FactoryMethod.ConcreteCreator;
using DesignPatternsTutorials.Creational.FactoryMethod.ConcreteProduct;

#region [- Factory Method -]
Console.WriteLine("Factory Method!");
Console.WriteLine("----------------------------------------------------------");
IShapeFactory rectangle = new RectangleFactory();
Console.WriteLine(rectangle.Creator());

IShapeFactory circle = new CircleFactory();
Console.WriteLine(circle.Creator());

IShapeFactory square = new SquareFactory();
Console.WriteLine(square.Creator());

// you can create and draw every shapes
#endregion

#region [- Abstract Factory -]
Console.WriteLine("AbstractFactory!");
Console.WriteLine("----------------------------------------------------------");

IMobilePhone nokiaMobilePhone = new Nokia();
MobileClient nokiaClient = new MobileClient(nokiaMobilePhone);

Console.WriteLine("***************Nokia***************");
Console.WriteLine(nokiaClient.GetSmartPhoneDetails());
Console.WriteLine(nokiaClient.GetNormalPhoneDetails());

IMobilePhone samsungMobilePhone = new Samsung();
MobileClient samsungClient = new MobileClient(samsungMobilePhone);

Console.WriteLine("***************Samsung***************");
Console.WriteLine(samsungClient.GetSmartPhoneDetails());
Console.WriteLine(samsungClient.GetNormalPhoneDetails());
// you can create and draw every shapes
#endregion

#region [- Builder -]
Console.WriteLine("Builder!");
Console.WriteLine("----------------------------------------------------------");

var productBuilder = new ProductBuilder();
var product1 = productBuilder.Build();
var product2 = productBuilder.WithName("Amir").Build();
var product3 = productBuilder
    .WithName("Laptop")
    .WithBrand("Asus")
    .WithPrice(20000)
    .Build(); 
#endregion

Console.WriteLine($"{product3.Name}     {product3.Brand}     {product3.Price}");
Console.ReadKey();