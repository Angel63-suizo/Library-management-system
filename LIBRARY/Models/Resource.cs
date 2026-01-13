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
        private int resourceid;
        private string accessionBase;
        private string isbn;
        private string title;
        private string author;
        private string publisherName;
        private int publicationYear;
        private string edition;
        private string language;
        private int pages;
        private string resourcheType;
        private string description;
        private string coverImagePath;
        private string location;
        public int ResourceId { get => resourceid; set => resourceid = value; }
        public string AccessionBase { get => accessionBase; set => accessionBase = value; }
        public string ISBN { get => isbn; set => isbn = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string PublisherName { get => publisherName; set => publisherName = value; }
        public int PublicationYear { get => publicationYear; set => publicationYear = value; }
        public string Edition { get => edition; set => edition = value; }
        public string Language { get => language; set => language = value; }
        public int Pages { get => pages; set => pages = value; }
        public string ResourceType { get => resourcheType; set => resourcheType = value; }
        public string Description { get => description; set => description = value; }
        public string CoverImagePath { get => coverImagePath; set => coverImagePath = value; }
        public string Location { get => location; set => location = value; }

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
