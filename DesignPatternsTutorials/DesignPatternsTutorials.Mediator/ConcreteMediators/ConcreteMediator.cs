using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsTutorials.Mediator.Coleagues;
using DesignPatternsTutorials.Mediator.ConcreteColleagues;
using DesignPatternsTutorials.Mediator.Mediators;

namespace DesignPatternsTutorials.Mediator.ConcreteMediators
{
    public class ConcreteMediator : AbstractMediator
    {
        public ConcreteMediator(ConcreteColleagueOne colleagueOne, ConcreteColleagueTwo colleagueTwo) 
            : base(colleagueOne, colleagueTwo)
        {
        }

        public override void NotifyChanged(string message, AbstractColleague colleague)
        {
            if (colleague == _colleagueOne)
            {
                _colleagueTwo.Receive(message);
            }
            else
            {
                _colleagueOne.Receive(message);
            }
        }
    }
}
