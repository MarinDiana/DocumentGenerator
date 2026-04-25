using System;
using System.Collections.Generic;

namespace DocumentGenerator.Prototypes
{
    public class TemplateRegistry
    {
        private readonly Dictionary<string, DocumentTemplate> templates =
            new Dictionary<string, DocumentTemplate>();

        public void Register(string key, DocumentTemplate template)
        {
            templates[key] = template;
        }

        public DocumentTemplate GetClone(string key)
        {
            if (!templates.ContainsKey(key))
                throw new ArgumentException("Template-ul nu exista.");

            return templates[key].Clone();
        }
    }
}