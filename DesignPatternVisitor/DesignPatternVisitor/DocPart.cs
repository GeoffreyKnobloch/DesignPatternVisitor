namespace DesignPatternVisitor
{
    public abstract class DocPart : IVisitable
    {
        /// <summary>
        /// Data métier du docpart
        /// </summary>
        public string Data { get; set; }
        public abstract void Accept(IVisitor visitor);
    }
}