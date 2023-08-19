using DesignPatternsTutorials.Structural.Proxy.Subjects;

namespace DesignPatternsTutorials.Structural.Proxy.RealSubjects
{
    public class RealSubject : ISubject
    {
        public void DoAction()
        {
            Console.WriteLine($"RealSubject.DoAction()");
        }
    }
}
