namespace DesignPatternsTutorials.Creational.FactoryMethod.Product;

public interface ISmsManager
{
    public string Send(SmsDto dto);
    List<SmsDto> GetList();
}

public class SmsDto
{
    public string Reciver { get; set; }
    public string Sender { get; set; }
    public string Message { get; set; }
}