using DesignPatternsTutorials.Mediator.Coleagues;

namespace DesignPatternsTutorials.Mediator.ConcreteColleagues;

public class ConcreteColleagueTwo : AbstractColleague
{
    public override void Send(string message)
    {
        Console.WriteLine("ConcreteColleagueTwo Send :" + message);
        base.Send(message);
    }
    public void Receive(string message)
    {
        Console.WriteLine("ConcreteColleagueTwo Receive :" + message);
    }

}