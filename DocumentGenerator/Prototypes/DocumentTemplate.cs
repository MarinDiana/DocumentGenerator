using System.Collections.Generic;

namespace DocumentGenerator.Prototypes
{
    public class DocumentTemplate
    {
        public string DefaultTitle { get; set; }
        public List<string> Sections { get; set; }
        public string PageFormat { get; set; }
        public string Orientation { get; set; }

        public DocumentTemplate()
        {
            DefaultTitle = "";
            Sections = new List<string>();
            PageFormat = "A4";
            Orientation = "Portrait";
        }

        public DocumentTemplate Clone()
        {
            return new DocumentTemplate
            {
                DefaultTitle = this.DefaultTitle,
                Sections = new List<string>(this.Sections),
                PageFormat = this.PageFormat,
                Orientation = this.Orientation
            };
        }
    }
}