using DesignPatternsTutorials.Behavioral.ChainOfResponsibility.Handlers;
using DesignPatternsTutorials.Behavioral.ChainOfResponsibility.Models;

namespace DesignPatternsTutorials.Behavioral.ChainOfResponsibility.ConcreteHandlers;

public class SendOrderToDriver : TakeTaxiHandler
{
    public override ResponseContext HandleRequest(RequestContext request)
    {
        if (_successor != null)
        {
            Console.WriteLine("Sent Order To Driver");
            return _successor.HandleRequest(request);
        }

        return new ResponseContext()
        {
            IsSuccess = false,
            Message = "NotSuccess"
        };
    }
}