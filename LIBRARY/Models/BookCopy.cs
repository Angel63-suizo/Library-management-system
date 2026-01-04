using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY.Models
{
    internal class BookCopy
    {
        private int copyId;
        private int resourceId;
        private string accessionNumber;
        private string barcode;
        private string status;
        private string condition;
        
        public int CopyId { get => copyId; set => copyId = value; }
        public int ResourceId { get => resourceId; set => resourceId = value; }
        public string AccessionNumber { get => accessionNumber; set => accessionNumber = value; }
        public string Barcode { get => barcode; set => barcode = value; }
        public string Status { get => status; set => status = value; }
        public string Condition { get => condition; set => condition = value; }
    }
}
