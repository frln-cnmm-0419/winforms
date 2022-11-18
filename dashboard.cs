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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void fILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pAYMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment_Form pf = new Payment_Form();
            pf.Show();
            this.Hide();
        }

        private void sTUDENTREGISTRATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Information si = new Student_Information();
            si.Show();
            this.Hide();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login loginfrm = new login();
            loginfrm.Show();
            this.Close();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }


    }
}
