using DocumentGenerator.Renderers;

namespace DocumentGenerator.Exporters
{
    public class HtmlDocumentExporter : DocumentExporter
    {
        protected override IDocumentRenderer CreateRenderer()
        {
            return new HtmlRenderer();
        }
    }
}