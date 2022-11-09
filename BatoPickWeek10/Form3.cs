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
using System.Xml.Linq;

namespace BatoPickWeek10
{
    public partial class Form3 : Form
    {
        string player1Choice;
        string player2Choice;
        string playerWinner;

        int player1Score = 100;
        int player2Score = 100;

        int rounds = 0;
        int playerScore;


        String con;
        public Form3()
        {
            InitializeComponent();

            player1Choice = "none";
            player2Choice = "none";

        }
        private void lblName1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblName1.Text = Form2.name1;
            lblName2.Text = Form2.name2;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
;
        }

        

        private void btnPaper1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D:\\Users\\sjtor\\Downloads\\BatoPicks\\paper.png");
            player1Choice = "paper1";
        }

        private void btnRock1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D:\\Users\\sjtor\\Downloads\\BatoPicks\\rock.png");
            player1Choice = "rock1";
        }

        private void btnScissors1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D:\\Users\\sjtor\\Downloads\\BatoPicks\\scissors.png");
            player1Choice = "scissors1";
        }

        private void btnRock2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("D:\\Users\\sjtor\\Downloads\\BatoPicks\\rock.png");
            player2Choice = "rock2";
        }

        private void btnPaper2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("D:\\Users\\sjtor\\Downloads\\BatoPicks\\paper.png");
            player2Choice = "paper2";
        }

        private void btnScissors2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("D:\\Users\\sjtor\\Downloads\\BatoPicks\\scissors.png");
            player2Choice = "scissors2";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //rock1
            if(player1Choice == "rock1")
            {
                if(player2Choice == "rock2")
                {
                    lblGameStatus.Text = "Its a Draw";

                }else if(player2Choice == "paper2")
                {
                    lblGameStatus.Text = lblName2.Text + " Won" + "\n" + lblName1.Text + " Lost";
                    player1Score -= 20;
                    lblScore1.Text = player1Score.ToString();

                }
                else
                {
                    lblGameStatus.Text = lblName1.Text + " Won" + "\n" + lblName2.Text + " Lost";
                    player2Score -= 20;
                    lblScore2.Text = player2Score.ToString();
                }
            //paper
            }else if(player1Choice == "paper1")
            {
                if(player2Choice == "rock2")
                {
                    lblGameStatus.Text = lblName1.Text + " Won" + "\n" + lblName2.Text + " Lost";
                    player2Score -= 20;
                    lblScore2.Text = player2Score.ToString();

                }
                else if(player2Choice == "paper2")
                {
                    lblGameStatus.Text = "Its a Draw";

                }
                else
                {
                    lblGameStatus.Text = lblName1.Text + " Lost" + "\n" + lblName2.Text + " Won";
                    player1Score -= 20;
                    lblScore1.Text = player1Score.ToString();
                }
            //scissors
            }else if(player1Choice == "scissors1")
            {
                if(player2Choice == "rock2")
                {
                    lblGameStatus.Text = lblName1.Text + " Won" + "\n" + lblName2.Text + " Lost";
                    player2Score -= 20;
                    lblScore2.Text = player2Score.ToString();

                }else if(player2Choice == "paper2")
                {
                    lblGameStatus.Text = lblName1.Text + " Won" + "\n" + lblName2.Text + " Lost";
                    player2Score -= 20;
                    lblScore2.Text = player2Score.ToString();
                }
                else
                {
                    lblGameStatus.Text = "Its a Draw";
                }
            }

            if (player1Score == 0)
            {
                MessageBox.Show("Player 2 Won");
                lblGameStatus.Text = lblName2.Text + " Won";

                if(player1Score < player2Score)
                {
                    playerScore = player2Score;
                    playerWinner = lblName2.Text;
                }

                con = "Server=localhost;Database=db_playerdata;User=root;Password=;";
                MySqlConnection connection = new MySqlConnection(con);
                connection.Open();
                
                MySqlCommand command2 = connection.CreateCommand();
                command2.Connection = connection;
                try

                {
                    command2.CommandText = "INSERT INTO tbl_playerdata VALUES ('" + lblName2.Text + "'," + playerScore + ", '" + lblGameStatus.Text + "')";
                    command2.ExecuteNonQuery();


                }
                catch (Exception z)
                {
                    MessageBox.Show(z.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }

            }else if(player2Score == 0) {


                MessageBox.Show("Player 1 Won");
                lblGameStatus.Text = lblName1.Text + " Won";

                if (player1Score > player2Score)
                {
                    playerScore = player1Score;
                   
                }


                con = "Server=localhost;Database=db_playerdata;User=root;Password=;";
                MySqlConnection connection = new MySqlConnection(con);
                connection.Open();
                MySqlCommand command1 = connection.CreateCommand();
                command1.Connection = connection;
                
                try

                {
                    command1.CommandText = "INSERT INTO tbl_playerdata VALUES ('" + lblName1.Text + "'," + playerScore + ", '" + lblGameStatus.Text + "')";
                    command1.ExecuteNonQuery();
                    

                }
                catch (Exception z)
                {
                    MessageBox.Show(z.Message);
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

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
            
        }
 

