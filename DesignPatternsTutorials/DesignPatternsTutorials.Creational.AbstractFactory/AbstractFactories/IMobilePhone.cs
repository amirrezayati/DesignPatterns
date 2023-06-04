using DesignPatternsTutorials.Creational.AbstractFactory.AbstractProduct;

namespace DesignPatternsTutorials.Creational.AbstractFactory.AbstractFactories;

public interface IMobilePhone
{
    public ISmartPhone GetSmartPhone();
    public INormalPhone GetNormalPhone();
}