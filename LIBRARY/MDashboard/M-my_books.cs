using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace LIBRARY.MDashboard
{
    public partial class M_my_books : UserControl
    {
        private List<BorrowedBook> borrowedBooks = new List<BorrowedBook>();

        class BorrowedBook
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string BookCode { get; set; }
            public DateTime BorrowDate { get; set; }
            public DateTime DueDate { get; set; }
            public decimal FinePerDay { get; set; }
        }

        public M_my_books()
        {
            InitializeComponent();

            panel1.Paint += DrawCustomBorder;
            panel2.Paint += DrawCustomBorder;
            panel3.Paint += DrawCustomBorder;
            flowLayoutPanel1.Paint += DrawCustomBorder;

            panel5.Paint += (s, e) => {
                
                DrawCustomBorder(s, e);
            };
        }
        private void M_Profile_Load(object sender, EventArgs e)
        {
            LoadBorrowedBooks();
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
            borrowedBooks.Clear();

            borrowedBooks.Add(new BorrowedBook
            {
                Title = "Introduction to Algorithms",
                Author = "Thomas H. Cormen",
                BookCode = "B001-003",
                BorrowDate = DateTime.Now.AddDays(-20),
                DueDate = DateTime.Now.AddDays(-5),
                FinePerDay = 1.00m
            });

            borrowedBooks.Add(new BorrowedBook
            {
                Title = "Clean Code",
                Author = "Robert C. Martin",
                BookCode = "B002-005",
                BorrowDate = DateTime.Now.AddDays(-10),
                DueDate = DateTime.Now.AddDays(3),
                FinePerDay = 1.00m
            });

            borrowedBooks.Add(new BorrowedBook
            {
                Title = "Effective Java",
                Author = "Joshua Bloch",
                BookCode = "B003-001",
                BorrowDate = DateTime.Now.AddDays(-5),
                DueDate = DateTime.Now.AddDays(10),
                FinePerDay = 1.00m
            });

            UpdateSummary();
        }
        private string GetStatus(BorrowedBook book)
        {
            if (DateTime.Now > book.DueDate)
                return "Overdue";

            if ((book.DueDate - DateTime.Now).Days <= 3)
                return "Due Soon";

            return "On Time";
        }

        private decimal GetFine(BorrowedBook book)
        {
            if (DateTime.Now <= book.DueDate)
                return 0;

            int overdueDays = (DateTime.Now - book.DueDate).Days;
            return overdueDays * book.FinePerDay;
        }
        private void UpdateSummary()
        {
            int totalBooks = borrowedBooks.Count;
            int dueSoon = borrowedBooks.Count(b => GetStatus(b) == "Due Soon");
            decimal totalFine = borrowedBooks.Sum(b => GetFine(b));

            label9.Text = totalBooks.ToString();       
            label10.Text = dueSoon.ToString();          
            label11.Text = $"${totalFine:0.00}";        

            panel5.Visible = totalFine > 0;            
        }

        private void RenewBook(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            var book = borrowedBooks.FirstOrDefault(b => GetStatus(b) != "On Time");

            if (book == null)
            {
                MessageBox.Show("No book available for renewal.",
                    "Renew", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            book.DueDate = book.DueDate.AddDays(7);

            MessageBox.Show(
                $"'{book.Title}' has been renewed.\nNew Due Date: {book.DueDate:yyyy-MM-dd}",
                "Renew Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            UpdateSummary();
        }
    }
}

