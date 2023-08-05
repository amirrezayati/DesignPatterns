using DesignPatternsTutorials.Behavioral.ChainOfResponsibility.Models;

namespace DesignPatternsTutorials.Behavioral.ChainOfResponsibility.Handlers;

public abstract class TakeTaxiHandler : IHandler
{
    protected IHandler _successor;

    public abstract ResponseContext HandleRequest(RequestContext request);

    public IHandler SetSuccessor(IHandler successor)
    {
        _successor = successor;
        return _successor;
    }
}