using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp
{
    public class ReportedIssue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Attachment { get; set; }

        public ReportedIssue(string location, string category, string description, string attachment)
        {
            Location = location;
            Category = category;
            Description = description;
            Attachment = attachment;
        }
    }
}

