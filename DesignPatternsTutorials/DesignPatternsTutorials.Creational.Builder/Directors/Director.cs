using DesignPatternsTutorials.Creational.Builder.Builder;

namespace DesignPatternsTutorials.Creational.Builder.Directors
{
    public class Director
    {
        private AbstractBuilder _builder;

        public void SetBuilder(AbstractBuilder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.BuildPartOne();
            _builder.BuildPartTwo();
        }
    }
}
