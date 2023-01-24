using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class EndingScreen : UserControl
    {
        public EndingScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();

            f.Controls.Remove(this);

            gameScreen gs = new gameScreen();

            f.Controls.Add(gs);
            gs.Focus();
        }
    }
}
