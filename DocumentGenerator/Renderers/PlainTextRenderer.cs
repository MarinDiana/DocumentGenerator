using System.Text;
using DocumentGenerator.Models;

namespace DocumentGenerator.Renderers
{
    public class PlainTextRenderer : IDocumentRenderer
    {
        public string Render(DocumentData data)
        {
            var sb = new StringBuilder();

            sb.AppendLine(data.Title);
            sb.AppendLine(data.Author);

            foreach (var section in data.Sections)
            {
                sb.AppendLine(section);
            }

            sb.AppendLine(data.FooterNotes);

            return sb.ToString();
        }
    }
}