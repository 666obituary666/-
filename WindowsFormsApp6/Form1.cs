using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "-";
            double a = Convert.ToDouble(textBox2.Text);
            double b = Convert.ToDouble(textBox1.Text);
            double v = a - b;
            textBox3.Text = v.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "+";
            double a = Convert.ToDouble(textBox2.Text);
            double b = Convert.ToDouble(textBox1.Text);
            double s = a + b;
            textBox3.Text = s.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                MessageBox.Show("делить на ноль нельзя");
                textBox3.Text = "";
            }
            label1.Text = "/";
            double a = Convert.ToDouble(textBox2.Text);
            double b = Convert.ToDouble(textBox1.Text);
            double d = a / b;
            textBox3.Text = d.ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "*";
            double a = Convert.ToDouble(textBox2.Text);
            double b = Convert.ToDouble(textBox1.Text);
            double u = a * b;
            textBox3.Text = u.ToString();
        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char bukva = e.KeyChar;
            if(!char.IsDigit(bukva) && bukva != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char bukva = e.KeyChar;
            if (!char.IsDigit(bukva) && bukva != 8)
            {
                e.Handled = true;
            }
        }

   

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char bukva = e.KeyChar;
            if (!char.IsDigit(bukva) && bukva != 8)
            {
                e.Handled = true;
            }
        }
    }
}
