using DesignPatternsTutorials.Creational.FactoryMethod.Product;

namespace DesignPatternsTutorials.Creational.FactoryMethod.Creator;

public class KavehNegar : ISmsManager
{
    public void Send(SmsDto dto)
    {
        Console.WriteLine("KavehNegar.Send");
    }

    public List<SmsDto> GetList()
    {
        return new List<SmsDto>();
    }
}