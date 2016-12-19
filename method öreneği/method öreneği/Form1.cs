using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace method_öreneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntıkla_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("devam etmek istiyormusunuz?", "onay ekranı", MessageBoxButtons.YesNoCancel);
            //if (result==DialogResult.Yes)
            //{
            //    btntıkla.Text = "evet";
            //}
            //else if (result==DialogResult.No)
            //{
            //    btntıkla.Text = "hayır";
            //}
            //else
            //{
            //    btntıkla.Text = "iptal";
            //}
       
            listBox1.Items.Add(txtad.Text);
           

            txtad.Focus();


        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("devam etmek istiyormusunuz?", "onay ekranı", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else if (result == DialogResult.No)
            {
                btntıkla.Text = "hayır";
            }
         
        }
    }
}
