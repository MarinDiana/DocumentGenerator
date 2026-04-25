using System;
using DocumentGenerator.Models;

namespace DocumentGenerator.Builders
{
    public class DocumentDataBuilder
    {
        private DocumentData data = new DocumentData();

        public DocumentDataBuilder WithTitle(string title)
        {
            data.Title = title;
            return this;
        }

        public DocumentDataBuilder ByAuthor(string author)
        {
            data.Author = author;
            return this;
        }

        public DocumentDataBuilder WithSection(string section)
        {
            data.Sections.Add(section);
            return this;
        }

        public DocumentDataBuilder InLandscape()
        {
            data.Orientation = "Landscape";
            return this;
        }

        public DocumentDataBuilder WithFootnote(string note)
        {
            data.FooterNotes = note;
            return this;
        }

        public DocumentData Build()
        {
            if (string.IsNullOrEmpty(data.Title))
                throw new InvalidOperationException("Title is required");

            if (string.IsNullOrEmpty(data.Author))
                throw new InvalidOperationException("Author is required");

            if (data.Sections.Count == 0)
                throw new InvalidOperationException("At least one section is required");

            return data;
        }
    }
}