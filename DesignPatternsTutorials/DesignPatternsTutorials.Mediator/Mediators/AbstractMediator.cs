using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsTutorials.Mediator.Coleagues;
using DesignPatternsTutorials.Mediator.ConcreteColleagues;

namespace DesignPatternsTutorials.Mediator.Mediators
{
    public abstract class AbstractMediator
    {
        protected ConcreteColleagueOne _colleagueOne;
        protected ConcreteColleagueTwo _colleagueTwo;

        protected AbstractMediator(ConcreteColleagueOne colleagueOne, ConcreteColleagueTwo colleagueTwo)
        {
            _colleagueOne = colleagueOne;
            _colleagueTwo = colleagueTwo;
        }

        public abstract void NotifyChanged(string message, AbstractColleague colleague);
    }
}
