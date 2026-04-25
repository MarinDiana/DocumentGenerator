using System;
using System.Collections.Generic;

namespace DocumentGenerator.Models
{
    public class DocumentData
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public List<string> Sections { get; set; }
        public string PageFormat { get; set; }
        public string Orientation { get; set; }
        public string FooterNotes { get; set; }

        public DocumentData()
        {
            Sections = new List<string>();
            Date = DateTime.Now;
            PageFormat = "A4";
            Orientation = "Portrait";
            FooterNotes = "";
        }
    }
}