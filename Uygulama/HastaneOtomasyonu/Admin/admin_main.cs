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
    public partial class admin_main : Form
    {
        public admin_main()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ToString());
        SqlCommand komut;
        SqlDataReader dr;

        private void button2_Click(object sender, EventArgs e)
        {



        }

        private void admin_main_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            baglanti.Open();
            komut = new SqlCommand("SELECT * FROM admin WHERE admin_id = @id", baglanti);
            komut.Parameters.AddWithValue("@id", Giris.giris_ekrani.gonderilecekveri);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                label2.Text = dr["admin_ad"].ToString() + " " + dr["admin_soyad"].ToString();
            }
            baglanti.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            string saat = DateTime.Now.ToLongTimeString();
            label1.Text = saat.ToString();
            label1.Text += "   |";         

    
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            admin_hastalistesi yenikayit = new admin_hastalistesi();
            yenikayit.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult x;
            x = MessageBox.Show("Çıkmak İstediğinize Emin misiniz ? ", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            admin_doktor_gecis adg = new admin_doktor_gecis();
            adg.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            admin_mailhepsi yeni = new admin_mailhepsi();
            yeni.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            admin_laboratuvar al = new admin_laboratuvar();
            al.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            admin_radyoloji ad = new admin_radyoloji();
            ad.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            admin_ameliyathane ah = new admin_ameliyathane();
            ah.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            admin_hasta_ekrani hasta = new admin_hasta_ekrani();
            hasta.Show();
        }
    }
}
