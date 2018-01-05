namespace DesignPatternVisitor
{
    /// <summary>
    /// Pour qu'une classe soit visitable, elle doit implémenter la méthode Accept
    /// </summary>
    public interface IVisitable
    {
        void Accept(IVisitor visitor);
    }
}