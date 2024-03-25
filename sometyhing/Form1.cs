using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sometyhing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Random rand = new Random(DateTime.Now.Millisecond);

        int num;
        int num2;
        int num3;
        int score = 0;
        int time = 20; 

        private void startBtn_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            startBtn.Visible = false;


            Game();
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timeTB.Text = time.ToString();
        }
        private void Game()
        {
            scoreTB.Text = score.ToString();

            num = rand.Next(0, 10);
            

            if (num == 0)
            {
                button1.BackColor = Color.Black;
            }
            else if (num == 1)
            {
                button2.BackColor = Color.Black;
            }
            else if (num == 2)
            {
                button3.BackColor = Color.Black;
            }
            else if (num == 3)
            {
                button4.BackColor = Color.Black;
            }
            else if (num == 4)
            {
                button5.BackColor = Color.Black;
            }
            else if (num == 5)
            {
                button4.BackColor = Color.Black;
            }
            else if (num == 6)
            {
                button5.BackColor = Color.Black;
            }
            else if (num == 7)
            {
                button6.BackColor = Color.Black;
            }
            else if (num == 8)
            {
                button7.BackColor = Color.Black;
            }
            else if (num == 9)
            {
                button8.BackColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.Black)
            {
                
                score += 1;
            }
            else
            {
                score -= 1;
            }
            Game();
            button1.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (button2.BackColor == Color.Black)
            {
                
                score += 1;
            }
            else
            {
                score -= 1;
            }
            Game();
            button2.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.Black)
            {
                
                score += 1;
            }
            else
            {
                score -= 1;
            }
            Game();
            button3.BackColor = Color.White;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor == Color.Black)
            {
                
                score += 1;
            }
            else
            {
                score -= 1;
            }
            Game();
            button6.BackColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.Black)
            {
                
                score += 1;
            }
            else
            {
                score -= 1;
            }
            Game();
            button5.BackColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.Black)
            {
                
                score += 1;
            }
            else
            {
                score -= 1;
            }
            Game();
            button4.BackColor = Color.White;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == Color.Black)
            {
                
                score += 1;
            }
            else
            {
                score -= 1;
            }
            Game();
            button9.BackColor = Color.White;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == Color.Black)
            {
                
                score += 1;
            }
            else
            {
                score -= 1;
            }
            Game();
            button8.BackColor = Color.White;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == Color.Black)
            {
                
                score += 1;
            }
            else
            {
                score -= 1;
            }
            Game();
            button7.BackColor = Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            num2 = rand.Next(0, 10);

            if (num2 == 0)
            {
                button1.BackColor = Color.Black;
            }
            else if (num2 == 1)
            {
                button2.BackColor = Color.Black;
            }
            else if (num2 == 2)
            {
                button3.BackColor = Color.Black;
            }
            else if (num2 == 3)
            {
                button4.BackColor = Color.Black;
            }
            else if (num2 == 4)
            {
                button5.BackColor = Color.Black;
            }
            else if (num2 == 5)
            {
                button4.BackColor = Color.Black;
            }
            else if (num2 == 6)
            {
                button5.BackColor = Color.Black;
            }
            else if (num2 == 7)
            {
                button6.BackColor = Color.Black;
            }
            else if (num2 == 8)
            {
                button7.BackColor = Color.Black;
            }
            else if (num2 == 9)
            {
                button8.BackColor = Color.Black;
            }

        }



        private void timer2_Tick(object sender, EventArgs e)
        {

            if (time != 0)
            {
                time -= 1;
                timeTB.Text = time.ToString();
            }
            else
                
            {
                timer2.Stop();
                timer1.Stop();
                timer3.Stop();
                MessageBox.Show("game over, you scored " + score.ToString() + " points");
                startBtn.Visible = true;

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;

                score = 0;
                time = 20;
                scoreTB.Text = score.ToString();
                timeTB.Text = time.ToString();
                startBtn.Text = "restart";
            }
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            num3 = rand.Next(0, 10);


            if (num3 == 0 && button1.BackColor == Color.Black)
            {
                button1.BackColor = Color.White;
            }
            else if (num3 == 1 && button2.BackColor == Color.Black)
            {
                button2.BackColor = Color.White;
            }
            else if (num3 == 2 && button3.BackColor == Color.Black)
            {
                button3.BackColor = Color.White;
            }
            else if (num3 == 3 && button4.BackColor == Color.Black)
            {
                button4.BackColor = Color.White;
            }
            else if (num3 == 4 && button5.BackColor == Color.Black)
            {
                button5.BackColor = Color.White;
            }
            else if (num3 == 5 && button6.BackColor == Color.Black)
            {
                button6.BackColor = Color.White;
            }
            else if (num3 == 6 && button7.BackColor == Color.Black)
            {
                button5.BackColor = Color.White;
            }
            else if (num3 == 7 && button8.BackColor == Color.Black)
            {
                button6.BackColor = Color.White;
            }
            else if (num3 == 8 && button7.BackColor == Color.Black)
            {
                button7.BackColor = Color.White;
            }
            else if (num3 == 9 && button9.BackColor == Color.Black)
            {
                button8.BackColor = Color.White;
            }
        }




        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
