using DesignPatternsTutorials.Structural.Composite.Components.ComputerAssemble;

namespace DesignPatternsTutorials.Structural.Composite.Composites.ComputerAssemble
{
    public class ComputerAssembleComposite : ComputerAssembleComponent
    {
        private List<ComputerAssembleComponent> _components;
        public ComputerAssembleComposite(string name, ComputerAssembleComponent[] components) : base(name)
        {
            _components = new List<ComputerAssembleComponent>();
            foreach (var component in components)
            {
                Add(component);
            }
        }
        public ComputerAssembleComposite(string name) : base(name)
        {
            _components = new List<ComputerAssembleComponent>();
        }

        public override void Add(ComputerAssembleComponent component)
        {
            _components.Add(component);
        }

        public override void Remove(ComputerAssembleComponent component)
        {
            _components.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);
            foreach (var component in _components)
            {
                component.Display(depth + 2);
            }
        }
    }
}
