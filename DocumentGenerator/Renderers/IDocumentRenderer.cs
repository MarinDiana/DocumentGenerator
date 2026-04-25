using DocumentGenerator.Models;

namespace DocumentGenerator.Renderers
{
    public interface IDocumentRenderer
    {
        string Render(DocumentData data);
    }
}