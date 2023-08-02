using DesignPatternsTutorials.Strategy.Strategies;

namespace DesignPatternsTutorials.Strategy.ConcreteStrategies;

public class ConcreteStrategyC : IStrategy
{
    public void AlgorithmInterface()
    {
        Console.WriteLine("ConcreteStrategyC");
    }
}