using DesignPatternsTutorials.Creational.AbstractFactory.AbstractProduct;

namespace DesignPatternsTutorials.Creational.AbstractFactory.Product;

public class SamsungGalaxy : ISmartPhone
{
    public string GetModelDetails()
    {
        return "Model: Samsung Galaxy\nRam :8GB\nMemory: 8MP";
    }
}