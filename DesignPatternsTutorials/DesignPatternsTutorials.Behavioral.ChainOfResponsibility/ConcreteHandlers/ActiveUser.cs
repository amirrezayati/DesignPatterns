using DesignPatternsTutorials.Behavioral.ChainOfResponsibility.Handlers;
using DesignPatternsTutorials.Behavioral.ChainOfResponsibility.Models;

namespace DesignPatternsTutorials.Behavioral.ChainOfResponsibility.ConcreteHandlers;

public class ActiveUser : TakeTaxiHandler
{
    /// <summary>
    /// HandleRequest
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public override ResponseContext HandleRequest(RequestContext request)
    {
        if (_successor != null && request.UserId is 1)
        {
            Console.WriteLine("User Activate");
            return _successor.HandleRequest(request);
        }

        return new ResponseContext()
        {
            IsSuccess = false,
            Message = "NotSuccess"
        };
    }
}