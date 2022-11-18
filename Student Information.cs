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
    public partial class Student_Information : Form
    {
        String year;
        public Student_Information()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                year = "1st YR";
            }

            else if (radioButton2.Checked)
            {
                year = "4th YR";
            }

            else if (radioButton3.Checked)
            {
                year = "3rd YR";
            }

            else if (radioButton4.Checked)
            {
                year = "2nd YR";
            }

            else if (radioButton5.Checked)
            {
                year = "9th YR";
            }

            else if (radioButton6.Checked)
            {
                year = "6th YR";
            }

            else if (radioButton7.Checked)
            {
                year = "7th YR";
            }

            else if (radioButton8.Checked)
            {
                year = "6th YR";
            }

            else if (radioButton9.Checked)
            {
                year = "4th YR";
            }

            else if (radioButton10.Checked)
            {
                year = "5th YR";
            }
            if ((textBox1.Text == "") && (textBox3.Text == "") && (textBox2.Text == "") && (year == "") && (comboBox1.SelectedIndex == -1) && ((radioButton1.Checked) || (radioButton2.Checked) || (radioButton3.Checked) || (radioButton4.Checked) || (radioButton5.Checked) || (radioButton6.Checked) || (radioButton7.Checked) || (radioButton8.Checked) || (radioButton9.Checked) || (radioButton10.Checked)) && (listBox1.SelectedIndex == -1))
            {
                MessageBox.Show("PLEASE FILL ALL THE FIELDS", "WARNING");
            } else
            {
                MessageBox.Show("Success! Here's what we got from you." + "\n"
                                + "Full Name: " + textBox1.Text + ",  "+ textBox3.Text + ",  " + textBox2.Text + "\n"
                                + "Course: " + comboBox1.SelectedItem + "\n"
                                + "Year Level: " + year + "\n"
                                + "Section: " + listBox1.SelectedItem + "\n", "INFO!");
            }
            
        }
    }
}
