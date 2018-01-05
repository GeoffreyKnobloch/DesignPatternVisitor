namespace DesignPatternVisitor
{
    /// <summary>
    /// Un visitor implémente la méthode Visite(IVisitable)
    /// </summary>
    public interface IVisitor
    {
        void Visite(PlainText visitable);
        void Visite(BoldText visitable);
        void Visite(HyperLink visitable);
    }
}