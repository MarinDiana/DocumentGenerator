namespace DocumentGenerator.Factories
{
    public interface IDocumentComponentFactory
    {
        string CreateHeader();
        string CreateSection(string content);
        string CreateFooter();
    }
}