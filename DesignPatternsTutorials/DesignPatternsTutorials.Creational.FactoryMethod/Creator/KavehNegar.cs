using DesignPatternsTutorials.Creational.FactoryMethod.Product;

namespace DesignPatternsTutorials.Creational.FactoryMethod.Creator;

public class KavehNegar : ISmsManager
{
    public string Send(SmsDto dto)
    {
        return "KavehNegar.Send";
    }

    public List<SmsDto> GetList()
    {
        return new List<SmsDto>();
    }
}