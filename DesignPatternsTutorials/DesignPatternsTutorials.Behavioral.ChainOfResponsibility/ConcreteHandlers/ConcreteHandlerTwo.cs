using DesignPatternsTutorials.Behavioral.ChainOfResponsibility.Handlers;

namespace DesignPatternsTutorials.Behavioral.ChainOfResponsibility.ConcreteHandlers;

public class ConcreteHandlerTwo : AbstractHandler
{
    public override void HandleRequest(int request)
    {
        if (request >= 50)
        {
            Console.WriteLine("ConcreteHandlerTwo Handled");
        }
        else if (_successor != null)
        {
            _successor.HandleRequest(request);
        }
    }
}