using System;
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

namespace Uygulama.Giris
{
    public partial class giris_ekrani : Form
    {
        public giris_ekrani()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ToString());
        SqlCommand komut;
        SqlDataReader dr;
        public static string gonderilecekveri;

        private void giris_ekrani_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
        public static int tutt;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox1.Text);
                if (x == 1 && comboBox1.SelectedIndex == 0)
                {
                    baglanti.Open();

                    komut = new SqlCommand("SELECT * FROM admin WHERE  admin_sifre=@sifre", baglanti);
                    komut.Parameters.AddWithValue("@sifre", textBox1.Text);
                    dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        //MessageBox.Show(" Hoşgeldiniz " + dr["d_unvan"] + dr["d_ad"] + " " + dr["d_soyad"]);
                        gonderilecekveri = textBox1.Text;
                        Admin.admin_main adm = new Admin.admin_main();
                        adm.Show();
                        baglanti.Close();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Veri Girdiniz.", "UYARI!!");
                    }
                }

                else if (x == 1001 && comboBox1.SelectedIndex == 1)
                {
                    baglanti.Open();

                    komut = new SqlCommand("SELECT * FROM doktor WHERE  doktor_sifre=@sifre", baglanti);
                    komut.Parameters.AddWithValue("@sifre", textBox1.Text);
                    dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        //MessageBox.Show(" Hoşgeldiniz " + dr["d_unvan"] + dr["d_ad"] + " " + dr["d_soyad"]);
                        gonderilecekveri = textBox1.Text;
                        tutt = 1;
                        Doktor.doktor_noroloji adm = new Doktor.doktor_noroloji();
                        adm.Show();
                        baglanti.Close();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Veri Girdiniz.", "UYARI!!");
                    }
                }
                else if (x == 1002 && comboBox1.SelectedIndex == 1)
                {
                    baglanti.Open();

                    komut = new SqlCommand("SELECT * FROM doktor WHERE  doktor_sifre=@sifre", baglanti);
                    komut.Parameters.AddWithValue("@sifre", textBox1.Text);
                    dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        //MessageBox.Show(" Hoşgeldiniz " + dr["d_unvan"] + dr["d_ad"] + " " + dr["d_soyad"]);
                        gonderilecekveri = textBox1.Text;
                        tutt = 2;
                        Doktor.doktor_kardiyoloji adm = new Doktor.doktor_kardiyoloji();
                        adm.Show();
                        baglanti.Close();
                        this.Visible = false;
                    }

                    else
                    {
                        MessageBox.Show("Hatalı Veri Girdiniz.", "UYARI!!");
                    }
                }
                else if (x == 1003 && comboBox1.SelectedIndex == 1)
                {
                    baglanti.Open();

                    komut = new SqlCommand("SELECT * FROM doktor WHERE  doktor_sifre=@sifre", baglanti);
                    komut.Parameters.AddWithValue("@sifre", textBox1.Text);
                    dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        //MessageBox.Show(" Hoşgeldiniz " + dr["d_unvan"] + dr["d_ad"] + " " + dr["d_soyad"]);
                        gonderilecekveri = textBox1.Text;
                        tutt = 3;
                        Doktor.doktor_ortopedi adm = new Doktor.doktor_ortopedi();
                        adm.Show();
                        baglanti.Close();
                        this.Visible = false;
                    }

                    else
                    {
                        MessageBox.Show("Hatalı Veri Girdiniz.", "UYARI!!");
                    }
                }
                else if (x == 1004 && comboBox1.SelectedIndex == 1)
                {
                    baglanti.Open();

                    komut = new SqlCommand("SELECT * FROM doktor WHERE  doktor_sifre=@sifre", baglanti);
                    komut.Parameters.AddWithValue("@sifre", textBox1.Text);
                    dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        //MessageBox.Show(" Hoşgeldiniz " + dr["d_unvan"] + dr["d_ad"] + " " + dr["d_soyad"]);
                        gonderilecekveri = textBox1.Text;
                        tutt = 4;
                        Doktor.doktor_ftr adm = new Doktor.doktor_ftr();
                        adm.Show();
                        baglanti.Close();
                        this.Visible = false;
                    }

                    else
                    {
                        MessageBox.Show("Hatalı Veri Girdiniz.", "UYARI!!");
                    }
                }
                else if (x == 1005 && comboBox1.SelectedIndex == 1)
                {
                    baglanti.Open();

                    komut = new SqlCommand("SELECT * FROM doktor WHERE  doktor_sifre=@sifre", baglanti);
                    komut.Parameters.AddWithValue("@sifre", textBox1.Text);
                    dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        //MessageBox.Show(" Hoşgeldiniz " + dr["d_unvan"] + dr["d_ad"] + " " + dr["d_soyad"]);
                        gonderilecekveri = textBox1.Text;
                        tutt = 5;
                        Doktor.doktor_cocuk adm = new Doktor.doktor_cocuk();
                        adm.Show();
                        baglanti.Close();
                        this.Visible = false;
                    }

                    else
                    {
                        MessageBox.Show("Hatalı Veri Girdiniz.", "UYARI!!");
                    }
                }
                else if (x == 1006 && comboBox1.SelectedIndex == 1)
                {
                    baglanti.Open();

                    komut = new SqlCommand("SELECT * FROM doktor WHERE  doktor_sifre=@sifre", baglanti);
                    komut.Parameters.AddWithValue("@sifre", textBox1.Text);
                    dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        //MessageBox.Show(" Hoşgeldiniz " + dr["d_unvan"] + dr["d_ad"] + " " + dr["d_soyad"]);
                        gonderilecekveri = textBox1.Text;
                        tutt = 6;
                        Doktor.doktor_ichastaliklar adm = new Doktor.doktor_ichastaliklar();
                        adm.Show();
                        baglanti.Close();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Veri Girdiniz.", "UYARI!!");
                    }
                }

                else if (x == 1007 && comboBox1.SelectedIndex == 1)
                {
                    baglanti.Open();

                    komut = new SqlCommand("SELECT * FROM doktor WHERE  doktor_sifre=@sifre", baglanti);
                    komut.Parameters.AddWithValue("@sifre", textBox1.Text);
                    dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        //MessageBox.Show(" Hoşgeldiniz " + dr["d_unvan"] + dr["d_ad"] + " " + dr["d_soyad"]);
                        gonderilecekveri = textBox1.Text;
                        tutt = 7;
                        Doktor.doktor_kadind adm = new Doktor.doktor_kadind();
                        adm.Show();
                        baglanti.Close();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Veri Girdiniz.", "UYARI!!");
                    }
                }
                else if (x == 1008 && comboBox1.SelectedIndex == 1)
                {
                    baglanti.Open();

                    komut = new SqlCommand("SELECT * FROM doktor WHERE  doktor_sifre=@sifre", baglanti);
                    komut.Parameters.AddWithValue("@sifre", textBox1.Text);
                    dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        //MessageBox.Show(" Hoşgeldiniz " + dr["d_unvan"] + dr["d_ad"] + " " + dr["d_soyad"]);
                        gonderilecekveri = textBox1.Text;
                        tutt = 8;
                        Doktor.doktor_psikiyatri adm = new Doktor.doktor_psikiyatri();
                        adm.Show();
                        baglanti.Close();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Veri Girdiniz.", "UYARI!!");
                    }
                }
                else if (x == 1009 && comboBox1.SelectedIndex == 1)
                {
                    baglanti.Open();

                    komut = new SqlCommand("SELECT * FROM doktor WHERE  doktor_sifre=@sifre", baglanti);
                    komut.Parameters.AddWithValue("@sifre", textBox1.Text);
                    dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        //MessageBox.Show(" Hoşgeldiniz " + dr["d_unvan"] + dr["d_ad"] + " " + dr["d_soyad"]);
                        gonderilecekveri = textBox1.Text;
                        tutt = 9;
                        Doktor.doktor_dermatoloji adm = new Doktor.doktor_dermatoloji();
                        adm.Show();
                        baglanti.Close();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Veri Girdiniz.", "UYARI!!");
                    }
                }

                else if (x == 1010 && comboBox1.SelectedIndex == 1)
                {
                    baglanti.Open();

                    komut = new SqlCommand("SELECT * FROM doktor WHERE  doktor_sifre=@sifre", baglanti);
                    komut.Parameters.AddWithValue("@sifre", textBox1.Text);
                    dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        //MessageBox.Show(" Hoşgeldiniz " + dr["d_unvan"] + dr["d_ad"] + " " + dr["d_soyad"]);
                        gonderilecekveri = textBox1.Text;
                        tutt = 10;
                        Doktor.doktor_kbb adm = new Doktor.doktor_kbb();
                        adm.Show();
                        baglanti.Close();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Veri Girdiniz.", "UYARI!!");
                    }
                }
                else if (x == 1011 && comboBox1.SelectedIndex == 1)
                {
                    baglanti.Open();

                    komut = new SqlCommand("SELECT * FROM doktor WHERE  doktor_sifre=@sifre", baglanti);
                    komut.Parameters.AddWithValue("@sifre", textBox1.Text);
                    dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        //MessageBox.Show(" Hoşgeldiniz " + dr["d_unvan"] + dr["d_ad"] + " " + dr["d_soyad"]);
                        gonderilecekveri = textBox1.Text;
                        tutt = 11;
                        Doktor.doktor_goz adm = new Doktor.doktor_goz();
                        adm.Show();
                        baglanti.Close();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Veri Girdiniz.", "UYARI!!");
                    }
                }
                else if (x == 2001 && comboBox1.SelectedIndex == 2)
                {
                    baglanti.Open();
                    komut = new SqlCommand("SELECT * FROM hastakabul WHERE  hastakabul_sifre=@sifre", baglanti);
                    komut.Parameters.AddWithValue("@sifre", textBox1.Text);
                    dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        //MessageBox.Show(" Hoşgeldiniz " + dr["d_unvan"] + dr["d_ad"] + " " + dr["d_soyad"]);
                        gonderilecekveri = textBox1.Text;
                        HastaKabul.hastakabul_hastalistesi adm = new HastaKabul.hastakabul_hastalistesi();
                        adm.Show();
                        baglanti.Close();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Veri Girdiniz.", "UYARI!!");
                    }
                }
                else if (x == 3001 && comboBox1.SelectedIndex == 3)
                {
                    baglanti.Open();
                    komut = new SqlCommand("SELECT * FROM laborant WHERE  laborant_sifre=@sifre", baglanti);
                    komut.Parameters.AddWithValue("@sifre", textBox1.Text);
                    dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        //MessageBox.Show(" Hoşgeldiniz " + dr["d_unvan"] + dr["d_ad"] + " " + dr["d_soyad"]);
                        gonderilecekveri = textBox1.Text;
                        Laboratuvar.laboratuvar adm = new Laboratuvar.laboratuvar();
                        adm.Show();
                        baglanti.Close();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Veri Girdiniz.", "UYARI!!");
                    }
                }
                else if (x == 4001 && comboBox1.SelectedIndex == 4)
                {
                    baglanti.Open();
                    komut = new SqlCommand("SELECT * FROM radyoloji WHERE  radyoloji_sifre=@sifre", baglanti);
                    komut.Parameters.AddWithValue("@sifre", textBox1.Text);
                    dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        //MessageBox.Show(" Hoşgeldiniz " + dr["d_unvan"] + dr["d_ad"] + " " + dr["d_soyad"]);
                        gonderilecekveri = textBox1.Text;
                        Radyoloji.Radyoloji_radyoloji adm = new Radyoloji.Radyoloji_radyoloji();
                        adm.Show();
                        baglanti.Close();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Veri Girdiniz.", "UYARI!!");
                    }
                }
                else if (x == 5001 && comboBox1.SelectedIndex == 5)
                {
                    baglanti.Open();
                    komut = new SqlCommand("SELECT * FROM ameliyathane WHERE  ameliyathane_sifre=@sifre", baglanti);
                    komut.Parameters.AddWithValue("@sifre", textBox1.Text);
                    dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        //MessageBox.Show(" Hoşgeldiniz " + dr["d_unvan"] + dr["d_ad"] + " " + dr["d_soyad"]);
                        gonderilecekveri = textBox1.Text;
                        Ameliyathane.ameliyathane adm = new Ameliyathane.ameliyathane();
                        adm.Show();
                        baglanti.Close();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Veri Girdiniz.", "UYARI!!");
                    }
                }
                else
                {
                    MessageBox.Show("Hatalı veri Girdiniz.", "UYARI!");
                }
            }
            catch
            {
                MessageBox.Show("Şifreyi giriniz.");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
