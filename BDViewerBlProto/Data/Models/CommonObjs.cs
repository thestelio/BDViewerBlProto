using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace BDViewerBlProto.Data.Models
{
    public class Acronym
    {
        public string AcronymAbbr { get; set; }
        public string Definition { get; set; }        
    }

    public class RefDocuments
    {
        public string RefCode { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string FileName { get; set; }
    }
}
