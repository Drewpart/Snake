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
       
        public Form1()
        {
            InitializeComponent();
            gameScreen gs = new gameScreen();

            this.Controls.Add(gs);

            gs.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
           
        }
    }
}

