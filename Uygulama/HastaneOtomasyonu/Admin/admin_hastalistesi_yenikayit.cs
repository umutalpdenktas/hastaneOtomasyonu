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
    public partial class admin_hastalistesi_yenikayit : Form
    {
        public admin_hastalistesi_yenikayit()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ToString());
        SqlCommand komut;
        SqlDataReader dr;

        public DataSet doldur(string sorgu)
        {
            baglanti.Open();
            SqlDataAdapter adp = new SqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            baglanti.Close();
            return ds;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_hastamuayenebilgileri yeni = new admin_hastamuayenebilgileri();
            yeni.Show();
            this.Close();

        }

        public string tut;

        public void doktortut()
        {
            //DOKTOR IDSI TUTMAK IÇIN
            string sorgu = "select bolum_id from bolum where bolum_ad = '" + comboBox11.Text + "' ";
            DataSet ds = doldur(sorgu);
            sorgu = "select doktor_id from doktor where doktor_bolum = '" + ds.Tables[0].Rows[0][0] + "'";

            ds.Clear();
            ds = doldur(sorgu);
            tut = ds.Tables[0].Rows[0][0].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            komut = new SqlCommand("insert into hasta(hasta_kodu,hasta_adi,hasta_soyadi,hasta_tcno,hasta_pasaportno,hasta_babaadi,hasta_anneadi,hasta_dtarihi,hasta_dyeri,hasta_cinsiyet," +
                "hasta_boyu,hasta_kilosu,hasta_meslegi,hasta_kayittarihi,hasta_il,hasta_ilce,hasta_mahalle_koy,hasta_cadde_sokak,hasta_cepno,hasta_evno,hasta_isno,hasta_email,hasta_sigara," +
                "hasta_alkol,hasta_kangrubu,hasta_hepatit,hasta_hiv,hasta_diyabet,hasta_kulilac,hasta_gechastalik,hasta_ailehastalik,hasta_gecameliyat,hasta_resim,hasta_ozcesmis,hasta_soygecmis," +
                "hasta_esadi,hasta_essoyadi,hasta_estelno,hasta_esmeslegi,hasta_es_kangrubu,hasta_uyari_mesaj,hasta_doktorid) VALUES(@hkodu,@hadi,@hsoyadi,@htcno,@hpno,@hbadi,@haadi,@hdtarih,@hdyeri,@hcinsiyeti,@hboy,@hkilo," +
                "@hmeslek,@hktarih,@hil,@hilce,@hmahalle_koy,@hcadde_sokak,@hcepno,@hevno,@hisno,@hemail,@hsigara,@halkol,@hkangrubu,@hhepatit,@hhiv,@hdiyabet,@hkilac,@hghastalik,@hailehastalik," +
                "@hgecmisameliyat,@hhastaresmi,@hhastaozgecmis,@hsoygecmis,@hesadi,@hessoyadi,@hestelno,@hesmeslek,@heskangrubu, @huyarimesaj,@doktorid)", baglanti);
            komut.Parameters.AddWithValue("@hkodu", textBox1.Text);
            komut.Parameters.AddWithValue("@hadi", textBox2.Text);
            komut.Parameters.AddWithValue("@hsoyadi", textBox3.Text);
            komut.Parameters.AddWithValue("@htcno", textBox5.Text);
            komut.Parameters.AddWithValue("@hpno", textBox6.Text);
            komut.Parameters.AddWithValue("@hbadi", textBox7.Text);
            komut.Parameters.AddWithValue("@haadi", textBox8.Text);
            komut.Parameters.AddWithValue("@hdtarih", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@hdyeri", textBox9.Text);
            komut.Parameters.AddWithValue("@hcinsiyeti", comboBox1.Text);
            komut.Parameters.AddWithValue("@hboy", textBox10.Text);
            komut.Parameters.AddWithValue("@hkilo", textBox11.Text);
            komut.Parameters.AddWithValue("@hmeslek", textBox12.Text);
            komut.Parameters.AddWithValue("@hktarih", dateTimePicker2.Text);
            komut.Parameters.AddWithValue("@hil", comboBox2.Text);
            komut.Parameters.AddWithValue("@hilce", comboBox3.Text);
            komut.Parameters.AddWithValue("@hmahalle_koy", textBox13.Text);
            komut.Parameters.AddWithValue("@hcadde_sokak", textBox14.Text);
            komut.Parameters.AddWithValue("@hcepno", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@hevno", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("@hisno", maskedTextBox3.Text);
            komut.Parameters.AddWithValue("@hemail", textBox18.Text);
            komut.Parameters.AddWithValue("@hsigara", comboBox4.Text);
            komut.Parameters.AddWithValue("@halkol", comboBox5.Text);
            komut.Parameters.AddWithValue("@hkangrubu", comboBox6.Text);
            komut.Parameters.AddWithValue("@hhepatit", comboBox7.Text);
            komut.Parameters.AddWithValue("@hhiv", comboBox8.Text);
            komut.Parameters.AddWithValue("@hdiyabet", comboBox9.Text);
            komut.Parameters.AddWithValue("@hkilac", richTextBox1.Text);
            komut.Parameters.AddWithValue("@hghastalik", richTextBox2.Text);
            komut.Parameters.AddWithValue("@hailehastalik", richTextBox3.Text);
            komut.Parameters.AddWithValue("@hgecmisameliyat", richTextBox4.Text);
            komut.Parameters.AddWithValue("@hhastaresmi", textBox22.Text);

            string hastaozgecmis = "";
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                hastaozgecmis += (checkedListBox1.CheckedItems[i] + ",");

            }
            komut.Parameters.AddWithValue("@hhastaozgecmis", hastaozgecmis);
            string hastasoygecmis = "";
            for (int i = 0; i < checkedListBox2.CheckedItems.Count; i++)
            {
                hastasoygecmis += (checkedListBox2.CheckedItems[i] + ",");
            }
            komut.Parameters.AddWithValue("@hsoygecmis", hastasoygecmis);
            komut.Parameters.AddWithValue("@hesadi", textBox19.Text);
            komut.Parameters.AddWithValue("@hessoyadi", textBox4.Text);
            komut.Parameters.AddWithValue("@hestelno", maskedTextBox4.Text);
            komut.Parameters.AddWithValue("@hesmeslek", textBox21.Text);
            komut.Parameters.AddWithValue("@heskangrubu", comboBox10.Text);
            komut.Parameters.AddWithValue("@huyarimesaj", richTextBox5.Text);
            komut.Parameters.AddWithValue("@doktorid", tut);
            
            if (textBox5.Text == "")
            {
                MessageBox.Show("TC bilgisini girmediniz.");
            }
            else
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("EKLEDİĞİNİZ VERİLER BAŞARIYLA EKLENDİ.");
            }
            baglanti.Close();
            //sonuclar kayıtları 0 girme
            baglanti.Open();
            komut = new SqlCommand("INSERT INTO hasta_sonuclar(hasta_id,laboratuvar_tetkikler_id,tedavi_id,ilac_id) VALUES(@hid,@labotetkik,@tedavi,@ilac)", baglanti);
            komut.Parameters.AddWithValue("@hid", textBox1.Text);
            komut.Parameters.AddWithValue("@labotetkik", 0);
            komut.Parameters.AddWithValue("@tedavi", 0);
            komut.Parameters.AddWithValue("@ilac", 0);
            komut.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            komut = new SqlCommand("INSERT INTO radyoloji_sonuclar(hasta_id,radyoloji_tetkikler_id,radyoloji_tetkik_adi) VALUES(@hid,@radyotetkik,'0')", baglanti);
            komut.Parameters.AddWithValue("@hid", textBox1.Text);
            komut.Parameters.AddWithValue("@radyotetkik", 0);
            komut.ExecuteNonQuery();
            baglanti.Close();

            //muayene kayıt 0 ekleme
            baglanti.Open();
            komut = new SqlCommand("INSERT INTO hasta_muayene(hasta_id,hasta_sikayet,hasta_anamnez,hasta_muayenebulgulari,hasta_oneri,hasta_karar,hasta_teshisler,hasta_tedaviadi,hasta_ilacadi) VALUES(@hid,@hsikayet,@hanamnez,@hmuayenebulgulari,@honeri,@hkarar,@teshisler,@tedaviadi,@ilac)", baglanti);
            komut.Parameters.AddWithValue("@hid", textBox1.Text);
            komut.Parameters.AddWithValue("@hsikayet", "-");
            komut.Parameters.AddWithValue("@hanamnez", "-");
            komut.Parameters.AddWithValue("@hmuayenebulgulari", "-");
            komut.Parameters.AddWithValue("@honeri", "-");
            komut.Parameters.AddWithValue("@hkarar", "-");
            komut.Parameters.AddWithValue("@teshisler", "-");
            komut.Parameters.AddWithValue("@tedaviadi", "-");
            komut.Parameters.AddWithValue("@ilac", "-");
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //RESİM YOLU EKLEME
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Tüm Dosyalar |*.*";
            dosya.Title = "SAU Hastanesi";
            dosya.ShowDialog();
            pictureBox1.ImageLocation = dosya.FileName;
            textBox22.Text = dosya.FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void admin_hastalistesi_yenikayit_Load(object sender, EventArgs e)
        {
            //COMBOBOX11LERE BÖLÜM ADI GETİRİR
            string sorgu = "select bolum_ad from bolum";
            DataSet ds = doldur(sorgu);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox11.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            baglanti.Open();
            komut = new SqlCommand("SELECT COUNT(hasta_kodu) as deger FROM hasta", baglanti);
            komut.ExecuteNonQuery();
            dr = komut.ExecuteReader();
            if(dr.Read())
            {
                int deger = Convert.ToInt32(dr["deger"].ToString());
                deger++;
                textBox1.Text = deger.ToString();
            }
            baglanti.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            //COMBOBOX11DE BÖLÜM SEÇİLİRSE COMBOBOX12 DE DOKTOR BİLGİLERİNİ GETİRME
            comboBox12.Text = "";
            comboBox12.Items.Clear();
            string sorgu = "select bolum_id from bolum where bolum_ad = '" + comboBox11.Text + "' ";
            DataSet ds = doldur(sorgu);
            sorgu = "select doktor_ad,doktor_soyad,doktor_unvan from doktor where doktor_bolum = '" + ds.Tables[0].Rows[0][0] + "'";
            ds.Clear();
            ds = doldur(sorgu);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox12.Items.Add(ds.Tables[0].Rows[i][i+2].ToString() +""+ ds.Tables[0].Rows[i][0] + " "+ ds.Tables[0].Rows[i][i + 1]);
            }
            comboBox12.SelectedIndex = 0;

        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            doktortut();
        }
    }
}
