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
            Admin CurrentUser = new Admin();
            //Librarian CurrentUser = new Librarian();
            //Member CurrentUser = new Member();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new M_MainForm(CurrentUser));
            //Application.Run(new L_MainForm(CurrentUser));
            //Application.Run(new Login.Login());
            //Application.Run(new Register.register());
            //Application.Run(new Register.LibrarianRegister());
            Application.Run(new A_MainForm());
            //.Run(new Form1());
        }
    }
}
