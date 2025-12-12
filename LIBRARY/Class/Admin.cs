using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY.Class
{
    public class Admin : User
    {
        public Admin(MySqlDataReader r)

        {
            UserId = Convert.ToInt32(r["UserId"]);
            Username = r["Username"].ToString();
            FirstName = r["FirstName"].ToString();
            LastName = r["LastName"].ToString();
            Email = r["Email"].ToString();
            Role = "Admin";
        }

        public Admin()
        {
        }

    }
}
