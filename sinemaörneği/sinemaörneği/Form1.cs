﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sinemaörneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-FMCAGTH;Initial Catalog=sinema;Integrated Security=True");
        private void verigöster()
        {

            baglan.Open();
            SqlCommand komut = new SqlCommand("select*from bilet", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["cinsiyet"].ToString());

                listView1.Items.Add(ekle);
            }

            
        }
        int sayac = 48;
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((i != 4 || j > 1) && (i != 4 || j < 8))
                    {
                        Button btn = new Button();
                        btn.Width = 30;
                        btn.Height = 30;
                        btn.Text = sayac.ToString();
                        btn.BackColor = Color.Green;
                        btn.Left = (btn.Width * j) + 25;
                        btn.Top = (btn.Height * i) + 100;
                        btn.Click += Button_Click;
                        this.Controls.Add(btn);
                    }
                    sayac--;

                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button koltuk = sender as Button;
            koltuk.BackColor = Color.Red;
            labelkoltukno.Text = koltuk.Text;


        }

        private void gösterbtn_Click(object sender, EventArgs e)
        {
            verigöster();
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("insert into bilet(id,adsoyad) values ('" + labelkoltukno.Text.ToString() + "','" + textBoxadsoyad.Text.ToString() + "')", baglan);
            komut.ExecuteNonQuery();
            verigöster();

        }
    }
}
