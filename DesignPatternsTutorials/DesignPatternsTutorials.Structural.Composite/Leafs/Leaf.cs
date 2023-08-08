using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsTutorials.Structural.Composite.Components;

namespace DesignPatternsTutorials.Structural.Composite.Leafs
{
    public class Leaf : AbstractComponent
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Operation()
        {
            throw new NotImplementedException();
        }

        public override void Add(AbstractComponent component)
        {
            throw new NotImplementedException();
        }

        public override void Remove(AbstractComponent component)
        {
            throw new NotImplementedException();
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);
        }
    }
}
