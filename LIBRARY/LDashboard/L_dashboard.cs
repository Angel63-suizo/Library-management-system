using LIBRARY.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY.LDashboard
{
    public partial class L_dashboard : UserControl
    {
        private Librarian CurrentUser;
        public L_dashboard(Librarian currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;
        }
        private void L_dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
