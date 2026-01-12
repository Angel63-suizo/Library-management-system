using LIBRARY.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY.MDashboard
{
    public partial class M_my_books : UserControl
    {
        private MemberType LoggedInMember;
  
        public M_my_books(MemberType member)
        {
            InitializeComponent();
            LoggedInMember = member;

            panel1.Paint += DrawCustomBorder;
            panel2.Paint += DrawCustomBorder;
            panel3.Paint += DrawCustomBorder;
            panel5.Paint += (s, e) => {
                
                DrawCustomBorder(s, e);
            };
        }

        private void DrawCustomBorder(object sender, PaintEventArgs e)
        {
            Control ctrl = (Control)sender;

            int radius = 16;
            int borderThickness = 1;
            Color borderColor = Color.FromArgb(220, 223, 230); 

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(borderThickness, borderThickness,
                                           ctrl.Width - borderThickness * 2, ctrl.Height - borderThickness * 2);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                ctrl.Region = new Region(path);

                using (Pen pen = new Pen(borderColor, borderThickness))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
        private void LoadBorrowedBooks()
        {
            try
            {
                flpBorrowedBooks.SuspendLayout();
                flpBorrowedBooks.Controls.Clear();

                MyBooks_Repository repo = new MyBooks_Repository();
                DataTable dt = repo.GetMemberBorrowedBooks(LoggedInMember.MemberId);

                if (dt != null && dt.Rows.Count > 0)
                {
                    int totalBorrowed = dt.Rows.Count;

                    int dueSoonCount = dt.AsEnumerable()
                        .Count(r => r.Field<string>("CopyStatus") == "Due Soon");

                    decimal totalFines = dt.AsEnumerable()
                        .Sum(r => r.Field<decimal>("Fine"));

                    lblBooksBorrowed.Text = totalBorrowed.ToString();
                    lblDue.Text = dueSoonCount.ToString();
                    lblTotalFines.Text = $"${totalFines:N2}";

                    foreach (DataRow row in dt.Rows)
                    {
                        ucBorrowedBook bookRow = new ucBorrowedBook();
                        bookRow.SetData(row);
                        bookRow.Height = 100;
                        bookRow.Width = Math.Max(flpBorrowedBooks.Width - 25, 200);

                        flpBorrowedBooks.Controls.Add(bookRow);
                    }
                }
            }
            finally
            {
                flpBorrowedBooks.ResumeLayout(true);
            }
        }
        private void M_my_books_Load(object sender, EventArgs e)
        {
            LoadBorrowedBooks();
        }
    }
}

