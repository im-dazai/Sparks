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
    public partial class Sparks_Login : Form
    {
        public Sparks_Login()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "test" || txtUser.Text == "TEST" && txtPassword.Text == "test2022" || txtPassword.Text == "TEST2022") {
                this.Hide();
                Sparks frm = new Sparks();
                frm.Show();
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.PasswordChar = ('*');

        }
    }
}
