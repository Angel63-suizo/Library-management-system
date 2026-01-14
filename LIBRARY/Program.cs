using LIBRARY.Class;
using LIBRARY.MDashboard;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY
{
    internal static class Program
    {
        [STAThread]

        static void Main()
        {
            //Admin CurrentUser = new Admin();
            //libraryStaff CurrentUser = new libraryStaff();
            //Models.Member CurrentUser = new Models.Member();
            Admin LoggedInAdmin = new Admin();
            //MemberType LoggedInMember = new MemberType();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login.Login());
            //Application.Run(new Register.register());
            //Application.Run(new Register.LibrarianRegister());
            Application.Run(new A_MainForm(LoggedInAdmin));
            //Application.Run(new M_MainForm(LoggedInMember));
            //.Run(new Form1());
        }
    }
}
