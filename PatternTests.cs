using NUnit.Framework;
using DocumentGenerator.Models;
using DocumentGenerator.Builders;
using DocumentGenerator.Exporters;
using DocumentGenerator.Factories;
using DocumentGenerator.Prototypes;
using DocumentGenerator.Configuration;

namespace DocumentGenerator.Tests
{
    public class PatternTests
    {
        [Test]
        public void Builder_Should_Create_Valid_Document()
        {
            var doc = new DocumentDataBuilder()
                .WithTitle("Test")
                .ByAuthor("Diana")
                .WithSection("Section 1")
                .Build();

            Assert.That(doc.Title, Is.EqualTo("Test"));
            Assert.That(doc.Sections.Count, Is.EqualTo(1));
        }

        [Test]
        public void Factory_Should_Render_Html()
        {
            var data = new DocumentDataBuilder()
                .WithTitle("HTML Doc")
                .ByAuthor("Diana")
                .WithSection("Hello")
                .Build();

            var exporter = new HtmlDocumentExporter();
            var result = exporter.Export(data);

            Assert.That(result.Contains("<html>"), Is.True);
        }

        [Test]
        public void AbstractFactory_Should_Assemble_Report()
        {
            var factory = new ReportComponentFactory();
            var assembler = new DocumentAssembler(factory);

            var data = new DocumentDataBuilder()
                .WithTitle("Raport")
                .ByAuthor("Diana")
                .WithSection("Sectiune")
                .Build();

            var result = assembler.Assemble(data);

            Assert.That(result.Contains("RAPORT"), Is.True);
        }

        [Test]
        public void Prototype_Should_Clone_Template()
        {
            var template = new DocumentTemplate
            {
                DefaultTitle = "Template"
            };

            var clone = template.Clone();

            Assert.That(clone.DefaultTitle, Is.EqualTo("Template"));
        }

        [Test]
        public void Singleton_Should_Return_Same_Instance()
        {
            var config1 = AppConfiguration.Instance;
            var config2 = AppConfiguration.Instance;

            Assert.That(config1, Is.EqualTo(config2));
        }
    }
}