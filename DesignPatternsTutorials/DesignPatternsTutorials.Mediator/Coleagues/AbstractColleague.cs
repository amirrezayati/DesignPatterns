using DesignPatternsTutorials.Mediator.Mediators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTutorials.Mediator.Coleagues
{
    public abstract class AbstractColleague
    {
        protected AbstractMediator _mediator;

        public void SetColleague(AbstractMediator mediator)
        {
            _mediator = mediator;
        }

        public virtual void Send(string message)
        {
            _mediator.NotifyChanged(message, this);
        }
    }
}
