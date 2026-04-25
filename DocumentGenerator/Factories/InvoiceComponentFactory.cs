namespace DocumentGenerator.Factories
{
    public class InvoiceComponentFactory : IDocumentComponentFactory
    {
        public string CreateHeader()
        {
            return "=== FACTURA ===";
        }

        public string CreateSection(string content)
        {
            return $"(Articol) {content}";
        }

        public string CreateFooter()
        {
            return "TOTAL DE PLATA";
        }
    }
}