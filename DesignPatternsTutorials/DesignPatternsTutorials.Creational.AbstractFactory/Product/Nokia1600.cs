using DesignPatternsTutorials.Creational.AbstractFactory.AbstractProduct;

namespace DesignPatternsTutorials.Creational.AbstractFactory.Product;

public class Nokia1600 : INormalPhone
{
    public string GetModelDetails()
    {
        return "Model: Nokia 1600\nRam :2GB\nMemory: 4MP";
    }
}