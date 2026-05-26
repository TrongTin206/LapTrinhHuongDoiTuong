using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lab5_6
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 10;
        int gravity = 4;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            int khoangCach = 200;
            scoreText.Text = "Score: " + score;
            if (pipeBottom.Left < -100)
            {
                pipeBottom.Left = pipeTop.Left + khoangCach;
                score++;
            }
            if (pipeTop.Left < -100)
            {
                pipeTop.Left = pipeBottom.Left + khoangCach;
                score++;
            }
            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }
            if (score > 5)
            {
                pipeSpeed = 10;
            }
            if (flappyBird.Top < -2500)
            {
                endGame();
            }
        }
        private void Form1_InputLanguageChanging(object sender, InputLanguageChangingEventArgs e)
        {

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }
        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game Over!!!";
        }
        private void flappybird_Click(object sender, EventArgs e)
        {
        }
    }
}
