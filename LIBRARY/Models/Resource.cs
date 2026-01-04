using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace LIBRARY.Models
{
    internal class Resource
    {
        private int resourceid;
        private string accessionBase;
        private string isbn;
        private string title;
        private string author;
        private string publisherId;
        private int publicationYear;
        private string edition;
        private string language;
        private int pages;
        private string resourcheType;
        private string description;

        public int ResourceId { get => resourceid; set => resourceid = value; }
        public string AccessionBase { get => accessionBase; set => accessionBase = value; }
        public string ISBN { get => isbn; set => isbn = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string PublisherId { get => publisherId; set => publisherId = value; }
        public int PublicationYear { get => publicationYear; set => publicationYear = value; }
        public string Edition { get => edition; set => edition = value; }
        public string Language { get => language; set => language = value; }
        public int Pages { get => pages; set => pages = value; }
        public string ResourcheType { get => resourcheType; set => resourcheType = value; }
        public string Description { get => description; set => description = value; }

       /* public string getDetails()
        {

        }*/
    }
}
