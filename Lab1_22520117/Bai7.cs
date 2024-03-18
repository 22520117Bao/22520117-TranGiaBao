using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_22520117
{
    public partial class Bai7 : Form
    {
        string[] a = new string[100];
        int n= 0;
        public Bai7()
        {
            InitializeComponent();
        }
        public bool isnum(string pText)
        {
            Regex reg = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$"); //  kiem tra chuoi co phai so nguyen khong
            return reg.IsMatch(pText);
        }
        public String InMang()
        {
            String chuoi = "  ";
            for (int i = 1; i<n;i++ )
            {
                chuoi += "Mon "+ i + ":  "+a[i] + "  "; 
            }
            return chuoi;
        }
        
        public double Timmax()
        {
            double ma = double.MinValue;
            for(int i  =1;i<n;i++)
            {
                if(ma < double.Parse(a[i]) )
                {
                    ma = double.Parse(a[i]);
                }
            }
            return ma;
        }
        public double Timmin()
        {
            double mi = double.MaxValue;
            for (int i = 1; i < n; i++)
            {
                if (mi > double.Parse(a[i]))
                {
                    mi = double.Parse(a[i]);
                }
            }
            return mi;
        }
        public double Trungbinhdiem()
        {
            double sum = 0;
            double tb = 0;
            for (int i = 1; i < n; i++)
            {
                sum += double.Parse(a[i]);
            }
            tb = (double)sum / (double)n;
            return tb;

        }
        public int Somondau()
        {
            int d = 0;
            for (int i  =1;i<n;i++)
            {
                if (double.Parse(a[i]) >= 5.0f)
                    {
                    d++;

                }
            }
            return d;
        }
        public int Somonkodau()
        {
            int kd = 0;
            for (int i = 1; i < n; i++)
            {
                if (double.Parse(a[i]) < 5.0f)
                {
                    kd++;
                }
            }
            return kd;
        }
        public String Hocluc()
        {
            String hocluc = "  ";
            if(Trungbinhdiem() >= 8 && Timmin() <6.5f )
            {
                hocluc = "Gioi ";
            }
            else if( Trungbinhdiem() >=6.5f && Timmin() < 5)
            {
                hocluc = "Kha ";
            }
            else if (Trungbinhdiem() >= 5 && Timmin() < 3.5f)
            {
                hocluc = "TB ";
            }
            else if (Trungbinhdiem() >= 3.5f && Timmin() < 2)
            {
                hocluc = "Yeu ";
            }
            else 
            {
                hocluc = "Kem  ";
            }
            return hocluc;
        }

        private void txta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btadd_Click(object sender, EventArgs e)
        {
            if (this.n == a.Length)
            {
                MessageBox.Show("Mang da day", "Thong bao");
            }
            else
            {
                if (n == 0)
                {
                    if (isnum(this.txta.Text) == true)
                    {
                        MessageBox.Show("Ban phai nhap dung ten", "Thong bao");
                        this.txta.Clear();
                        this.txta.Focus();

                    }
                }
                
                
                    a[n]  = this.txta.Text;
                    n++;
                    this.lbnhap .Text += this.txta.Text+" , ";
                    this.txta.Clear ();
                    this.txta.Focus();
                
            }

        }
        private void btnhap_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                MessageBox.Show("Mang rong", "Thong bao");
                this.txta.Focus();
            }
            else
            {
                lbkq.Text = " Họ và tên: " + a[0] + "\n\n" + InMang()
                            + "\n\n" + "  Trung bình: " + Trungbinhdiem()
                            + "\n\n" + "  Điẻm cao nhất: " + Timmax()
                            + "\t\t" + " Điểm thấp nhất: " + Timmin()
                            +  "\n\n"+ "  Số môn đậu:     "+ Somondau()
                            + "\t\t"+ "  Số môn không đậu: "+Somonkodau() 
                            +"\n\n" + "  học lực:   " + Hocluc();
            }


        }

        private void btInmang_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                MessageBox.Show("Mang rong", "Thong bao");
                this.txta.Focus ();
            }
            else
            {
                lbkq.Text = "Ho ten: " + a[0] + "\n" + InMang();
            }
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            this.txta.Clear();
            a = new string[100];
            n = 0;
            lbnhap.Text = "";
            lbkq.Text = "";
        }

        private void lbnhap_Click(object sender, EventArgs e)
        {

        }
    }
}
