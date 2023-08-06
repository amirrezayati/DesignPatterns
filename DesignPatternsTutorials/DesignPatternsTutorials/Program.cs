// See https://aka.ms/new-console-template for more information

using DesignPatternsTutorials.Structural.Adapter.Targets;
using DesignPatternsTutorials.Behavioral.ChainOfResponsibility.ConcreteHandlers;
using DesignPatternsTutorials.Behavioral.ChainOfResponsibility.Handlers;
using DesignPatternsTutorials.Behavioral.ChainOfResponsibility.Models;
using DesignPatternsTutorials.Behavioral.TemplateMethod;
using DesignPatternsTutorials.Behavioral.TemplateMethod.ConcreteClasses;
using DesignPatternsTutorials.Creational.AbstractFactory.AbstractFactories;
using DesignPatternsTutorials.Creational.AbstractFactory.Client;
using DesignPatternsTutorials.Creational.AbstractFactory.ConcreteFactory;
using DesignPatternsTutorials.Creational.Builder.ProductBuilder;
using DesignPatternsTutorials.Creational.FactoryMethod;
using DesignPatternsTutorials.Creational.FactoryMethod.ConcreteCreator;
using DesignPatternsTutorials.Creational.FactoryMethod.ConcreteProduct;
using DesignPatternsTutorials.Creational.Singleton;
using DesignPatternsTutorials.Mediator.ConcreteColleagues;
using DesignPatternsTutorials.Mediator.ConcreteMediators;
using DesignPatternsTutorials.Strategy.ConcreteStrategies;
using DesignPatternsTutorials.Strategy.Contexts;
using DesignPatternsTutorials.Strategy.Entities;
using DesignPatternsTutorials.Structural.Adapter.Adapters;
using DesignPatternsTutorials.Structural.Decorator;
using DesignPatternsTutorials.Structural.Decorator.AbstractDecorator;
using DesignPatternsTutorials.Structural.Decorator.ConcreteDecorator;

#region [- Factory Method -]
Console.WriteLine("Factory Method!");
Console.WriteLine("----------------------------------------------------------");
IShapeFactory rectangle = new RectangleFactory();
Console.WriteLine(rectangle.Creator());

IShapeFactory circle = new CircleFactory();
Console.WriteLine(circle.Creator());

IShapeFactory square = new SquareFactory();
Console.WriteLine(square.Creator());

ISmsManagerFactory smsKavehnegar = new KavehNegarFactory();
Console.WriteLine(smsKavehnegar.CreateManager());

ISmsManagerFactory smsTwilio = new TwilioFactory();
Console.WriteLine(smsTwilio.CreateManager());

// you can create and draw every shapes
#endregion

#region [- Abstract Factory -]
Console.WriteLine(Environment.NewLine);
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
Console.WriteLine(Environment.NewLine);
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
Console.WriteLine($"{product3.Name}     {product3.Brand}     {product3.Price}");
#endregion

#region [- Singleton -]
Console.WriteLine(Environment.NewLine);
Console.WriteLine("Singleton!");
Console.WriteLine("----------------------------------------------------------");

// implement LoadBalancer 
LoadBalancer loadBalancer1 = LoadBalancer.GetLoadBalancer();
LoadBalancer loadBalancer2 = LoadBalancer.GetLoadBalancer();
LoadBalancer loadBalancer3 = LoadBalancer.GetLoadBalancer();
LoadBalancer loadBalancer4 = LoadBalancer.GetLoadBalancer();

if (loadBalancer1 == loadBalancer2 && loadBalancer2 == loadBalancer3 && loadBalancer3 == loadBalancer4)
    Console.WriteLine("Servers has Same Instance");

LoadBalancer loadBalancer = LoadBalancer.GetLoadBalancer();
for (int i = 0; i < 15; i++)
{
    Console.WriteLine("Request to: {0}", loadBalancer.NextServer.Name);
}

#endregion

#region [- Decorator -]
Console.WriteLine(Environment.NewLine);
Console.WriteLine("Decorator!");
Console.WriteLine("----------------------------------------------------------");

ICar economyCar = new EconomyCar();
var economyCarDescription = economyCar.GetDescription();
Console.WriteLine($"basicAccessoryCostEconomyCar : {economyCarDescription}");
var basicAccessoryEconomyCar = new BasicAccessories(economyCar);
Console.WriteLine($"basicAccessoryDescriptionEconomyCar : {basicAccessoryEconomyCar.GetDescription()}");
Console.WriteLine($"basicAccessoryCostEconomyCar : {basicAccessoryEconomyCar.GetCost()}");
basicAccessoryEconomyCar.GetDescription();

ICar objCar = new EconomyCar();
CarAccessoriesDecorator objAccessoriesDecorator = new BasicAccessories(objCar);
objAccessoriesDecorator = new AdvancedAccessories(objAccessoriesDecorator);

Console.Write(objAccessoriesDecorator.GetDescription());
Console.WriteLine();
Console.Write(objAccessoriesDecorator.GetCost());
#endregion

#region [- Mediator -]
Console.WriteLine(Environment.NewLine);
Console.WriteLine("Mediator!");
Console.WriteLine("----------------------------------------------------------");

// Define ConcreteColleagues
ConcreteColleagueOne colleagueOne = new();
ConcreteColleagueTwo colleagueTwo = new();

// Define ConcreteMediator and pass Colleagues to params
ConcreteMediator concreteMediator = new(colleagueOne, colleagueTwo);

//Set Colleagues
colleagueOne.SetColleague(concreteMediator);
colleagueTwo.SetColleague(concreteMediator);

//Send Message
colleagueOne.Send("Salam Khubi?");
colleagueTwo.Send("Salam Merc To Khubi?");
#endregion

#region [- Strategy -]

Console.WriteLine(Environment.NewLine);
Console.WriteLine("Strategy!");
Console.WriteLine("----------------------------------------------------------");

//Create Instance from Context
Context context;
//Pass Concretes to Context insteadof IStrategy
context = new Context(new ConcreteStrategyA());
//Call Context Methods
context.ContextInterface();

context = new Context(new ConcreteStrategyB());
context.ContextInterface();

context = new Context(new ConcreteStrategyC());
context.ContextInterface();
// new example for Array.Sort()

var products = new UserEntity[]
{
    new() { Id = 1, Age = 45, Name = "A" },
    new() { Id = 2, Age = 32, Name = "B" },
    new() { Id = 4, Age = 60, Name = "F" },
    new() { Id = 5, Age = 50, Name = "C" },
    new() { Id = 3, Age = 10, Name = "D" },
};

Array.Sort(products, new UserById());
foreach (var product in products)
{
    product.Display();
}

Array.Sort(products, new UserByAge());
foreach (var product in products)
{
    product.Display();
}

#endregion

#region [- TemplateMethod -]
Console.WriteLine(Environment.NewLine);
Console.WriteLine("TemplateMethod!");
Console.WriteLine("----------------------------------------------------------");
Client.Run(new ConcreteClassOne());
#endregion

#region [- ChainOfResponsibility -]
Console.WriteLine(Environment.NewLine);
Console.WriteLine("ChainOfResponsibility!");
Console.WriteLine("----------------------------------------------------------");
//Define Concrete Handlers
AbstractHandler handlerOne = new ConcreteHandler();
AbstractHandler handlerTwo = new ConcreteHandlerTwo();
//Set Successor for Next Step
handlerOne.SetSuccessor(handlerTwo);

//Handle Request
handlerOne.HandleRequest(20);
handlerOne.HandleRequest(1000);

CreateOrder createOrder = new CreateOrder();
SendOrderToDriver sendOrder = new SendOrderToDriver();
ActiveUser activeUser = new ActiveUser();

activeUser.SetSuccessor(createOrder).SetSuccessor(sendOrder);


activeUser.HandleRequest(new RequestContext()
{
    Lat = 10.23,
    Lng = 450.454,
    UserId = 1
});
#endregion

#region [- Adapter -]
Console.WriteLine(Environment.NewLine);
Console.WriteLine("Adapter!");
Console.WriteLine("----------------------------------------------------------");
Target target = new Adapter();
target.Operation(); 
#endregion



Console.ReadKey();