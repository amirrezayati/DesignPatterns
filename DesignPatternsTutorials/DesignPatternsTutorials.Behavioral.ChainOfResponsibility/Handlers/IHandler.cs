using DesignPatternsTutorials.Behavioral.ChainOfResponsibility.Models;

namespace DesignPatternsTutorials.Behavioral.ChainOfResponsibility.Handlers;

public interface IHandler
{

    public IHandler SetSuccessor(IHandler successor);

    public ResponseContext HandleRequest(RequestContext request);
}