using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catch_the_Kardashian
{
    public partial class FrmAlien : Form
    {
        Rectangle alienRec = new Rectangle(0, 0, 50, 65);
        Image alien = Image.FromFile(Application.StartupPath + @"\Kim.png");
        Graphics g;
        int score;
        int count = 45;
        public FrmAlien()
        {
            InitializeComponent();
        }

        private void FrmAlien_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Try and click on the Kardashian as fast as you can with the mouse. This will increase your score. Attempt to get 80 in 20 seconds. You must clikc start for it to start. ", "Game Instructions");
            TxtName.Focus();
            MnuStart.Enabled = false;
            TmrCountdown.Enabled = false;

        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;// sets g to the Graphics object supplied in the PaintEventArgs
            //set the x and y positions of alienRec
            Random rand = new Random();

            alienRec.X = rand.Next(240);
            alienRec.Y = rand.Next(240);
            //draw the alien image randomly on the panel

            g.DrawImage(alien, alienRec);

        }

        private void TmrAlien_Tick(object sender, EventArgs e)
        {
            PnlGame.Invalidate();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmAlien_MouseDown(object sender, MouseEventArgs e)
        {


        }

        private void PnlGame_MouseDown(object sender, MouseEventArgs e)
        {
            int diffX = e.X - alienRec.X;
            int diffY = e.Y - alienRec.Y;
            double length = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));
            if (length < 70)
            {
                score++;//add 1 to the score
                LblScore.Text = score.ToString();// display the score
            }
            if (score == 20)
            {
               TmrAlien.Interval -= 100;
               label5.ForeColor = System.Drawing.Color.Green;
            }
            if (score == 40)
            {
                TmrAlien.Interval -= 80;
                label6.ForeColor = System.Drawing.Color.Green;
            }
            if (score == 60)
            {
                TmrAlien.Interval -= 60;
                label7.ForeColor = System.Drawing.Color.Green;
            }
            if (score == 80)
            {
                TmrAlien.Interval -= 40;
                label8.ForeColor = System.Drawing.Color.Green;
            }
            if (score == 100)
            {
                TmrAlien.Interval -= 10;
                label9.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void MnuStart_Click(object sender, EventArgs e)
        {
            score = 0;
            TmrAlien.Start(); //start the timer
            TmrCountdown.Start();
        }

        private void MnuQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();//ends the program
        }

        private void TmrCountdown_Tick(object sender, EventArgs e)
        {
            count--;//decrease count by 1
            LblTime.Text = count.ToString();//display count in LblTime

            if (count == 0)
            {

                TmrCountdown.Stop();
                TmrAlien.Stop();
                LblScore.Enabled = false;
                LblTime.Enabled = false;
                MessageBox.Show("Game Over!");
               
            }
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            string context = TxtName.Text;
            bool isletter = true;
            //for loop checks for letters as characters are entered
            for (int i = 0; i < context.Length; i++)
            {
                if (!char.IsLetter(context[i]))// if current character not a letter
                {
                    isletter = false;//make isletter false
                    break; // exit the for loop
                }

            }

            // if not a letter clear the textbox and focus on it
            // to enter name again
            if (isletter == false)
            {
                TxtName.Clear();
                TxtName.Focus();
            }
            else
            {
                MnuStart.Enabled = true;
            }

        }
    }
}


fgfgfgfgf