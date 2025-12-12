using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRARY.Class
{
    public class Database
    {
        public static string ConnectionString =
            "Server=localhost;     Port=3306;     Database=librarydb;     Uid=root;     Pwd=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
