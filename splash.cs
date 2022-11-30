using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sparks
{
    public partial class Sparks_Splash : Form
    {
        public Sparks_Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 700) {
                timer1.Stop();
                Sparks_Login frm2 = new Sparks_Login();
                frm2.Show();
                this.Hide();
            }

        }
    }
}
