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
    public partial class Form4 : Form
    {
        String con;
        public Form4()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            con = "Server=localhost;Database=db_playerdata;User=root;Password=;";
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(con);
                connection.Open();
                MySqlCommand cmd1 = connection.CreateCommand();
                cmd1.CommandText = "Select * From tbl_playerdata";
                MySqlDataAdapter adap1 = new MySqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                adap1.Fill(ds1);
                dataGridView1.DataSource = ds1.Tables[0].DefaultView;
                
            }
            catch (Exception z)
            {
                MessageBox.Show("Connection Problem");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
