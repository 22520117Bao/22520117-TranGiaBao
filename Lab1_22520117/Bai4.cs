using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_22520117
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
     
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (cbphim.SelectedItem == "Đào, phở và piano")
            {
               
                if (cbve.SelectedItem == "vé vớt")
                {
                    ckseet.Items.Clear();
                    ckseet.Items.AddRange(new string[] { "1-A1", "1-A5", "1-C1", "1-C5", "2-A1", "2-A5", "2-C1", "2-C5", "3-A1", "3-A5", "3-C1", "3-C5" });
                }
                else if (cbve.SelectedItem == "vé thường")
                {
                    ckseet.Items.Clear();
                    ckseet.Items.AddRange(new string[] { "1-A2", "1-A3", "1-A4", "1-C2", "1-C3", "1-C4", "2-A2", "2-A3", "2-A4", "2-C2", "2-C3", "2-C4", "3-A2", "3-A3", "3-A4", "3-C2", "3-C3", "3-C4" });
                }
                else
                {
                    ckseet.Items.Clear();
                    ckseet.Items.AddRange(new string[] { "1-B2", "1-B3", "1-B4", "2-B2", "2-B3", "2-B4", "3-B2", "3-B3", "3-B4" });
                }
            }
            if (cbphim.SelectedItem == "Mai")
            {
                if (cbve.SelectedItem == "vé vớt")
                {
                    ckseet.Items.Clear();
                    ckseet.Items.AddRange(new string[] {  "2-A1", "2-A5", "2-C1", "2-C5", "3-A1", "3-A5", "3-C1", "3-C5" });
                }
                else if (cbve.SelectedItem == "vé thường")
                {

                    ckseet.Items.Clear();
                    ckseet.Items.AddRange(new string[] {  "2-A2", "2-A3", "2-A4", "2-C2", "2-C3", "2-C4", "3-A2", "3-A3", "3-A4", "3-C2", "3-C3", "3-C4" });
                }
                else
                {
                    ckseet.Items.Clear();
                    ckseet.Items.AddRange(new string[] {  "2-B2", "2-B3", "2-B4", "3-B2", "3-B3", "3-B4" });
                }
            }
            if (cbphim.SelectedItem == "Tarot")
            {
                if (cbve.SelectedItem == "vé vớt")
                {
                    ckseet.Items.Clear();
                    ckseet.Items.AddRange(new string[] {  "3-A1", "3-A5", "3-C1", "3-C5" });
                }
                else if (cbve.SelectedItem == "vé thường")
                {
                    ckseet.Items.Clear();
                    ckseet.Items.AddRange(new string[] {   "3-A2", "3-A3", "3-A4", "3-C2", "3-C3", "3-C4" });
                }
                else
                {
                    ckseet.Items.Clear();
                    ckseet.Items.AddRange(new string[] {  "3-B2", "3-B3", "3-B4" });
                }

            }
            if (cbphim.SelectedItem == "Gặp lại chị bầu")
            {
                if (cbve.SelectedItem == "vé vớt")
                {
                    ckseet.Items.Clear();
                    ckseet.Items.AddRange(new string[] { "1-A1", "1-A5", "1-C1", "1-C5" });
                }
                else if (cbve.SelectedItem == "vé thường")
                {
                    ckseet.Items.Clear();
                    ckseet.Items.AddRange(new string[] { "1-A2", "1-A3", "1-A4", "1-C2", "1-C3", "1-C4" });
                }
                else
                {
                    ckseet.Items.Clear();
                    ckseet.Items.AddRange(new string[] { "1-B2", "1-B3", "1-B4"});
                }
            }
        }
       

        private void btxuat_Click(object sender, EventArgs e)
        {
            string str_a= "";
            string str_b = "";
            string str_c = "";
            string str_d = "";
            CheckedListBox.CheckedItemCollection items = ckseet.CheckedItems;
            if (items.Count > 1)
            {
                MessageBox.Show("Chon 1 phong thoi", "!");
            }
            if (ckseet.CheckedItems.Count > 0)
            {
                for (int i = 0; i < ckseet.CheckedItems.Count; i++)
                {
                    str_a += ckseet.CheckedItems[i].ToString() + "   ";
                }

            }
            if (cbphim.SelectedItem == "Đào, phở và piano")
            {
                str_c = "Đào, phở và piano";

                if (cbve.SelectedItem == "vé vớt")
                {
                    str_b = "vé vớt";
                }
                else if (cbve.SelectedItem == "vé thường")
                {
                    str_b = "vé thường";
                }
                else
                {
                    str_b = "vé VIP";
                }
            }
            if (cbphim.SelectedItem == "Mai")
            {
                str_c = "Mai";
                if (cbve.SelectedItem == "vé vớt")
                {
                    str_b = "vé vớt";
                }
                else if (cbve.SelectedItem == "vé thường")
                {

                    str_b = "vé thường";
                }
                else
                {
                    str_b = "vé VIP";
                }
            }
            if (cbphim.SelectedItem == "Tarot")
            {
                str_c = "Tarot";
                if (cbve.SelectedItem == "vé vớt")
                {
                    str_b = "vé vớt";
                }
                else if (cbve.SelectedItem == "vé thường")
                {
                    str_b = "vé thường";
                }
                else
                {
                    str_b = "vé VIP";
                }

            }
            if (cbphim.SelectedItem == "Gặp lại chị bầu")
            {
                str_c = "Gặp lại chị bầu";
                if (cbve.SelectedItem == "vé vớt")
                {
                    str_b = "vé vớt";
                }
                else if (cbve.SelectedItem == "vé thường")
                {
                    str_b = "vé vớt";
                }
                else
                {
                    str_b = "vé vớt";
                }
            }
            str_d = txtname.Text;
            double money = 0;
            if (ckseet.CheckedItems.Count > 0)
            {
                for (int i = 0; i < ckseet.CheckedItems.Count; i++)
                {
                    if (cbphim.SelectedItem == "Đào, phở và piano")
                    {
                        if (ckseet.CheckedItems[i].ToString() == "1-A1" || ckseet.CheckedItems[i].ToString() == "1-A5" || ckseet.CheckedItems[i].ToString() == "1-C1" || ckseet.CheckedItems[i].ToString() == "1-C5" || ckseet.CheckedItems[i].ToString() == "2-A1" || ckseet.CheckedItems[i].ToString() == "2-A5" || ckseet.CheckedItems[i].ToString() == "2-C1" || ckseet.CheckedItems[i].ToString() == "2-C5" || ckseet.CheckedItems[i].ToString() == "3-A1" || ckseet.CheckedItems[i].ToString() == "3-A5" || ckseet.CheckedItems[i].ToString() == "3-C1" || ckseet.CheckedItems[i].ToString() == "3-C5")
                        {
                            money += (45000 / 4);
                        }
                        if (ckseet.CheckedItems[i].ToString() == "1-A2" || ckseet.CheckedItems[i].ToString() == "1-A3" || ckseet.CheckedItems[i].ToString() == "1-A4" || ckseet.CheckedItems[i].ToString() == "1-C2" || ckseet.CheckedItems[i].ToString() == "1-C3" || ckseet.CheckedItems[i].ToString() == "1-C4" || ckseet.CheckedItems[i].ToString() == "2-A2" || ckseet.CheckedItems[i].ToString() == "2-A3" || ckseet.CheckedItems[i].ToString() == "2-A4" || ckseet.CheckedItems[i].ToString() == "2-C2" || ckseet.CheckedItems[i].ToString() == "2-C3" || ckseet.CheckedItems[i].ToString() == "2-C4" || ckseet.CheckedItems[i].ToString() == "3-A2" || ckseet.CheckedItems[i].ToString() == "3-A3" || ckseet.CheckedItems[i].ToString() == "3-A4" || ckseet.CheckedItems[i].ToString() == "3-C2" || ckseet.CheckedItems[i].ToString() == "3-C3" || ckseet.CheckedItems[i].ToString() == "3-C4")
                        {
                            money += 45000;
                        }
                        if (ckseet.CheckedItems[i].ToString() == "1-B2" || ckseet.CheckedItems[i].ToString() == "1-B3" || ckseet.CheckedItems[i].ToString() == "1-B4" || ckseet.CheckedItems[i].ToString() == "2-B2" || ckseet.CheckedItems[i].ToString() == "2-B3" || ckseet.CheckedItems[i].ToString() == "2-B4" || ckseet.CheckedItems[i].ToString() == "3-B2" || ckseet.CheckedItems[i].ToString() == "3-B3" || ckseet.CheckedItems[i].ToString() == "3-B4")
                        {
                            money += (45000 * 2);
                        }
                    }
                    if (cbphim.SelectedItem == "Mai")
                    {
                        if (ckseet.CheckedItems[i].ToString() == "2-A1" || ckseet.CheckedItems[i].ToString() == "2-A5" || ckseet.CheckedItems[i].ToString() == "2-C1" || ckseet.CheckedItems[i].ToString() == "2-C5" || ckseet.CheckedItems[i].ToString() == "3-A1" || ckseet.CheckedItems[i].ToString() == "3-A5" || ckseet.CheckedItems[i].ToString() == "3-C1" || ckseet.CheckedItems[i].ToString() == "3-C5")
                        {
                            money += (100000 / 4);
                        }
                        if (ckseet.CheckedItems[i].ToString() == "2-A2" || ckseet.CheckedItems[i].ToString() == "2-A3" || ckseet.CheckedItems[i].ToString() == "2-A4" || ckseet.CheckedItems[i].ToString() == "2-C2" || ckseet.CheckedItems[i].ToString() == "2-C3" || ckseet.CheckedItems[i].ToString() == "2-C4" || ckseet.CheckedItems[i].ToString() == "3-A2" || ckseet.CheckedItems[i].ToString() == "3-A3" || ckseet.CheckedItems[i].ToString() == "3-A4" || ckseet.CheckedItems[i].ToString() == "3-C2" || ckseet.CheckedItems[i].ToString() == "3-C3" || ckseet.CheckedItems[i].ToString() == "3-C4")
                        {
                            money += 100000;
                        }
                        if (ckseet.CheckedItems[i].ToString() == "2-B2" || ckseet.CheckedItems[i].ToString() == "2-B3" || ckseet.CheckedItems[i].ToString() == "2-B4" || ckseet.CheckedItems[i].ToString() == "3-B2" || ckseet.CheckedItems[i].ToString() == "3-B3" || ckseet.CheckedItems[i].ToString() == "3-B4")
                        {
                            money += (100000 * 2);
                        }
                    }
                    if (cbphim.SelectedItem == "Gặp lại chị bầu")
                    {
                        if (ckseet.CheckedItems[i].ToString() == "1-A1" || ckseet.CheckedItems[i].ToString() == "1-A5" || ckseet.CheckedItems[i].ToString() == "1-C1" || ckseet.CheckedItems[i].ToString() == "1-C5")
                        {
                            money += (70000 / 4);
                        }
                        if (ckseet.CheckedItems[i].ToString() == "1-A2" || ckseet.CheckedItems[i].ToString() == "1-A3" || ckseet.CheckedItems[i].ToString() == "1-A4" || ckseet.CheckedItems[i].ToString() == "1-C2" || ckseet.CheckedItems[i].ToString() == "1-C3" || ckseet.CheckedItems[i].ToString() == "1-C4")
                        {
                            money += 70000;
                        }
                        if (ckseet.CheckedItems[i].ToString() == "1-B2"|| ckseet.CheckedItems[i].ToString() == "1-B3"|| ckseet.CheckedItems[i].ToString() == "1-B4")
                        {
                            money += (70000 * 2);
                        }
                    }
                    if (cbphim.SelectedItem == "Tarot")
                    {
                        if(ckseet.CheckedItems[i].ToString() == "3-A1"|| ckseet.CheckedItems[i].ToString() == "3-A5"|| ckseet.CheckedItems[i].ToString() == "3-C1"|| ckseet.CheckedItems[i].ToString() == "3-C5")
                        {
                            money += (90000 / 4);
                        }
                        if (ckseet.CheckedItems[i].ToString() == "3-A2"|| ckseet.CheckedItems[i].ToString() == "3-A3"|| ckseet.CheckedItems[i].ToString() == "3-A4"|| ckseet.CheckedItems[i].ToString() == "3-C2"|| ckseet.CheckedItems[i].ToString() == "3-C3"|| ckseet.CheckedItems[i].ToString() == "3-C4")
                        {
                            money += 90000;
                        }
                        if(ckseet.CheckedItems[i].ToString() == "3-B2"|| ckseet.CheckedItems[i].ToString() == "3-B3"|| ckseet.CheckedItems[i].ToString() == "3-B4")
                        {
                            money += (90000 * 2);
                        }
                    }
                }
                txtkq.Text = " Tên khách hàng:  " + str_d + "   \n"
                            + " Tên bộ phim: " + str_c + "     \n"
                            + " Loại vé đã chọn: " + str_b + "    \n"
                            + "chỗ ngồi đã chọn:  " + str_a + "     \n"
                            + "Tổng thành tiền:  " + money;

            }




        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            // C# dictionary
        }

        private void txtkq_Click(object sender, EventArgs e)
        {

        }
    }
}
