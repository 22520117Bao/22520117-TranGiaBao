using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_22520117
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public bool isnum(string pText)
        {
            Regex reg = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$"); //  kiem tra chuoi co phai so nguyen khong
            return reg.IsMatch(pText);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;
            if (isnum(txtnhat.Text) == true && isnum(txthai.Text) == true)
            {
                num1 = Int32.Parse(txtnhat.Text.Trim());
                num2 = Int32.Parse(txthai.Text.Trim());
                sum = num1 + num2;
            }
            else
            {
                sum = 0 ;
                MessageBox.Show("ko phai so nguyen", "Thong bao", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
                textBox3.Text = sum.ToString();
        }

        private void txtnhat_TextChanged(object sender, EventArgs e)
        {
            if (isnum(txtnhat.Text) == false)
            {
                MessageBox.Show("ko phai so nguyen", "Thong bao", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                txtnhat.Text = "";
            }
            
        }

        private void txthai_TextChanged(object sender, EventArgs e)
        {
            if (isnum(txthai.Text) == false)
            {
                MessageBox.Show("ko phai so nguyen", "Thong bao", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                txthai.Text = "";
            }
        }
    }
}
