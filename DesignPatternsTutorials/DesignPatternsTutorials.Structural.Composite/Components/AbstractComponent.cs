namespace DesignPatternsTutorials.Structural.Composite.Components
{
    public abstract class AbstractComponent
    {
        public AbstractComponent( string name)
        {
            Name = name;
        }
        protected string Name { get; set; }
        public abstract void Operation();
        public abstract void Add(AbstractComponent component);
        public abstract void Remove(AbstractComponent component);
        public abstract void Display(int depth);
    }
}
