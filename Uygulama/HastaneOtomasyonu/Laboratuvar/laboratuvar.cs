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

namespace Uygulama.Laboratuvar
{
    public partial class laboratuvar : Form
    {
        public laboratuvar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ToString());
        SqlCommand komut;
        SqlDataReader dr;

        private void sonuccek()
        {
            baglanti.Open();
            komut = new SqlCommand("SELECT hasta_id,hasta_adsoyad,laboratuvar_tetkikler_id,laboratuvar_tetkik_adi FROM hasta_sonuclar WHERE sonuc=1", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }


        string adisoyad = "";

        private void adsoyad()
        {
            baglanti.Open();
            komut = new SqlCommand("SELECT * FROM hasta_dosyalar", baglanti);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                adisoyad = dr["hasta_adisoyadi"].ToString();
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("UPDATE hasta_sonuclar SET sonuc = 0 WHERE hasta_id = @veri", baglanti);
            komut.Parameters.AddWithValue("@veri", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            sonuccek();
            axAcroPDF1.LoadFile("Empty");
            textBox1.Text = "";
        }

        private void laboratuvar_Load(object sender, EventArgs e)
        {
            adsoyad();
            sonuccek();
            // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet26.hasta_sonuclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hasta_sonuclarTableAdapter2.Fill(this.hastane_otomasyonu_yDataSet26.hasta_sonuclar);
            // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet25.hasta_dosyalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hasta_dosyalarTableAdapter1.Fill(this.hastane_otomasyonu_yDataSet25.hasta_dosyalar);
            // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet24.hasta_dosyalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hasta_dosyalarTableAdapter.Fill(this.hastane_otomasyonu_yDataSet24.hasta_dosyalar);
            // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet23.hasta_sonuclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hasta_sonuclarTableAdapter1.Fill(this.hastane_otomasyonu_yDataSet23.hasta_sonuclar);
            // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet22.hasta_sonuclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hasta_sonuclarTableAdapter.Fill(this.hastane_otomasyonu_yDataSet22.hasta_sonuclar);
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            baglanti.Open();
            komut = new SqlCommand("SELECT * FROM laborant", baglanti);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                label1.Text = dr["laborant_ad"].ToString() + " " + dr["laborant_soyad"].ToString();
            }
            baglanti.Close();


            int satirSayisi = dataGridView1.Rows.Count, sutunSayisi = dataGridView1.ColumnCount;

            for (int i = 0; i < satirSayisi - 1; i++)
            {
                for (int j = 1; j < sutunSayisi; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value == null)
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        MessageBox.Show("Bir Satır Silindi..");
                        satirSayisi = dataGridView1.Rows.Count;
                        i--;
                        break;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Belge Dosyası |*.pdf;*.doc;*.pdf |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            textBox1.Text = dosyayolu;
            axAcroPDF1.LoadFile(textBox1.Text);
        }
        private void muayene()
        {
            baglanti.Open();
            komut = new SqlCommand("UPDATE hasta SET hasta_muayene=1 WHERE hasta_kodu=@deger", baglanti);
            komut.Parameters.AddWithValue("@deger", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("INSERT INTO hasta_dosyalar(hasta_id,hasta_laborant_id,hasta_radyoloji_id,hasta_adisoyadi,hasta_tarih,hasta_aciklama) VALUES(@id,@lid,@rid,@haad,@ht,@ha)", baglanti);
            komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            komut.Parameters.AddWithValue("@lid", 1);
            komut.Parameters.AddWithValue("@rid", 0);
            komut.Parameters.AddWithValue("@haad", dataGridView1.CurrentRow.Cells[1].Value.ToString());
            komut.Parameters.AddWithValue("@ht", DateTime.Now.ToLongDateString());
            komut.Parameters.AddWithValue("@ha", textBox1.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Ekleme başarılı.");            
            baglanti.Close();
            muayene();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            laboratuvar_gi ad = new laboratuvar_gi();
            ad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Çıkış butonuna tıklayınca uyarı vermesi.
            DialogResult x;
            x = MessageBox.Show("Çıkmak İstediğinize Emin misiniz ? ", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
