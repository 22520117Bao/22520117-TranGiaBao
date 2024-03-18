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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void bttinh_Click(object sender, EventArgs e)
        {
            int t = 0;
            int n = 0;
            double s = 0;
            int t1 = int.Parse(txta.Text);
            int t2 = int.Parse(txtb.Text);
            int a = 0;
            if (cb1.SelectedItem == "Bảng cửu chương") 
            {
                t = t2 - t1;
                if(t < 0)
                {
                    t = 0 - t;
                }
                lbkq.Text =  $"{t}  *  1  = {t * 1}\n" +
                             $"{t}  *  2  = {t * 2}\n" +
                             $"{t}  *  3  = {t * 3}\n" +
                             $"{t}  *  4  = {t * 4}\n" +
                             $"{t}  *  5  = {t * 5}\n" +
                             $"{t}  *  6  = {t * 6}\n" +
                             $"{t}  *  7  = {t * 7}\n" +
                             $"{t}  *  8  = {t * 8}\n" +
                             $"{t}  *  9  = {t * 9}\n" +
                             $"{t}  *  10 = {t * 10}\n";
                            


            }
            else 
            {
                n = t1 - t2;
                for (int i = 1; i<= n;i++)
                {
                    n = n * i;
                }
                for  (int i = 1;i<= t2;i++)
                {
                    s = s + Math.Pow(t1, i);
                }
                lbkq.Text = "(A – B)! =  " + n+ "\n"
                            + "Tổng S = A^1 + A^2 + A^3 + A^4 + … + A^B =  "+ s;

            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            txta.Text ="";
            txtb.Text = "";
            lbkq.Text = "";
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
