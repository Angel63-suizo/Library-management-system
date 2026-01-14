using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace LIBRARY.Models
{
    public class Resource
    {

        public int ResourceId { get; set; }
        public string AccessionBase { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string PublisherName { get; set; }
        public int PublicationYear { get; set; }
        public string Edition { get; set; }
        public string Language { get; set; }
        public int Pages { get; set; }
        public string ResourceType { get; set; }
        public string Description { get; set; }
        public string CoverImagePath { get; set; }
        public string Location { get; set; }

        public string GetFullImagePath()
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "Covers");
            return Path.Combine(folderPath, CoverImagePath ?? "default_cover.png");
        }

        public string GetDetails()
        {
            return $"{Title} by {Author} ({PublicationYear}) - ISBN: {ISBN}";
        }

        public int TotalCopies { get; set; }
        public int AvailableCopies { get; set; }
    }
}
