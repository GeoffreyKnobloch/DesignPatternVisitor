namespace DesignPatternVisitor
{
    public class BoldText : DocPart
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visite(this);
        }
    }
}
