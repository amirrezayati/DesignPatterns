using DesignPatternsTutorials.Structural.Composite.Components.ComputerAssemble;

namespace DesignPatternsTutorials.Structural.Composite.Leafs.ComputerAssemble
{
    public class ComputerAssembleLeaf : ComputerAssembleComponent
    {
        public ComputerAssembleLeaf(string name) : base(name)
        {
        }

        public override void Add(ComputerAssembleComponent component)
        {
            throw new NotImplementedException();
        }

        public override void Remove(ComputerAssembleComponent component)
        {
            throw new NotImplementedException();
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);
        }
    }
}
