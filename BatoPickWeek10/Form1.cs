using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace BatoPickWeek10
{
    public partial class Form1 : Form
    {
        String con;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {

            con = "Server=localhost;Database=db_playerdata;User=root;Password=;";
            MySqlConnection connection = new MySqlConnection(con);

            try
            {
                connection.Open();
                MessageBox.Show("Connection Successful");
                connection.Close();

                btnNext.Enabled = true;


            }
            catch
            {
                MessageBox.Show("Error In Connection");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void btnGetStarted_MouseMove(object sender, MouseEventArgs e)
        {
            btnGetStarted.BackColor = Color.Yellow;
        }

        private void btnGetStarted_MouseLeave(object sender, EventArgs e)
        {
            btnGetStarted.BackColor = Color.Transparent;
        }

        private void btnNext_MouseMove(object sender, MouseEventArgs e)
        {
            btnNext.BackColor = Color.Yellow;
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.BackColor = Color.Transparent;
        }

        private void btnLeaderboard_MouseMove(object sender, MouseEventArgs e)
        {
            btnLeaderboard.BackColor = Color.Blue;
        }

        private void btnLeaderboard_MouseLeave(object sender, EventArgs e)
        {
            btnLeaderboard.BackColor = Color.Transparent;
        }

        private void btnExit_MouseMove(object sender, MouseEventArgs e)
        {
            btnExit.BackColor = Color.Blue;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Transparent;
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Dispose();
            }
            else
            {

            }
        }
    }
}

