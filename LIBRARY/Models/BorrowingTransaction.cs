using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY.Models
{
    internal class BorrowingTransaction
    {
        private int transactionId;
        private int memberId;
        private int copyId;
        private DateTime checkoutDate;
        private DateTime dueDate;
        private DateTime returnedDate;
        private string status;
        private decimal fineAmount;

        public int TransactionId { get => transactionId; set => transactionId = value; }
        public int MemberId { get => memberId; set => memberId = value; }
        public int CopyId { get => copyId;  set => copyId = value; }
        public DateTime CheckoutDate { get => checkoutDate; set => checkoutDate = value; }
        public DateTime DueDate { get => dueDate; set => dueDate = value; }
        public DateTime ReturnedDate { get => returnedDate; set => returnedDate = value; }
        public string Status { get => status; set => status = value; }
        public decimal FineAmount { get => fineAmount; set => fineAmount = value; }

        public decimal CalculateFine()
        {
            if (Status == "Returned" && ReturnedDate > DueDate)
            {
                TimeSpan overdueDuration = ReturnedDate - DueDate;
                decimal finePerDay = 1.00m; 
                return (decimal)overdueDuration.Days * finePerDay;
            }
            return 0.00m;
        }
    }
}
