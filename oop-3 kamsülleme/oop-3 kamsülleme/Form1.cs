using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_3_kamsülleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            emlak em = new emlak();
            em.Semt = textBox1.Text;
            em.Odasayisi = Convert.ToInt32(textBox2.Text);
            em.Kat = int.Parse(textBox3.Text);

            ListViewItem kayıt = new ListViewItem();
            kayıt.Text = em.Semt;
            kayıt.SubItems.Add(em.Odasayisi.ToString());
            kayıt.SubItems.Add(em.Kat.ToString());

            listView1.Items.Add(kayıt);

        }
    }
}
