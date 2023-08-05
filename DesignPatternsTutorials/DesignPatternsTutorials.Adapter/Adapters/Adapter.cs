using DesignPatternsTutorials.Adapter.Adaptees;
using DesignPatternsTutorials.Adapter.Targets;

namespace DesignPatternsTutorials.Adapter.Adapters;

public class Adapter : Target
{
    private Adaptee adaptee;
    public Adapter()
    {
        adaptee = new Adaptee();
    }
    public override void Operation()
    {
        adaptee.SpecificOperation();
    }
}