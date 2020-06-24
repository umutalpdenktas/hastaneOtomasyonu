﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using System.Data.SqlClient;

namespace Uygulama.Radyoloji
{
    public partial class Radyoloji_radyoloji_gi : Form
    {
        public Radyoloji_radyoloji_gi()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ToString());
        SqlCommand komut;
        SqlDataReader dr;

        private void Radyoloji_radyoloji_gi_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            string kayit = "SELECT hasta_id,hasta_adisoyadi,hasta_tarih,hasta_aciklama FROM hasta_dosyalar WHERE hasta_radyoloji_id=1";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}