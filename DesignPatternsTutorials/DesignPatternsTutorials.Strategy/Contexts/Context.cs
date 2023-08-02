using DesignPatternsTutorials.Strategy.Strategies;

namespace DesignPatternsTutorials.Strategy.Contexts
{
    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ContextInterface()
        {
            _strategy.AlgorithmInterface();
        }
    }
}
