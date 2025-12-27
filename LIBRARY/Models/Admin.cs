using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace LIBRARY.Class
{
    public class Admin : User
    {
       /* public Report GenerateReport(string type)
        {
            Console.WriteLine($"Generating {type} report");
            return new Report();

        }*/

        public void ConfigureSystem()
        {
            Console.WriteLine("System configuration update.");
        }
    }
}
