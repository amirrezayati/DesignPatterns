using DesignPatternsTutorials.Creational.FactoryMethod.Product;

namespace DesignPatternsTutorials.Creational.FactoryMethod.Creator;

public class Twilio : ISmsManager
{
    public string Send(SmsDto dto)
    {
        return "Twilio.Send";
    }

    public List<SmsDto> GetList()
    {
        return new List<SmsDto>();
    }
}