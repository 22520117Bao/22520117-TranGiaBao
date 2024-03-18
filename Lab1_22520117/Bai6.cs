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
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btzodiac_Click(object sender, EventArgs e)
        {
            int day = int.Parse(txtd.Text);
            int month = int.Parse(txtm.Text);
            int year = int.Parse(txty.Text);
            string a = "";
            switch (month)
            {
                case 3:
                    if (day >= 1 && day <= 20)
                    {
                        a = "cung Song Ngư";
                        break;
                    }
                    if (day >= 21 && day <= 31)
                    {
                        a = "cung Bạch Dương";
                        break;
                    }
                    else 
                        goto case 4;
                case 4:
                    if (day >= 1 && day <= 20)
                    {
                        a = "cung Bạch Dương";
                        break;
                    }
                    if (day >= 21 && day <= 30)
                    {
                        a = "cung Kim Ngưu";
                        break;
                    }
                    else
                        goto case 5;
                case 5:
                    if (day >= 1 && day <= 21)
                    {
                        a = "cung Kim Ngưu";
                        break;
                    }
                    if (day >= 22 && day <= 31)
                    {
                        a = "cung Song Tử";
                        break;
                    }
                    else
                    goto case 6;
                case 6:
                    if (day >= 1 && day <= 21)
                    {
                        a = "cung Song Tử";
                        break;
                    }
                    if (day >= 22 && day <= 30)
                    {
                        a = "cung Cự Giải";
                        break;
                    }
                    else
                        goto case 7;
                case 7:
                    if (day >= 1 && day <= 22)
                    {
                        a = "cung Cự Giải";
                        break;
                    }
                    if (day >= 23 && day <= 31)
                    {
                        a = "cung Sư Tử";
                        break;
                    }
                    else
                    goto case 8;
                case 8:
                    if (day >= 1 && day <= 22)
                    {
                        a = "cung Sư Tử";
                        break;
                    }
                    if (day >= 23 && day <= 31)
                    {
                        a = "cung Xử Nữ";
                        break;
                    }
                    else
                    goto case 9;
                case 9:
                    if (day >= 1 && day <= 23)
                    {
                        a = "cung Xử Nữ";
                        break;
                    }
                    if (day >= 24 && day <= 30)
                    {
                        a = "cung Thiên Bình";
                        break;
                    }
                    else
                    goto case 10;
                case 10:
                    if (day >= 1 && day <= 23)
                    {
                        a = "cung Thiên Bình";
                        break;
                    }
                    if (day >= 24 && day <= 31)
                    {
                        a = "cung Thần Nông";
                        break;
                    }
                    else
                    goto case 11;
                case 11:
                    if (day >= 1 && day <= 22)
                    {
                        a = "cung Thần Nông";
                        break;
                    }
                    if (day >= 23 && day <= 30)
                    {
                        a = "cung Nhân Mã";
                        break;
                    }
                    else
                    goto case 12;
                case 12:
                    if (day >= 1 && day <= 21)
                    {
                        a = "cung Nhân Mã";
                        break;
                    }
                    if (day >= 22 && day <= 31)
                    {
                        a = "cung Ma Kết";
                        break;
                    }
                    else
                        goto case 1;
                case 1:
                    if (day >= 1 && day <= 20)
                    {
                        a = "cung Ma Kết";
                        break;
                    }
                    if (day >= 21 && day <= 31)
                    {
                        a = "cung Bảo Bình";
                        break;
                    }
                    else
                        goto case 2;
                case 2:
                    if (day >= 1 && day <= 19)
                    {
                        a = "cung Bảo Bình";
                        break;
                    }
                    if(day >= 20 && day<= 29)
                    {
                        a = "cung Song Ngư";
                        break;
                    }
                    goto case 3;
                

            }
            txtzodiac.Text = a;


        }

        private void txtd_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
