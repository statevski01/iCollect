using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCollect
{
    public partial class Form1 : Form
    {
        bool left, right, up, down, isGameOver;
        int score, directionPlayer, directionCandy, directionChocolateX, directionChocolateY;

        public Form1()
        {
            InitializeComponent();
            resetGame();
        }

        private void runTime(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;

            // Moving the player

            if (left == true)
                Player.Left -= directionPlayer;

            if (right == true)
                Player.Left += directionPlayer;

            if (up == true)
                Player.Top -= directionPlayer;

            if (down == true)
                Player.Top += directionPlayer;

            // Teleporting the player across frames

            if (Player.Left < 0)
                Player.Left = 520;

            if (Player.Left > 520)
                Player.Left = 0;

            if (Player.Top < 0)
                Player.Top = 470;

            if (Player.Top > 470)
                Player.Top = 0;
        
            // Player contact with fruit, walls and sugar
        
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "fruit")
                    {
                        if (Player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            x.Visible = false;
                            score++;
                        }
                    }

                    if ((string)x.Tag == "wall")
                    {
                        if (Player.Bounds.IntersectsWith(x.Bounds))
                            gameOver("You lost!");

                        // Bouncing chocolate off the walls

                        if (Chocolate.Bounds.IntersectsWith(x.Bounds))
                            directionChocolateX = -directionChocolateX;
                    }

                    if ((string)x.Tag == "sugar")
                        if (Player.Bounds.IntersectsWith(x.Bounds))
                            gameOver("You lost!");
                }
            }

            if (score == 6)
                gameOver("You won!");

            // Moving the candy and bouncing it off the walls

            Candy.Left += directionCandy;

            if (Candy.Bounds.IntersectsWith(Wall1.Bounds) || Candy.Bounds.IntersectsWith(Wall2.Bounds))
                directionCandy = -directionCandy;

            // Moving chocolate and bouncing it off the frames

            Chocolate.Left += directionChocolateX;
            Chocolate.Top -= directionChocolateY;

            if (Chocolate.Left < 0 || Chocolate.Left > 470)
                directionChocolateX = -directionChocolateX;

            if (Chocolate.Top < 0 || Chocolate.Top > 480)
                directionChocolateY = -directionChocolateY;
        }

        private void pressedKey(object sender, KeyEventArgs e)
        {
            // Moving the player

            if (e.KeyCode == Keys.Left)
                left = true;

            if (e.KeyCode == Keys.Right)
                right = true;

            if (e.KeyCode == Keys.Up)
                up = true;

            if (e.KeyCode == Keys.Down)
                down = true;
        }

        private void releasedKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                left = false;

            if (e.KeyCode == Keys.Right)
                right = false;

            if (e.KeyCode == Keys.Up)
                up = false;

            if (e.KeyCode == Keys.Down)
                down = false;

            if (e.KeyCode == Keys.Enter && isGameOver == true)
                resetGame();
        }

        private void resetGame()
        {
            score = 0;
            txtScore.Text = "Score: " + score;

            isGameOver = false;

            // Setting the direction of objects

            directionPlayer = 8;
            directionCandy = 5;
            directionChocolateX = 5;
            directionChocolateY = 5;

            // Setting the location of objects

            Player.Left = 31;
            Player.Top = 109;

            Candy.Left = 264;
            Candy.Top = 63;

            Chocolate.Left = 200;
            Chocolate.Top = 254;

            // All picked fruit is made visible again

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "fruit")
                    x.Visible = true;
            }

            gameTimer.Start();
        }

        private void gameOver(string message)
        {
            gameTimer.Stop();
            isGameOver = true;
            txtScore.Text = "Score: " + score + Environment.NewLine + message;
        }
    }
}
