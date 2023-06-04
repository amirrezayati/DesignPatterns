using DesignPatternsTutorials.Creational.AbstractFactory.AbstractFactories;
using DesignPatternsTutorials.Creational.AbstractFactory.AbstractProduct;
using DesignPatternsTutorials.Creational.AbstractFactory.ConcreteFactory;

namespace DesignPatternsTutorials.Creational.AbstractFactory.Client;

public class MobileClient
{
    private ISmartPhone smartPhone;
    private INormalPhone normalPhone;
    public MobileClient(IMobilePhone mobilePhone)
    {
        smartPhone = mobilePhone.GetSmartPhone();
        normalPhone = mobilePhone.GetNormalPhone();
    }

    public string GetSmartPhoneDetails()
    {
        return smartPhone.GetModelDetails();
    }

    public string GetNormalPhoneDetails()
    {
        return normalPhone.GetModelDetails();
    }
}