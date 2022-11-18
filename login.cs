using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (((username.Text == "admin") && (password.Text == "123")) || ((username.Text == "user") && (password.Text == "pass")) || ((username.Text == "administrator") && (password.Text == "adminpass")))
            {
                this.Hide();
                dashboard main = new dashboard();
                main.Show();
            }
            else if ((username.Text == "") && (password.Text == ""))
            {
                MessageBox.Show("Username and Password can't be empty", "WARNING!");
                username.Text = "";
                password.Text = "";
                username.Focus();
            }
            else
            {
                MessageBox.Show("Wrong Username and Password", "WARNING!");
                username.Text = "";
                password.Text = "";
                username.Focus();
            }
        }
    }
}
