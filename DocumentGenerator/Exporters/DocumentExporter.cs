using DocumentGenerator.Models;
using DocumentGenerator.Renderers;

namespace DocumentGenerator.Exporters
{
    public abstract class DocumentExporter
    {
        protected abstract IDocumentRenderer CreateRenderer();

        public string Export(DocumentData data)
        {
            var renderer = CreateRenderer();
            return renderer.Render(data);
        }
    }
}