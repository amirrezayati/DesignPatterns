using DesignPatternsTutorials.Creational.AbstractFactory.AbstractProduct;

namespace DesignPatternsTutorials.Creational.AbstractFactory.Product
{
    public class NokiaPixel : ISmartPhone
    {
        public string GetModelDetails()
        {
            return "Model: Nokia Pixel\nRam :6GB\nMemory: 8MP";
        }
    }
}
