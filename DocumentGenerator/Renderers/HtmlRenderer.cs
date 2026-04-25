using System.Text;
using DocumentGenerator.Models;

namespace DocumentGenerator.Renderers
{
    public class HtmlRenderer : IDocumentRenderer
    {
        public string Render(DocumentData data)
        {
            var sb = new StringBuilder();

            sb.AppendLine("<html><body>");
            sb.AppendLine($"<h1>{data.Title}</h1>");
            sb.AppendLine($"<p><i>{data.Author}</i></p>");

            foreach (var section in data.Sections)
            {
                sb.AppendLine($"<p>{section}</p>");
            }

            sb.AppendLine($"<footer>{data.FooterNotes}</footer>");
            sb.AppendLine("</body></html>");

            return sb.ToString();
        }
    }
}