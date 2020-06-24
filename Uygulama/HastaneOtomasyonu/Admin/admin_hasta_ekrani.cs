using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Uygulama.Admin
{
    public partial class admin_hasta_ekrani : Form
    {
        public admin_hasta_ekrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ToString());
        SqlCommand komut;
        SqlDataReader dr;
        

        private void getir()
        {
            baglanti.Open();
            komut = new SqlCommand("SELECT * FROM bolum", baglanti);
            dr = komut.ExecuteReader();
            while(dr.Read())
            {
                comboBox1.Items.Add(dr["bolum_ad"].ToString());
            }
            baglanti.Close();
        }
        private void hasta_ekrani_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            getir();
            comboBox1.SelectedIndex = 0;
            timer1.Start();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                
            baglanti.Open();
            komut = new SqlCommand("SELECT hasta.hasta_adi,hasta.hasta_soyadi FROM hasta,doktor WHERE hasta.hasta_muayene=1 AND hasta.hasta_doktorid=@id AND doktor.doktor_id=@doktorid", baglanti);
            komut.Parameters.AddWithValue("@id", comboBox1.SelectedIndex + 1);
            komut.Parameters.AddWithValue("@doktorid", comboBox1.SelectedIndex + 1);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i;
                string a = dataGridView1.Rows[i].Cells[0].Value.ToString(); 
                if (a == "0" )
                {
                    dataGridView1.Rows[i].Cells[0].Value = "İçerde";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("SELECT hasta.hasta_adi,hasta.hasta_soyadi FROM hasta,doktor WHERE hasta.hasta_muayene=1 AND hasta.hasta_doktorid=@id AND doktor.doktor_id=@doktorid", baglanti);
            komut.Parameters.AddWithValue("@id", comboBox1.SelectedIndex + 1);
            komut.Parameters.AddWithValue("@doktorid", comboBox1.SelectedIndex + 1);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i;
                string a = dataGridView1.Rows[i].Cells[0].Value.ToString();
                if (a == "0")
                {
                    dataGridView1.Rows[i].Cells[0].Value = "İçerde";
                }
            }
        }
    }
}
