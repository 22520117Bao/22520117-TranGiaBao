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
    public partial class Tongduyet : Form
    {
        public Tongduyet()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form f7 = new Bai7();
            f7.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f1 = new Bai1();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f2 = new Bai2();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f3 = new Bai3();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f4 = new Bai4();
            f4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f5 = new Bai5();
            f5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form f6 = new Bai6();
            f6.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form f8 = new Bai8();
            f8.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form f3_1 = new Bai3_1();
            f3_1.Show();
        }
    }
}
