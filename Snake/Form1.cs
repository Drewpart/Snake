using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Snake
{
    public partial class Form1 : Form
    {
        Rectangle player1 = new Rectangle(360, 120, 20, 20);
        Rectangle ball = new Rectangle(295, 195, 15, 15);
        Rectangle speed = new Rectangle(170, 200, 10, 10);
        Rectangle wall1 = new Rectangle(350, 295, 75, 30);
        Rectangle wall2 = new Rectangle(75, 100, 30, 75);
        Rectangle wall3 = new Rectangle(85, 350, 30, 70);

        int player1Score = 0;
        int player2Score = 0;

        int playerSpeed2 = 2;
        int playerSpeed1 = 2;
        int ballSpot;
        int speedSpot;

        bool wDown = false;
        bool sDown = false;
        bool aDown = false;
        bool dDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool leftArrow = false;
        bool rightArrow = false;

        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush RedBrush = new SolidBrush(Color.Red);
        SolidBrush SolidBrush = new SolidBrush(Color.Orange);
        SolidBrush YellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush violetBrush = new SolidBrush(Color.BlueViolet);

        Random ballLoca = new Random();
        Random speedMvmt = new Random();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (wDown == true && player1.Y > 0)
            {
                player1.Y -= playerSpeed1;
            }

            if (sDown == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y += playerSpeed1;
            }
            if (aDown == true && player1.X > 0)
            {
                player1.X -= playerSpeed1;
            }
            if (dDown == true && player1.X < this.Height - player1.Height)
            {
                player1.X += playerSpeed1;

            }

            // intercecting

            if (player1.IntersectsWith(ball))
            {
                playerSpeed1++;
                ballSpot = ballLoca.Next(1, 11);


                if (ballSpot == 1)
                {
                    ball.X = 120;
                    ball.Y = 215;
                }
                else if (ballSpot == 2)
                {
                    ball.X = 62;
                    ball.Y = 234;
                }
                else if (ballSpot == 3)
                {
                    ball.X = 292;
                    ball.Y = 150;
                }
                else if (ballSpot == 4)
                {
                    ball.X = 76;
                    ball.Y = 203;
                }
                else if (ballSpot == 5)
                {
                    speed.X = 100;
                    speed.Y = 265;
                }
                else if (ballSpot == 6)
                {
                    ball.X = 154;
                    ball.Y = 213;
                }
                else if (ballSpot == 7)
                {
                    ball.X = 199;
                    ball.Y = 199;
                }
                else if (ballSpot == 8)
                {
                    ball.X = 34;
                    ball.Y = 342;
                }
                else if (ballSpot == 9)
                {
                    ball.X = 345;
                    ball.Y = 355;
                }
                else if (ballSpot == 10)
                {
                    ball.X = 23;
                    ball.Y = 27;
                }
            }
            if(player1.IntersectsWith(wall1))
            {
                Thread.Sleep(10000);
                // switch too end screen

            }
            if (player1.IntersectsWith(wall2))
            {
                Thread.Sleep(10000);
                // switch too end screen

            }
            if (player1.IntersectsWith(wall3))
            {
                Thread.Sleep(10000);
                // switch too end screen

            }
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(SolidBrush, player1);
            e.Graphics.FillRectangle(RedBrush, ball);
            e.Graphics.FillRectangle(violetBrush, wall1);
            e.Graphics.FillRectangle(violetBrush, wall2);
            e.Graphics.FillRectangle(violetBrush, wall3);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftArrow = true;
                    break;
                case Keys.Right:
                    rightArrow = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Left:
                    leftArrow = false;
                    break;
                case Keys.Right:
                    rightArrow = false;
                    break;
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
            }
        }
    }
}

