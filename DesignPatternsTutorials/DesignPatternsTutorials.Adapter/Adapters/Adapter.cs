using DesignPatternsTutorials.Structural.Adapter.Targets;
using DesignPatternsTutorials.Structural.Adapter.Adaptees;

namespace DesignPatternsTutorials.Structural.Adapter.Adapters;

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