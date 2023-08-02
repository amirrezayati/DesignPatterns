using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsTutorials.Strategy.Strategies;

namespace DesignPatternsTutorials.Strategy.ConcreteStrategies
{
    public class ConcreteStrategyA : IStrategy
    {
        public void AlgorithmInterface()
        {
            Console.WriteLine("ConcreteStrategyA");
        }
    }
}
