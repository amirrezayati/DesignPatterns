using DesignPatternsTutorials.Structural.Proxy.RealSubjects;
using DesignPatternsTutorials.Structural.Proxy.Subjects;

namespace DesignPatternsTutorials.Structural.Proxy.Proxies
{
    public class Proxy : ISubject
    {
        private RealSubjects.RealSubject realSubject;


        public void DoAction()
        {
            if (realSubject is null)
            {
                realSubject = new RealSubjects.RealSubject();
            }
            realSubject.DoAction();
        }
    }
}
