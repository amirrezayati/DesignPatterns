using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsTutorials.Mediator.Coleagues;

namespace DesignPatternsTutorials.Mediator.ConcreteColleagues
{
    public class ConcreteColleagueOne : AbstractColleague
    {
        public override void Send(string message)
        {
            Console.WriteLine("ConcreteColleagueOne Send :" + message);
            base.Send(message);
        }

        public void Receive(string message)
        {
            Console.WriteLine("ConcreteColleagueOne Receive :" + message);
        }
    }
}
