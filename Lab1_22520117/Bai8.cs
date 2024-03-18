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
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btadd_Click(object sender, EventArgs e)
        {
            lst1.Items.Add(txtthem.Text);
        }

        private void lst1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = lst1.Items.Count - 1; i >= 0; i--)
            {
                lst1.Items.Remove(lst1.Items[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var random = new Random();

            int index = random.Next(0, lst1.Items.Count);
            txtkq.Text = lst1.Items[index].ToString();
        }
    }
}
