using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Member
{
    public partial class Browse_Catalog : UserControl
    {
      
       
        public Browse_Catalog()
        {
            InitializeComponent();
        
        }
   
        private void DisplayBooks(List<Book> books)
        {
     
        }

        private void Browse_Catalog_Load(object sender, EventArgs e)
        {
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {


        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            using (var popUp = new Book_Details())
            {
                if (popUp.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var popUp = new CleanCode())
            {
                if (popUp.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var popUp = new ThePragmaticProgrammer())
            {
                if (popUp.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var popUp = new EffectiveJava())
            {
                if (popUp.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var popUp = new HeadFirstDesignPatterns())
            {
                if (popUp.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var popUp = new DatabaseSystemConcepts())
            {
                if (popUp.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}




