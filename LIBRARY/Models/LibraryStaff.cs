using LIBRARY.LDashboard;
using LIBRARY.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LIBRARY.Class
{
    public class libraryStaff : User
    {
        private BorrowingTransaction_Repository _transactionRepo = new BorrowingTransaction_Repository();
        public bool ProcessCheckout(string memberCardNumber, List<BorrowingTransaction> items)
        {
            if (items == null || items.Count == 0 || string.IsNullOrEmpty(memberCardNumber))
                return false;

            return _transactionRepo.SaveBorrowingTransaction(memberCardNumber, items);
        }

        public bool ProcessReturn(List<BorrowingTransaction> items)
        {
            if (items == null || items.Count == 0)
                return false;

            return _transactionRepo.ReturnBooksTransaction(items);
        }
    }
}
