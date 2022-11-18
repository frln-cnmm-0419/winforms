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
    public partial class Payment_Form : Form
    {
        private int base_price, quant, total, money, change, grnd_total;
        public Payment_Form()
        {
            InitializeComponent();
        }

        private void Payment_Form_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            label5.Text = listBox1.Text;
            if (listBox1.SelectedIndex == 0)
            {
                base_price = 1000;
                label15.Text = Convert.ToString(base_price);
            }

            else if (listBox1.SelectedIndex == 1)
            {
                base_price = 200;
                label15.Text = Convert.ToString(base_price);
            }

            else if (listBox1.SelectedIndex == 2)
            {
                base_price = 500;
                label15.Text = Convert.ToString(base_price);
            }

            else if (listBox1.SelectedIndex == 3)
            {
                base_price = 450;
                label15.Text = Convert.ToString(base_price);
            }

            else if (listBox1.SelectedIndex == 4)
            {
                base_price = 800;
                label15.Text = Convert.ToString(base_price);
            }

            else if (listBox1.SelectedIndex == 5)
            {
                base_price = 1500;
                label15.Text = Convert.ToString(base_price);
            }
        }

        private void  button3_Click(object sender, System.EventArgs e)
        {
            String quantText = Convert.ToString(textBox2.Text);
            quant = Convert.ToInt32(textBox2.Text);
            try
            {
                label14.Text = Convert.ToString(base_price * quant);
                total = base_price * quant;
            } catch
            {
                MessageBox.Show("Please Input a valid quantity.", "WARNING!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem + "  " + "QTY " + Convert.ToString(quant) + "  " + "PRC/QTY " + Convert.ToString(base_price));
            grnd_total += total;
            label3.Text = Convert.ToString(grnd_total);
            total = 0;
            base_price = 0;
            quant = 0;
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please put a valid amount", "INFO");
            } else
            {
                if (Convert.ToInt32(textBox1.Text) < grnd_total)
                {
                    MessageBox.Show("Please enter a higher amount than your due.", "NOTICE!");
                } else
                {
                    money = Convert.ToInt32(textBox1.Text);
                    change = money - grnd_total;
                    label16.Text = Convert.ToString(change);
                    label13.Text = textBox1.Text;
                }
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OFFICIAL RECEIPT will be printed one by one.");
            for (int i = 0; i < listBox2.Items.Count; i++) {
                MessageBox.Show(listBox2.Items[i].ToString());
            }
            
        }
    }
}
