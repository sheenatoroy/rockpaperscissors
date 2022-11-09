using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatoPickWeek10
{
    public partial class Form2 : Form
    {
        String con;
        public static string name1;
        public static string name2;


        public Form2()
        {
            InitializeComponent();

            
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
          
                name1 = txtName1.Text;
                name2 = txtName2.Text;

                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();

            
        }

        private void btnBack_MouseMove(object sender, MouseEventArgs e)
        {
            btnBack.BackColor = Color.Blue;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.Transparent;
        }

        private void btnNext_MouseMove(object sender, MouseEventArgs e)
        {
            btnNext.BackColor = Color.Yellow;
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.BackColor = Color.Transparent;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            
          

            
        }
    }
}
