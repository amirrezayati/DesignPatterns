using DesignPatternsTutorials.Creational.FactoryMethod.Product;

namespace DesignPatternsTutorials.Creational.FactoryMethod.Creator;

public class Twilio : ISmsManager
{
    public void Send(SmsDto dto)
    {
        Console.WriteLine("Twilio.Send");
    }

    public List<SmsDto> GetList()
    {
        return new List<SmsDto>();
    }
}