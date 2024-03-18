using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_22520117
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;
            double ln = 0;
            double nh = 0;
            num1 = Double.Parse(textBox1.Text.Trim());
            num2 = Double.Parse(textBox2.Text.Trim());
            num3 = Double.Parse(textBox3.Text.Trim());
            if (num1 > num2 && num1 > num3)
            {
                ln = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                ln = num2;
            }
            else
            {
                ln = num3;
            }
            if (num1 < num2 && num1 < num3)
            {
                nh = num1;
            }
            else if (num2 < num1 && num2 < num3)
            {
                nh = num2;
            }
            else
            {
                nh = num3;
            }
            textBox6.Text = ln.ToString();
            textBox7.Text = nh.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
