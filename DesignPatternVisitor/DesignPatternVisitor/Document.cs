using System.Collections.Generic;

namespace DesignPatternVisitor
{
    class Document : IVisitable
    {
        public List<DocPart> ListeDocPart { get; set; }

        public void Accept(IVisitor visitor)
        {
            foreach (var docPart in ListeDocPart)
            {
                docPart.Accept(visitor);
            }
        }
    }
}
