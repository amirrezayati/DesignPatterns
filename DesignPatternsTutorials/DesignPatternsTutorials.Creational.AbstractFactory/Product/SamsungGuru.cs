using DesignPatternsTutorials.Creational.AbstractFactory.AbstractProduct;

namespace DesignPatternsTutorials.Creational.AbstractFactory.Product;

public class SamsungGuru : INormalPhone
{
    public string GetModelDetails()
    {
        return "Model: Samsung Guru\nRam :2GB\nMemory: 4MP";
    }
}