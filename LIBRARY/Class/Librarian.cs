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
    public class Librarian : User
    {
        public Librarian()
        {
        }

        public Librarian(MySqlDataReader r)
        {
            UserId = Convert.ToInt32(r["UserId"]);
            Username = r["Username"].ToString();
            FirstName = r["FirstName"].ToString();
            LastName = r["LastName"].ToString();
            Email = r["Email"].ToString();
            Role = "Librarian";
        }
    }
}
