namespace DesignPatternsTutorials.Behavioral.ChainOfResponsibility.Handlers
{
    public abstract class AbstractHandler
    {
        protected AbstractHandler _successor;

        public void SetSuccessor(AbstractHandler successor)
        {
            _successor = successor;
        }

        public abstract void HandleRequest(int request);
    }
}
