namespace DesignPatternVisitor
{
    public class PlainText : DocPart
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visite(this);
        }
    }
}
