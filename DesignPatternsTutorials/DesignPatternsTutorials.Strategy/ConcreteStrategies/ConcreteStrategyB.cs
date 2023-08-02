using DesignPatternsTutorials.Strategy.Strategies;

namespace DesignPatternsTutorials.Strategy.ConcreteStrategies;

public class ConcreteStrategyB : IStrategy
{
    public void AlgorithmInterface()
    {
        Console.WriteLine("ConcreteStrategyB");
    }
}