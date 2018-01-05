namespace DesignPatternVisitor
{
    public class HyperLink : DocPart
    {
        public string Url { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visite(this);
        }
    }
}
