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
    public partial class admin_ameliyathane : Form
    {
        public admin_ameliyathane()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ToString());
        SqlCommand komut;
        SqlDataReader dr;

        public int doktorid;

        private void hastagetir()
        {
            baglanti.Open();
            komut = new SqlCommand("SELECT * FROM hasta WHERE hasta_kodu=@kod", baglanti);
            komut.Parameters.AddWithValue("@kod", comboBox3.Text);
            dr = komut.ExecuteReader();
            if(dr.Read())
            {
                textBox1.Text = dr["hasta_adi"].ToString();
                textBox2.Text = dr["hasta_soyadi"].ToString();
                doktorid = Convert.ToInt32(dr["hasta_doktorid"].ToString());
            }
            baglanti.Close();
        }

        private void doktorgetir()
        {
            baglanti.Open();
            komut = new SqlCommand("SELECT * FROM doktor WHERE doktor_id=@kod", baglanti);
            komut.Parameters.AddWithValue("@kod", doktorid);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                comboBox2.Items.Add(dr["doktor_unvan"].ToString() + dr["doktor_ad"].ToString() +" "+dr["doktor_soyad"].ToString());
            }

            baglanti.Close();
        }

        private void tablo()
        {
            string kayit = "SELECT * FROM ameliyat";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void ameliyatgetir()
        {
            baglanti.Open();
            komut = new SqlCommand("SELECT * FROM hasta_muayene WHERE hasta_ameliyat_durumu=1", baglanti);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr["hasta_id"].ToString());
            }
            baglanti.Close();

        }


        public string[] dizi = new string[8];
        public string[] dizi2;
        private void admin_ameliyathane_Load(object sender, EventArgs e)
        {
            
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ameliyatgetir();  
            try
            {
                comboBox3.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
                comboBox1.SelectedIndex = 0;
                tablo();

                dizi[0] = button1.Text;
                dizi[1] = button2.Text;
                dizi[2] = button3.Text;
                dizi[3] = button4.Text;
                dizi[4] = button8.Text;
                dizi[5] = button7.Text;
                dizi[6] = button6.Text;
                dizi[7] = button5.Text;

                dizi2 = new string[dataGridView1.Rows.Count];
                for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
                {
                    dizi2[j] = dataGridView1.Rows[j].Cells[4].Value.ToString();
                }
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    if (dizi2[i].ToString() != dizi[i].ToString())
                    {
                        if (dizi2[i].ToString() == button1.Text)
                        {
                            button1.BackColor = Color.Red;
                            button1.Enabled = false;
                        }
                        if (dizi2[i].ToString() == button2.Text)
                        {
                            button2.BackColor = Color.Red;
                            button2.Enabled = false;
                        }
                        if (dizi2[i].ToString() == button3.Text)
                        {
                            button3.BackColor = Color.Red;
                            button3.Enabled = false;
                        }
                        if (dizi2[i].ToString() == button4.Text)
                        {
                            button4.BackColor = Color.Red;
                            button4.Enabled = false;
                        }
                        if (dizi2[i].ToString() == button5.Text)
                        {
                            button5.BackColor = Color.Red;
                            button5.Enabled = false;
                        }
                        if (dizi2[i].ToString() == button6.Text)
                        {
                            button6.BackColor = Color.Red;
                            button6.Enabled = false;
                        }
                        if (dizi2[i].ToString() == button7.Text)
                        {
                            button7.BackColor = Color.Red;
                            button7.Enabled = false;
                        }
                        if (dizi2[i].ToString() == button8.Text)
                        {
                            button8.BackColor = Color.Red;
                            button8.Enabled = false;
                        }

                    }
                    else
                    {
                        MessageBox.Show("SLM");
                    }
                }
            
            }
            catch
            {

            }
            
        }
        private void ameliyatdoldur()
        {
            textBox3.Text = textBox1.Text + " " + textBox2.Text;
            textBox4.Text = comboBox2.Items[0].ToString();       
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            hastagetir();
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            
            doktorgetir();
            comboBox2.SelectedIndex = 0;
            ameliyatdoldur();

        }

        private void deger(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox6.Text = btn.Text;    
            
        }
       
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != ""  && textBox4.Text!="" && textBox6.Text != "")
            {                
                baglanti.Open();
                komut = new SqlCommand("INSERT INTO ameliyat(hasta_ad_soyad,doktor_adi,ameliyathane_no,ameliyat_zaman) VALUES(@adsoyad,@dadi,@ano,@azaman)", baglanti);
                komut.Parameters.AddWithValue("@adsoyad",textBox3.Text);
                komut.Parameters.AddWithValue("@dadi", textBox4.Text);
                komut.Parameters.AddWithValue("@ano", comboBox1.Text);
                komut.Parameters.AddWithValue("@azaman", textBox6.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Ekleme Başarılı..");
                baglanti.Close();
                tablo();
                if(textBox6.Text == button1.Text)
                {
                    button1.BackColor = Color.Red;
                    button1.Enabled = false;
                }
                if (textBox6.Text == button2.Text)
                {
                    button2.BackColor = Color.Red;
                    button2.Enabled = false;
                }
                if (textBox6.Text == button3.Text)
                {
                    button3.BackColor = Color.Red;
                    button3.Enabled = false;
                }
                if (textBox6.Text == button4.Text)
                {
                    button4.BackColor = Color.Red;
                    button4.Enabled = false;
                }
                if (textBox6.Text == button5.Text)
                {
                    button5.BackColor = Color.Red;
                    button5.Enabled = false;
                }
                if (textBox6.Text == button6.Text)
                {
                    button6.BackColor = Color.Red;
                    button6.Enabled = false;
                }
                if (textBox6.Text == button7.Text)
                {
                    button7.BackColor = Color.Red;
                    button7.Enabled = false;
                }
                if (textBox6.Text == button8.Text)
                {
                    button8.BackColor = Color.Red;
                    button8.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Verileri Eksiksiz Bir Şekilde Giriniz.");
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("DELETE FROM ameliyat", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo();
            button1.BackColor = Color.Green;
            button1.Enabled = true;
            button2.BackColor = Color.Green;
            button2.Enabled = true;
            button3.BackColor = Color.Green;
            button3.Enabled = true;
            button4.BackColor = Color.Green;
            button4.Enabled = true;
            button5.BackColor = Color.Green;
            button5.Enabled = true;
            button6.BackColor = Color.Green;
            button6.Enabled = true;
            button7.BackColor = Color.Green;
            button7.Enabled = true;
            button8.BackColor = Color.Green;
            button8.Enabled = true;
        }
    }
}
