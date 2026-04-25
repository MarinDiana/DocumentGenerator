using DocumentGenerator.Renderers;

namespace DocumentGenerator.Exporters
{
    public class PlainTextDocumentExporter : DocumentExporter
    {
        protected override IDocumentRenderer CreateRenderer()
        {
            return new PlainTextRenderer();
        }
    }
}