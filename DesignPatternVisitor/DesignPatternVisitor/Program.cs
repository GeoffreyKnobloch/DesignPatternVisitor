using System;
using System.Collections.Generic;

namespace DesignPatternVisitor
{
    /// <summary>
    /// Programme example illustrant le design pattern Visitor
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Exploitation :
            Document document = new Document()
            {
                ListeDocPart = new List<DocPart>()
                {
                    {new BoldText() {Data = "Bonjour en gras" } },
                    {new PlainText() {Data = "Bonjour normal" } },
                    { new HyperLink() {Data = "lien hyper", Url = "https://geoffreyknobloch.gitbooks.io/veilletechno/content" } }
                }
            };

            HtmlVisitor visiteurHtml = new HtmlVisitor();

            document.Accept(visiteurHtml);

            Console.WriteLine(visiteurHtml.Output);

            Console.ReadKey();

        }
    }
}
