namespace DesignPatternVisitor
{
    /// <summary>
    /// Visiteur Pour obtenir la version Html d'un document
    /// </summary>
    public class HtmlVisitor : IVisitor
    {

        private string _outPut = string.Empty;

        public string Output
        {
            get { return _outPut; }
        }


        public void Visite(HyperLink visitable)
        {
            this._outPut += "<a href=\"" + visitable.Url + "\">" + visitable.Data + "</a>";
        }

        public void Visite(BoldText visitable)
        {
            this._outPut += "<b>" + visitable.Data + "<b>";
        }

        public void Visite(PlainText visitable)
        {
            this._outPut += visitable.Data;
        }
    }
}
