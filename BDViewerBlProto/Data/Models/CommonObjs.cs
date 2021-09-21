using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace BDViewerBlProto.Data.Models
{
    public class Acronym
    {
        public string Letter { get; set; }
        public string Term { get; set; }
        public string Definition { get; set; }

        public Acronym (string letter, string term, string definition)
        {
            Letter = letter;
            Term = term;
            Definition = definition;
        }
    }

    public class RefDocuments
    {
        public int RefId { get; set; }
        public string RefCode { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string FileName { get; set; }

        public RefDocuments(int refid, string refcode, string title, string date, string fileName)
        {
            RefId = refid;
            RefCode = refcode;
            Title = title;
            Date = date;
            FileName = fileName;
        }
    }
}
