using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1_22520117
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int t;
            Console.WriteLine(textBox1.Text);
            t = int.Parse(textBox1.Text);
            if (t < 0 || t > 9)
            {
                MessageBox.Show("Vui lòng nhập đúng số 0 đến 9", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                textBox1.Text = "";
            }
            switch (t)
            {
                case 0:
                    textBox2.Text = "không";
                    break;
                case 1:
                    textBox2.Text = "một";
                    break;
                case 2:
                    textBox2.Text = "hai";
                    break;
                case 3:
                    textBox2.Text = "ba";
                    break;
                case 4:
                    textBox2.Text = "bốn";
                    break;
                case 5:
                    textBox2.Text = "năm";
                    break;
                case 6:
                    textBox2.Text = "sáu";
                    break;
                case 7:
                    textBox2.Text = "bảy";
                    break;
                case 8:
                    textBox2.Text = "tám";
                    break;
                case 9:
                    textBox2.Text = "chín";
                    break;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           

            
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
