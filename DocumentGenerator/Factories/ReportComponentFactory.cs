namespace DocumentGenerator.Factories
{
    public class ReportComponentFactory : IDocumentComponentFactory
    {
        public string CreateHeader()
        {
            return "=== RAPORT ===";
        }

        public string CreateSection(string content)
        {
            return $"[DATA] {content}";
        }

        public string CreateFooter()
        {
            return "--- Sfarsit raport ---";
        }
    }
}