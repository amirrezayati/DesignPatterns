using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsTutorials.Behavioral.ChainOfResponsibility.Handlers;

namespace DesignPatternsTutorials.Behavioral.ChainOfResponsibility.ConcreteHandlers
{
    public class ConcreteHandler : AbstractHandler
    {
        public override void HandleRequest(int request)
        {
            if (request <= 50)
            {
                Console.WriteLine("ConcreteHandler Handled");
            }
            else if(_successor != null)
            {
                _successor.HandleRequest(request);
            }
        }
    }
}
