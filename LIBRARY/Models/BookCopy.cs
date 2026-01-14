using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY.Models
{
    internal class BookCopy
    {

        public int CopyId { get; set; }
        public int ResourceId { get; set; }
        public string AccessionNumber { get; set; }
        public string Barcode { get; set; }
        public string Status { get; set; }
        public string Condition { get; set; }
    }
}
