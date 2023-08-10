using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsTutorials.Structural.Composite.Components;

namespace DesignPatternsTutorials.Structural.Composite.Composites
{
    public class Composite: AbstractComponent
    {
        private List<AbstractComponent> _components;
        public Composite(string name) : base(name)
        {
            _components = new List<AbstractComponent>();
        }
        public Composite(string name, AbstractComponent[] components) : base(name)
        {
            _components = new List<AbstractComponent>();

            foreach (var component in components)
                Add(component);
        }
        public override void Operation()
        {
            throw new NotImplementedException();
        }

        public sealed override void Add(AbstractComponent component)
        {
            _components.Add(component);
        }

        public override void Remove(AbstractComponent component)
        {
            _components.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-',depth) + Name);
            foreach (var component in _components)
            {
                component.Display(depth + 2);
            }
        }
    }
}
