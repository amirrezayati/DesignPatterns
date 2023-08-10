namespace DesignPatternsTutorials.Structural.Composite.Components.ComputerAssemble
{
    public abstract class ComputerAssembleComponent
    {
        public ComputerAssembleComponent(string name)
        {
            Name = name;
        }
        protected string Name { get; set; }
        public abstract void Add(ComputerAssembleComponent component);
        public abstract void Remove(ComputerAssembleComponent component);
        public abstract void Display(int depth);
    }
}
