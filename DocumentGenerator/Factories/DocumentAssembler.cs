using System.Text;
using DocumentGenerator.Models;

namespace DocumentGenerator.Factories
{
    public class DocumentAssembler
    {
        private readonly IDocumentComponentFactory factory;

        public DocumentAssembler(IDocumentComponentFactory factory)
        {
            this.factory = factory;
        }

        public string Assemble(DocumentData data)
        {
            var sb = new StringBuilder();

            sb.AppendLine(factory.CreateHeader());

            foreach (var section in data.Sections)
            {
                sb.AppendLine(factory.CreateSection(section));
            }

            sb.AppendLine(factory.CreateFooter());

            return sb.ToString();
        }
    }
}