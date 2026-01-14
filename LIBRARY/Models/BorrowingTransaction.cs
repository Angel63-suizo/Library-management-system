using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY.Models
{
    public class BorrowingTransaction
    {

        public int TransactionId { get; set; }
        public int MemberId { get; set; }
        public int CopyId { get;  set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnedDate { get; set; }
        public string Status { get; set; }
        public decimal FineAmount { get; set; }

    }
}
