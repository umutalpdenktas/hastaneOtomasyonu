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
using System.Collections;
using System.Configuration;

namespace Uygulama.Admin.DoktorForm
{
    public partial class admin_doktor_ichastalik : Form
    {

        public admin_doktor_ichastalik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ToString());
        SqlCommand komut;
        SqlDataReader dr;

        public int sayi = 1;

        public int doktor_id;

        private void renk_fonksiyon()
        {
            int[] dizi = new int[dataGridView1.Rows.Count];
            DataGridViewCellStyle renk = new DataGridViewCellStyle();
            DataGridViewCellStyle renk2 = new DataGridViewCellStyle();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dizi[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                if (dizi[i] % 2 == 0)
                {
                    renk.BackColor = Color.LightBlue;
                    dataGridView1.Rows[i].DefaultCellStyle = renk;
                }
                else
                {
                    renk2.BackColor = Color.LightGray;
                    dataGridView1.Rows[i].DefaultCellStyle = renk2;
                }

            }
        }
        private void doktorgel()
        {

            komut = new SqlCommand("SELECT * FROM doktor WHERE doktor_bolum=@bolum", baglanti);
            komut.Parameters.AddWithValue("@bolum",6);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                label1.Text = dr["doktor_unvan"].ToString() + dr["doktor_ad"].ToString() + " " + dr["doktor_soyad"].ToString();
            }
            baglanti.Close();
        }
        private void doktorkos()
        {
            baglanti.Open();
            komut = new SqlCommand("SELECT * FROM doktor WHERE doktor_bolum=@bolum", baglanti);
            komut.Parameters.AddWithValue("@bolum", 6);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                label1.Text = dr["doktor_unvan"].ToString() + dr["doktor_ad"].ToString() + " " + dr["doktor_soyad"].ToString();
            }
            baglanti.Close();
        }
        private void fonksiyon_getir()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            tablo();
            renk_fonksiyon();
            tedaviget();
            // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet21.hasta_istirahat' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hasta_istirahatTableAdapter.Fill(this.hastane_otomasyonu_yDataSet21.hasta_istirahat);
            dateTimePicker3.Text = DateTime.Now.ToLongDateString();
            // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet20.doktor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.doktorTableAdapter.Fill(this.hastane_otomasyonu_yDataSet20.doktor);
            // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet19.teshisler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.teshislerTableAdapter3.Fill(this.hastane_otomasyonu_yDataSet19.teshisler);
            // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet18.teshisler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.teshislerTableAdapter2.Fill(this.hastane_otomasyonu_yDataSet18.teshisler);
            // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet17.hasta_recete' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hasta_receteTableAdapter.Fill(this.hastane_otomasyonu_yDataSet17.hasta_recete);
            // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet16.hasta_tedaviler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hasta_tedavilerTableAdapter.Fill(this.hastane_otomasyonu_yDataSet16.hasta_tedaviler);
            // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet15.hasta' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastaTableAdapter2.Fill(this.hastane_otomasyonu_yDataSet15.hasta);
            // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet14.radyoloji_tetkikler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.radyoloji_tetkiklerTableAdapter.Fill(this.hastane_otomasyonu_yDataSet14.radyoloji_tetkikler);
            // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet13.laboratuvar_tetkikler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.laboratuvar_tetkiklerTableAdapter.Fill(this.hastane_otomasyonu_yDataSet13.laboratuvar_tetkikler);
            this.laboratuvar_tetkiklerTableAdapter.Fill(this.hastane_otomasyonu_yDataSet13.laboratuvar_tetkikler);
            this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView7.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView8.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView9.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView10.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView11.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView12.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dataGridView1.Rows.Count <= 1)
            {
                doktorgel();
            }
            else
            {
                doktorkos();
            }
            string sorgu = "select * from doktor";
            DataSet ds = doldur(sorgu);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox12.Items.Add(ds.Tables[0].Rows[i][3].ToString() + ds.Tables[0].Rows[i][1].ToString() + " " + ds.Tables[0].Rows[i][2].ToString());
            }
            comboBox12.SelectedIndex = 5;

        }
        private void tablo()
        {
            try
            {
                string kayit = "SELECT hasta.hasta_kodu,hasta.hasta_adi,hasta.hasta_soyadi,hasta.hasta_tcno,hasta.hasta_pasaportno,hasta.hasta_babaadi,hasta.hasta_anneadi,hasta.hasta_dtarihi,hasta.hasta_dyeri,hasta.hasta_cinsiyet,hasta.hasta_boyu,hasta.hasta_kilosu,hasta.hasta_meslegi,hasta.hasta_kayittarihi,hasta.hasta_il,hasta.hasta_ilce,hasta.hasta_mahalle_koy,hasta.hasta_cadde_sokak,hasta.hasta_cepno,hasta.hasta_evno,hasta.hasta_isno,hasta.hasta_email,hasta.hasta_sigara,hasta.hasta_alkol,hasta.hasta_kangrubu,hasta.hasta_hepatit,hasta.hasta_hiv,hasta.hasta_diyabet,hasta.hasta_kulilac,hasta.hasta_gechastalik,hasta.hasta_ailehastalik,hasta.hasta_gecameliyat,hasta.hasta_resim,hasta.hasta_ozcesmis,hasta.hasta_soygecmis,hasta.hasta_esadi,hasta.hasta_essoyadi,hasta.hasta_estelno,hasta.hasta_esmeslegi,hasta.hasta_es_kangrubu,hasta.hasta_uyari_mesaj,hasta.hasta_muayene FROM hasta,doktor WHERE hasta.hasta_doktorid=6 AND doktor.doktor_id=6 AND hasta.hasta_muayene=1";
                baglanti.Open();
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("HASTA YOK!");
            }

        }
        public string metin;
        public DataSet doldur(string sorgu)
        {
            baglanti.Open();
            SqlDataAdapter adp = new SqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            baglanti.Close();
            return ds;
        }
        public string tedavi_id = "";
        public string tedavi_adi = "";

        private void button17_Click(object sender, EventArgs e)
        {
            //tedavi id verme
            try
            {
                if (textBox1.Text != "")
                {
                    baglanti.Open();
                    komut = new SqlCommand("UPDATE hasta_sonuclar SET tedavi_id=@tid WHERE hasta_id=@hasta_id", baglanti);
                    komut.Parameters.AddWithValue("@hasta_id", textBox1.Text);
                    komut.Parameters.AddWithValue("@tid", tedavi_id);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("basarılı");
                }
                else
                {
                    MessageBox.Show("LÜTFEN VERİLERİ EKSİKSİZ GİRDİĞİNİZE EMİN OLUN.");
                }
                //tedavi id verme
                //muayene veritabanına hasta tedavi adi ekleme
                baglanti.Open();
                komut = new SqlCommand("UPDATE hasta_muayene SET hasta_tedaviadi=@tedavi WHERE hasta_id=@hasta_id", baglanti);
                komut.Parameters.AddWithValue("@hasta_id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                komut.Parameters.AddWithValue("@tedavi", tedavi_adi);
                komut.ExecuteNonQuery();
                baglanti.Close();
                //muayene veritabanına hasta tedavi adi ekleme
            }
            catch
            {
                MessageBox.Show("LÜTFEN VERİLERİ EKSİKSİZ GİRDİĞİNİZE EMİN OLUN.");
            }


        }
        private void dosyagetir()
        {
            try
            {
                baglanti.Open();
                komut = new SqlCommand("SELECT * FROM hasta_dosyalar WHERE hasta_id=@id", baglanti);
                komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView12.DataSource = dt;
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("LÜTFEN VERİLERİ EKSİKSİZ GİRDİĞİNİZE EMİN OLUN.");

            }

        }
        private void tedaviget()
        {
            try
            {
                baglanti.Open();
                komut = new SqlCommand("SELECT * FROM hasta_tedaviler", baglanti);
                komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView9.DataSource = dt;
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("LÜTFEN VERİLERİ EKSİKSİZ GİRDİĞİNİZE EMİN OLUN.");

            }

        }
        private void admin_doktor_ichastalik_Load(object sender, EventArgs e)
        {
            try
            {


                // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet21.hasta_istirahat' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.hasta_istirahatTableAdapter.Fill(this.hastane_otomasyonu_yDataSet21.hasta_istirahat);
                dateTimePicker3.Text = DateTime.Now.ToLongDateString();
                // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet20.doktor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.doktorTableAdapter.Fill(this.hastane_otomasyonu_yDataSet20.doktor);
                // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet19.teshisler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.teshislerTableAdapter3.Fill(this.hastane_otomasyonu_yDataSet19.teshisler);
                // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet18.teshisler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.teshislerTableAdapter2.Fill(this.hastane_otomasyonu_yDataSet18.teshisler);
                // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet17.hasta_recete' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.hasta_receteTableAdapter.Fill(this.hastane_otomasyonu_yDataSet17.hasta_recete);
                // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet16.hasta_tedaviler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.hasta_tedavilerTableAdapter.Fill(this.hastane_otomasyonu_yDataSet16.hasta_tedaviler);
                // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet15.hasta' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.hastaTableAdapter2.Fill(this.hastane_otomasyonu_yDataSet15.hasta);
                // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet14.radyoloji_tetkikler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.radyoloji_tetkiklerTableAdapter.Fill(this.hastane_otomasyonu_yDataSet14.radyoloji_tetkikler);
                // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet13.laboratuvar_tetkikler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.laboratuvar_tetkiklerTableAdapter.Fill(this.hastane_otomasyonu_yDataSet13.laboratuvar_tetkikler);
                this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dataGridView7.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dataGridView8.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dataGridView9.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dataGridView10.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dataGridView11.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dataGridView12.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                baglanti.Open();
                komut = new SqlCommand("SELECT * FROM doktor WHERE doktor_bolum=@bolum", baglanti);
                komut.Parameters.AddWithValue("@bolum", 6);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    comboBox13.Items.Add(dr["doktor_unvan"].ToString() + dr["doktor_ad"].ToString() + " " + dr["doktor_soyad"].ToString());
                }
                baglanti.Close();
                comboBox13.SelectedIndex = 0;



                string sorgu = "select * from doktor";
                DataSet ds = doldur(sorgu);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    comboBox12.Items.Add(ds.Tables[0].Rows[i][3].ToString() + ds.Tables[0].Rows[i][1].ToString() + " " + ds.Tables[0].Rows[i][2].ToString());
                }
                comboBox12.SelectedIndex = 5;


                // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet12.teshisler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.teshislerTableAdapter1.Fill(this.hastane_otomasyonu_yDataSet12.teshisler);
                // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet10.teshisler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet8.hasta' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.hastaTableAdapter1.Fill(this.hastane_otomasyonu_yDataSet8.hasta);
                // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet7.hasta' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.hastaTableAdapter.Fill(this.hastane_otomasyonu_yDataSet7.hasta);

                tablo();
                baglanti.Open();
                //Label'a doktorun ismini yazdırma.
                komut = new SqlCommand("SELECT * FROM doktor WHERE doktor_bolum=@bolum", baglanti);
                komut.Parameters.AddWithValue("@bolum", 6);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    label1.Text = dr["doktor_unvan"].ToString() + dr["doktor_ad"].ToString() + " " + dr["doktor_soyad"].ToString();
                }
                baglanti.Close();
                //Label'a doktorun ismini yazdırma.
                tedaviget();

                //data grıd view Renklendirme
                renk_fonksiyon();
            }
            catch
            {

            }
        }
        public string deneme_metin = "";
        private void button4_Click(object sender, EventArgs e)
        {

            //Çıkış butonuna tıklayınca uyarı vermesi.
            DialogResult x;
            x = MessageBox.Show("Çıkmak İstediğinize Emin misiniz ? ", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                dosyagetir();
                istirahatgetir();
                //Datagridview'e çift tıklayınca verileri getirme.
                char ayrac = ',';
                string deneme = dataGridView1.CurrentRow.Cells[33].Value.ToString();
                string[] ayrim = deneme.Split(ayrac);

                for (int i = 0; i < ayrim.Length; i++)
                {
                    richTextBox1.Text += ayrim[i] + "\n";
                }
                char ayrac2 = ',';
                string deneme2 = dataGridView1.CurrentRow.Cells[34].Value.ToString();
                string[] ayrim2 = deneme2.Split(ayrac2);

                for (int i = 0; i < ayrim2.Length; i++)
                {
                    richTextBox2.Text += ayrim2[i] + "\n";
                }
                char ayrac3 = ',';
                string deneme3 = dataGridView1.CurrentRow.Cells[34].Value.ToString();
                string[] ayrim3 = deneme3.Split(ayrac3);

                for (int i = 0; i < ayrim3.Length; i++)
                {
                    richTextBox3.Text += ayrim3[i] + "\n";
                }
                char ayrac4 = ',';
                string deneme4 = dataGridView1.CurrentRow.Cells[28].Value.ToString();
                string[] ayrim4 = deneme4.Split(ayrac4);

                for (int i = 0; i < ayrim4.Length; i++)
                {
                    richTextBox6.Text += ayrim4[i] + "\n";
                }
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                textBox10.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                textBox11.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                textBox12.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                comboBox2.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                comboBox3.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                textBox13.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
                textBox14.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
                maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
                maskedTextBox2.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
                maskedTextBox3.Text = dataGridView1.CurrentRow.Cells[20].Value.ToString();
                textBox18.Text = dataGridView1.CurrentRow.Cells[21].Value.ToString();
                comboBox4.Text = dataGridView1.CurrentRow.Cells[22].Value.ToString();
                comboBox5.Text = dataGridView1.CurrentRow.Cells[23].Value.ToString();
                comboBox6.Text = dataGridView1.CurrentRow.Cells[24].Value.ToString();
                comboBox7.Text = dataGridView1.CurrentRow.Cells[25].Value.ToString();
                comboBox8.Text = dataGridView1.CurrentRow.Cells[26].Value.ToString();
                comboBox9.Text = dataGridView1.CurrentRow.Cells[27].Value.ToString();
                richTextBox6.Text = dataGridView1.CurrentRow.Cells[28].Value.ToString();
                richTextBox3.Text = dataGridView1.CurrentRow.Cells[31].Value.ToString();
                textBox22.Text = dataGridView1.CurrentRow.Cells[32].Value.ToString();
                richTextBox5.Text = dataGridView1.CurrentRow.Cells[40].Value.ToString();
                textBox19.Text = dataGridView1.CurrentRow.Cells[35].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[36].Value.ToString();
                maskedTextBox4.Text = dataGridView1.CurrentRow.Cells[37].Value.ToString();
                textBox21.Text = dataGridView1.CurrentRow.Cells[38].Value.ToString();
                comboBox10.Text = dataGridView1.CurrentRow.Cells[39].Value.ToString();
                pictureBox1.ImageLocation = textBox22.Text;
                //DATAGRİDVİEWE ÇİFT TIKLAYINCA VERİLERİ GETİRME BURADA BİTİYOR.
                //Muayene Ekranına Özgeçmiş, Soygeçmiş ve Kullandığı İlaç Getirme.
                for (int i = 0; i < ayrim.Length; i++)
                {
                    richTextBox8.Text += ayrim[i] + "\n";
                }
                for (int i = 0; i < ayrim2.Length; i++)
                {
                    richTextBox9.Text += ayrim2[i] + "\n";
                }
                for (int i = 0; i < ayrim4.Length; i++)
                {
                    richTextBox10.Text += ayrim4[i] + "\n";
                }
                richTextBox14.Text = dataGridView1.CurrentRow.Cells[40].Value.ToString();
                //Muayene Ekranına Özgeçmiş, Soygeçmiş ve Kullandığı İlaç Getirme.

                //MUAYENE EKRANINA ŞİKAYET, ÖNERİ BİLGİLERİNİ GETİRME.
                baglanti.Open();
                komut = new SqlCommand("SELECT * FROM hasta_muayene WHERE hasta_id=@id", baglanti);
                komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    richTextBox4.Text = dr["hasta_sikayet"].ToString();
                    richTextBox7.Text = dr["hasta_anamnez"].ToString();
                    richTextBox11.Text = dr["hasta_muayenebulgulari"].ToString();
                    richTextBox12.Text = dr["hasta_oneri"].ToString();
                    richTextBox13.Text = dr["hasta_karar"].ToString();
                }
                baglanti.Close();
                //tedavi getirme
                baglanti.Open();
                komut = new SqlCommand("SELECT hasta_tedaviadi FROM hasta_muayene WHERE hasta_id=@hasta_id", baglanti);
                komut.Parameters.AddWithValue("@hasta_id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    char ayrac5 = ',';
                    string deneme5 = dr["hasta_tedaviadi"].ToString();
                    string[] ayrim5 = deneme5.Split(ayrac5);

                    for (int i = 0; i < ayrim5.Length; i++)
                    {
                        richTextBox15.Text += ayrim5[i] + "\n";
                    }
                }
                baglanti.Close();

                //Reçete getirme
                baglanti.Open();
                komut = new SqlCommand("SELECT hasta_ilacadi FROM hasta_muayene WHERE hasta_id=@hasta_id", baglanti);
                komut.Parameters.AddWithValue("@hasta_id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    char ayrac6 = ';';
                    string deneme6 = dr["hasta_ilacadi"].ToString();
                    string[] ayrim6 = deneme6.Split(ayrac6);

                    for (int i = 0; i < ayrim6.Length; i++)
                    {
                        richTextBox16.Text += ayrim6[i] + "\n";
                    }
                }
                baglanti.Close();
                //Reçete ekranına teşhis getirme.
                baglanti.Open();
                komut = new SqlCommand("SELECT hasta_teshisler FROM hasta_muayene WHERE hasta_id=@hasta_id", baglanti);
                komut.Parameters.AddWithValue("@hasta_id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    char ayrac6 = ';';
                    string deneme6 = dr["hasta_teshisler"].ToString();
                    string[] ayrim6 = deneme6.Split(ayrac6);
                    for (int i = 0; i < ayrim6.Length; i++)
                    {
                        comboBox11.Items.Add(ayrim6[i]).ToString();
                    }
                }
                baglanti.Close();
            }
            catch
            {

            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                komut = new SqlCommand("UPDATE hasta SET hasta_muayene = 0 WHERE hasta_kodu = @veri", baglanti);
                komut.Parameters.AddWithValue("@veri", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                tablo();
                int[] dizi = new int[dataGridView1.Rows.Count];
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                DataGridViewCellStyle renk2 = new DataGridViewCellStyle();
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dizi[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    if (dizi[i] % 2 == 0)
                    {
                        renk.BackColor = Color.LightBlue;
                        dataGridView1.Rows[i].DefaultCellStyle = renk;
                    }
                    else
                    {
                        renk2.BackColor = Color.LightGray;
                        dataGridView1.Rows[i].DefaultCellStyle = renk2;
                    }

                }
            }
            catch
            {

            }
            fonksiyon_getir();
            verigetir();
            tedaviget();
        }

        private void dataGridView2_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string[] deger = new string[2];
                deger[0] = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                deger[1] = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                deneme_metin += dataGridView2.CurrentRow.Cells[0].Value.ToString() + ";";
                dataGridView3.Rows.Add(deger[0], deger[1]);
            }
            catch
            {

            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                string[] deger = new string[2];
                deger[0] = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                deger[1] = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                dataGridView3.Rows.Add(deger[0], deger[1]);
            }

            catch
            {
                MessageBox.Show("LÜTFEN VERİLERİ EKSİKSİZ GİRDİĞİNİZE EMİN OLUN.");

            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                //TÜM SATIRLAR SİLİNİNCE SİL BUTONUNA BASINCA HATA ÇIKIYOR YARIN BAK !*!
                int selectedIndex = dataGridView3.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                    dataGridView3.Rows.RemoveAt(selectedIndex);
            }
            catch
            {
                MessageBox.Show("SİLİNECEK VERİ YOK !!!");
            }

        }


        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox7.Text == "")
                {
                    verigetir();
                }
                else
                {
                    baglanti.Open();

                    string srg = textBox7.Text;
                    string sorgu = "Select * from teshisler where teshis_adi Like '%" + srg + "%'";
                    SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
                    dataGridView2.DataSource = dt;
                    baglanti.Close();

                }
            }
            catch
            {

            }
            textBox6.Text = "";
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox6.Text == "")
                {
                    verigetir();
                }
                else
                {
                    baglanti.Open();

                    string srg = textBox6.Text;
                    string sorgu = "Select * from teshisler where icd_kodu Like '%" + srg + "%'";
                    SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
                    dataGridView2.DataSource = dt;
                    baglanti.Close();
                }
                textBox7.Text = "";
            }
            catch
            {

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    baglanti.Open();
                    komut = new SqlCommand("UPDATE hasta_muayene SET hasta_sikayet=@sikayet,hasta_anamnez=@anamnez,hasta_ozgecmis=@ozgecmis,hasta_soygecmis=@soygecmis,hasta_kulilac=@kulilac,hasta_muayenebulgulari=@mbulgulari,hasta_oneri=@oneri,hasta_karar=@karar,hasta_teshisler=@teshisler,hasta_uyarimesaj=@uyarimesaj,hasta_tedaviadi=@hasta_tedavi, hasta_ameliyat_durumu=@hameliyat WHERE hasta_id=@hastaid", baglanti);
                    komut.Parameters.AddWithValue("@hastaid", textBox1.Text);
                    komut.Parameters.AddWithValue("@sikayet", richTextBox4.Text);
                    komut.Parameters.AddWithValue("@anamnez", richTextBox7.Text);
                    komut.Parameters.AddWithValue("@ozgecmis", richTextBox8.Text);
                    komut.Parameters.AddWithValue("@soygecmis", richTextBox9.Text);
                    komut.Parameters.AddWithValue("@kulilac", richTextBox10.Text);
                    komut.Parameters.AddWithValue("@mbulgulari", richTextBox11.Text);
                    komut.Parameters.AddWithValue("@oneri", richTextBox12.Text);
                    komut.Parameters.AddWithValue("@karar", richTextBox13.Text);
                    komut.Parameters.AddWithValue("@teshisler", deneme_metin);
                    komut.Parameters.AddWithValue("@uyarimesaj", richTextBox14.Text);
                    komut.Parameters.AddWithValue("@hasta_tedavi", 0);
                    if (checkBox1.Checked)
                    {
                        komut.Parameters.AddWithValue("@hameliyat", 1);
                    }
                    else
                        komut.Parameters.AddWithValue("@hameliyat", 0);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("VERİLER BAŞARIYLA EKLENDİ.");
                }
                else
                {
                    MessageBox.Show("LÜTFEN VERİLERİ EKSİKSİZ GİRDİĞİNİZE EMİN OLUN.");

                }
            }
            catch
            {
                MessageBox.Show("LÜTFEN VERİLERİ EKSİKSİZ GİRDİĞİNİZE EMİN OLUN.");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    baglanti.Open();
                    komut = new SqlCommand("UPDATE hasta SET hasta_doktorid=@doktor_id WHERE hasta_kodu=@hastakodu ", baglanti);
                    int deger = comboBox12.SelectedIndex;
                    deger++;
                    komut.Parameters.AddWithValue("@doktor_id", deger.ToString());
                    komut.Parameters.AddWithValue("@hastakodu", textBox1.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Hasta Aktarma Başarılı");
                    tablo();

                }
                else
                {
                    MessageBox.Show("LÜTFEN VERİLERİ EKSİKSİZ GİRDİĞİNİZE EMİN OLUN.");

                }

            }
            catch
            {
                MessageBox.Show("LÜTFEN VERİLERİ EKSİKSİZ GİRDİĞİNİZE EMİN OLUN.");
            }
            renk_fonksiyon();

        }
        public string lkodu = "";
        public string tad = "";
        private void dataGridView5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string[] deger = new string[2];
                deger[0] = dataGridView5.CurrentRow.Cells[0].Value.ToString();
                deger[1] = dataGridView5.CurrentRow.Cells[1].Value.ToString();
                lkodu += dataGridView5.CurrentRow.Cells[0].Value.ToString() + ",";
                tad += dataGridView5.CurrentRow.Cells[1].Value.ToString() + ";";
                dataGridView4.Rows.Add(deger[0], deger[1]);
            }
            catch
            {

            }

        }
        public string rkodu = "";
        public string radkod = "";
        private void dataGridView7_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string[] deger = new string[2];
                deger[0] = dataGridView7.CurrentRow.Cells[0].Value.ToString();
                deger[1] = dataGridView7.CurrentRow.Cells[1].Value.ToString();
                rkodu += dataGridView7.CurrentRow.Cells[0].Value.ToString() + ",";
                radkod += dataGridView7.CurrentRow.Cells[1].Value.ToString() + ";";
                dataGridView6.Rows.Add(deger[0], deger[1]);
            }
            catch
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dataGridView4.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                    dataGridView4.Rows.RemoveAt(selectedIndex);
            }
            catch
            {
                MessageBox.Show("SİLİNECEK VERİ YOK !!!");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dataGridView6.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                    dataGridView6.Rows.RemoveAt(selectedIndex);
            }
            catch
            {
                MessageBox.Show("SİLİNECEK VERİ YOK !!!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dataGridView4.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    PrintPreviewDialog onizleme = new PrintPreviewDialog();
                    onizleme.Document = printDocument1;
                    onizleme.ShowDialog();
                    PrintDialog yazdir = new PrintDialog();
                    yazdir.Document = printDocument1;
                    yazdir.UseEXDialog = true;
                    if (yazdir.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                }
            }
            catch
            {
                MessageBox.Show("YAZDIRILACAK VERİ YOK !!!");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dataGridView6.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    PrintPreviewDialog onizleme = new PrintPreviewDialog();
                    onizleme.Document = printDocument2;
                    onizleme.ShowDialog();
                    PrintDialog yazdir = new PrintDialog();
                    yazdir.Document = printDocument2;
                    yazdir.UseEXDialog = true;
                    if (yazdir.ShowDialog() == DialogResult.OK)
                    {
                        printDocument2.Print();
                    }
                }
            }
            catch
            {
                MessageBox.Show("YAZDIRILACAK VERİ YOK!");
            }


        }

        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iRow = 0;
        bool bFirstPage = false;
        bool bNewPage = false;
        int iHeaderHeight = 0;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int iLeftMargin = e.MarginBounds.Left;
                int iTopMargin = e.MarginBounds.Top;
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;
                bFirstPage = true;

                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dataGridView4.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;


                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }

                while (iRow <= dataGridView4.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dataGridView4.Rows[iRow];

                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;

                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {

                            e.Graphics.DrawString("Çıktı Başlığı", new System.Drawing.Font(dataGridView4.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Çıktı Başlığı", new System.Drawing.Font(dataGridView4.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new System.Drawing.Font(dataGridView4.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new System.Drawing.Font(dataGridView4.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Çıktı Başlığı", new System.Drawing.Font(new System.Drawing.Font(dataGridView4.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);


                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dataGridView4.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new System.Drawing.Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new System.Drawing.Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;

                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }

                            e.Graphics.DrawRectangle(Pens.Black, new System.Drawing.Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }


                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dataGridView4.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int iLeftMargin = e.MarginBounds.Left;
                int iTopMargin = e.MarginBounds.Top;
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;
                bFirstPage = true;

                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dataGridView6.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;


                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }

                while (iRow <= dataGridView6.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dataGridView6.Rows[iRow];

                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;

                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {

                            e.Graphics.DrawString("Çıktı Başlığı", new System.Drawing.Font(dataGridView6.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Çıktı Başlığı", new System.Drawing.Font(dataGridView6.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new System.Drawing.Font(dataGridView6.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new System.Drawing.Font(dataGridView6.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Çıktı Başlığı", new System.Drawing.Font(new System.Drawing.Font(dataGridView6.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);


                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dataGridView6.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new System.Drawing.Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new System.Drawing.Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;

                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }

                            e.Graphics.DrawRectangle(Pens.Black, new System.Drawing.Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }


                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument2_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dataGridView6.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    baglanti.Open();
                    komut = new SqlCommand("UPDATE hasta_sonuclar SET hasta_adsoyad=@adsoyad,laboratuvar_tetkikler_id = @ltetkik,laboratuvar_tetkik_adi=@tad,sonuc=1 WHERE hasta_id=@hasta_id", baglanti);
                    komut.Parameters.AddWithValue("@hasta_id", textBox1.Text);
                    komut.Parameters.AddWithValue("@adsoyad", dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString());

                    komut.Parameters.AddWithValue("@ltetkik", lkodu);
                    komut.Parameters.AddWithValue("@tad", tad);
                    komut.ExecuteNonQuery();

                    MessageBox.Show("BAŞARILI");
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("BAŞARAMADIK ABİ");
                }
            }
            catch
            {

            }

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }
        private void verigetir()
        {
            try
            {
                baglanti.Open();
                string kayit = "SELECT * from teshisler";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                baglanti.Close();
            }
            catch
            {

            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (textBox8.Text == "")
                {
                    verigetirlabo();
                }
                else
                {
                    baglanti.Open();
                    string srg = textBox8.Text;
                    string sorgu = "Select * from laboratuvar_tetkikler where  tetkik_kodu Like '%" + srg + "%'";
                    SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
                    dataGridView5.DataSource = dt;
                    baglanti.Close();
                }
            }
            catch
            { }
        }

        private void verigetirlabo()
        {
            try
            {
                baglanti.Open();
                string kayit = "SELECT * from laboratuvar_tetkikler";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView5.DataSource = dt;
                baglanti.Close();
            }
            catch
            { }
        }

        private void verigetirradyo()
        {
            try
            {

                baglanti.Open();
                string kayit = "SELECT * from radyoloji_tetkikler";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView7.DataSource = dt;
                baglanti.Close();
            }
            catch { }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox9.Text == "")
                {
                    verigetirradyo();
                }
                else
                {

                    baglanti.Open();

                    string srg = textBox9.Text;
                    string sorgu = "Select * from radyoloji_tetkikler where  tetkik_kodu Like '%" + srg + "%'";
                    SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
                    dataGridView7.DataSource = dt;
                    baglanti.Close();
                }
            }
            catch { }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox17.Text == "")
                {
                    verigetirlabo();
                }
                else
                {

                    baglanti.Open();

                    string srg = textBox17.Text;
                    string sorgu = "Select * from laboratuvar_tetkikler where  tetkik_adi Like '%" + srg + "%'";
                    SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
                    dataGridView5.DataSource = dt;
                    baglanti.Close();
                }
            }
            catch { }
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox20.Text == "")
                {
                    verigetirradyo();
                }
                else
                {
                    baglanti.Open();
                    string srg = textBox20.Text;
                    string sorgu = "Select * from radyoloji_tetkikler where  tetkik_adi Like '%" + srg + "%'";
                    SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
                    dataGridView7.DataSource = dt;
                    baglanti.Close();
                }
            }
            catch { }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            textBox6.Text = "";
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            textBox7.Text = "";
        }


        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dataGridView8.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                    dataGridView8.Rows.RemoveAt(selectedIndex);
            }
            catch
            {
                MessageBox.Show("SİLİNECEK VERİ YOK !");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dataGridView8.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {


                    PrintPreviewDialog onizleme = new PrintPreviewDialog();
                    onizleme.Document = printDocument3;
                    onizleme.ShowDialog();
                    PrintDialog yazdir = new PrintDialog();
                    yazdir.Document = printDocument3;
                    yazdir.UseEXDialog = true;
                    if (yazdir.ShowDialog() == DialogResult.OK)
                    {
                        printDocument3.Print();
                    }
                }
            }
            catch
            {
                MessageBox.Show("LÜTFEN VERİLERİ EKSİKSİZ GİRDİĞİNİZE EMİN OLUN.");
            }

        }

        private void printDocument3_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int iLeftMargin = e.MarginBounds.Left;
                int iTopMargin = e.MarginBounds.Top;
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;
                bFirstPage = true;

                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dataGridView8.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;


                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }

                while (iRow <= dataGridView8.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dataGridView8.Rows[iRow];

                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;

                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {

                            e.Graphics.DrawString("Çıktı Başlığı", new System.Drawing.Font(dataGridView8.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Çıktı Başlığı", new System.Drawing.Font(dataGridView8.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new System.Drawing.Font(dataGridView8.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new System.Drawing.Font(dataGridView8.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Çıktı Başlığı", new System.Drawing.Font(new System.Drawing.Font(dataGridView8.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);


                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dataGridView8.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new System.Drawing.Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new System.Drawing.Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;

                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }

                            e.Graphics.DrawRectangle(Pens.Black, new System.Drawing.Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }


                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument3_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dataGridView8.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verigetirtedavi()
        {
            try
            {
                baglanti.Open();
                string kayit = "SELECT * from hasta_tedaviler";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView5.DataSource = dt;
                baglanti.Close();
            }
            catch { }
        }

        private void textBox15_TextChanged(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Delete)
                {
                    verigetirtedavi();
                }
                if (textBox15.Text == "")
                {
                    verigetirtedavi();
                }
                else
                {

                    baglanti.Open();

                    string srg = textBox15.Text;
                    string sorgu = "Select * from hasta_tedaviler where  tedavi_id Like '%" + srg + "%'";
                    SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
                    dataGridView9.DataSource = dt;
                    baglanti.Close();
                }
            }
            catch { }
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox23.Text == "")
                {
                    tedaviget();
                }
                else
                {

                    baglanti.Open();

                    string srg = textBox23.Text;
                    string sorgu = "Select * from hasta_tedaviler where  tedavi_adi Like '%" + srg + "%'";
                    SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
                    dataGridView9.DataSource = dt;
                    baglanti.Close();
                }
            }
            catch { }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox15.Text == "")
                {
                    verigetirtedavi();
                }
                else
                {

                    baglanti.Open();

                    string srg = textBox15.Text;
                    string sorgu = "Select * from hasta_tedaviler where  tedavi_id Like '%" + srg + "%'";
                    SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
                    dataGridView9.DataSource = dt;
                    baglanti.Close();
                }
            }
            catch { }
        }
        public string ilac_id = "";
        public string ilac_adi = "";
        private void dataGridView11_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string[] deger = new string[4];
                deger[0] = dataGridView11.CurrentRow.Cells[0].Value.ToString();
                deger[1] = dataGridView11.CurrentRow.Cells[1].Value.ToString();
                deger[2] = dataGridView11.CurrentRow.Cells[2].Value.ToString();
                deger[3] = dataGridView11.CurrentRow.Cells[3].Value.ToString();
                ilac_id += dataGridView11.CurrentRow.Cells[0].Value.ToString() + ",";
                ilac_adi += dataGridView11.CurrentRow.Cells[1].Value.ToString() + ";";
                dataGridView10.Rows.Add(deger[0], deger[1], deger[2], deger[3]);
            }
            catch { }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {

                //ilac id update etme
                if (textBox1.Text != "")
                {
                    baglanti.Open();
                    komut = new SqlCommand("UPDATE hasta_sonuclar SET ilac_id=@tid WHERE hasta_id=@hasta_id", baglanti);
                    komut.Parameters.AddWithValue("@hasta_id", textBox1.Text);
                    komut.Parameters.AddWithValue("@tid", ilac_id);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("basarılı");
                }
                else
                {
                    MessageBox.Show("HASTA SEÇİMİ YAPMADINIZ.");
                }
                //ilac id update etme

                //muayene veritabanına hasta ilac adi ekleme
                baglanti.Open();
                komut = new SqlCommand("UPDATE hasta_muayene SET hasta_ilacadi=@ilac WHERE hasta_id=@hasta_id", baglanti);
                komut.Parameters.AddWithValue("@hasta_id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                komut.Parameters.AddWithValue("@ilac", ilac_adi);
                komut.ExecuteNonQuery();
                baglanti.Close();
                //muayene veritabanına hasta ilac adi ekleme

            }
            catch
            {
                MessageBox.Show("LÜTFEN VERİLERİ EKSİKSİZ GİRDİĞİNİZE EMİN OLUN.");

            }


        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void istirahatgetir()
        {
            try
            {
                baglanti.Open();
                string kayit = "SELECT * from hasta_istirahat WHERE hasta_id=@hid";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@hid", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView13.DataSource = dt;
                baglanti.Close();
            }
            catch { }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                komut = new SqlCommand("INSERT INTO hasta_istirahat(hasta_id,hasta_teshis,hasta_bassure,hasta_raporsure,hasta_bitsure,hasta_doktor) VALUES(@hid,@teshis,@bassure,@rsure,@bitsure,@doktor)", baglanti);
                komut.Parameters.AddWithValue("@hid", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                komut.Parameters.AddWithValue("@teshis", comboBox11.Text);
                komut.Parameters.AddWithValue("@bassure", dateTimePicker3.Text);
                komut.Parameters.AddWithValue("@rsure", comboBox14.Text);
                komut.Parameters.AddWithValue("@bitsure", dateTimePicker4.Text);
                komut.Parameters.AddWithValue("@doktor", comboBox13.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                istirahatgetir();
            }
            catch
            {
                MessageBox.Show("LÜTFEN VERİLERİ EKSİKSİZ GİRDİĞİNİZE EMİN OLUN.");

            }

        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int i = 0;

                while (i < 14)
                {
                    if (comboBox14.SelectedIndex == i) dateTimePicker4.Text = DateTime.Now.AddDays(i + 1).ToLongDateString();
                    i++;

                }
            }
            catch { }
        }

        private void button22_Click(object sender, EventArgs e)
        {

            try
            {
                int selectedIndex = dataGridView13.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                    dataGridView13.Rows.RemoveAt(selectedIndex);
            }
            catch
            {
                MessageBox.Show("SİLİNECEK VERİ YOK !!!");
            }
            istirahatgetir();
        }

        private void printDocument4_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int iLeftMargin = e.MarginBounds.Left;
                int iTopMargin = e.MarginBounds.Top;
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;
                bFirstPage = true;

                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dataGridView13.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;


                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }

                while (iRow <= dataGridView13.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dataGridView13.Rows[iRow];

                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;

                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {

                            e.Graphics.DrawString("Çıktı Başlığı", new System.Drawing.Font(dataGridView13.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Çıktı Başlığı", new System.Drawing.Font(dataGridView13.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new System.Drawing.Font(dataGridView13.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new System.Drawing.Font(dataGridView13.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Çıktı Başlığı", new System.Drawing.Font(new System.Drawing.Font(dataGridView13.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);


                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dataGridView13.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new System.Drawing.Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new System.Drawing.Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;

                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }

                            e.Graphics.DrawRectangle(Pens.Black, new System.Drawing.Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }


                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument4_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dataGridView13.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPreviewDialog onizleme = new PrintPreviewDialog();
                onizleme.Document = printDocument4;
                onizleme.ShowDialog();
                PrintDialog yazdir = new PrintDialog();
                yazdir.Document = printDocument4;
                yazdir.UseEXDialog = true;
                if (yazdir.ShowDialog() == DialogResult.OK)
                {
                    printDocument4.Print();
                }
            }

            catch
            {
                MessageBox.Show("LÜTFEN VERİLERİ EKSİKSİZ GİRDİĞİNİZE EMİN OLUN.");
            }

        }


        private void button15_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("DELETE FROM hasta_dosyalar WHERE hasta_id=@hid AND dosya_id =@did", baglanti);
            komut.Parameters.AddWithValue("@hid", dataGridView12.CurrentRow.Cells[1].Value.ToString());
            komut.Parameters.AddWithValue("@did", dataGridView12.CurrentRow.Cells[0].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            try
            {
                int selectedIndex = dataGridView12.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                    dataGridView12.Rows.RemoveAt(selectedIndex);
            }
            catch
            {
                MessageBox.Show("SİLİNECEK VERİ YOK !!!");
            }

            dosyagetir();
        }

        private void dataGridView12_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string metin = dataGridView12.CurrentRow.Cells[6].Value.ToString();
            axAcroPDF1.LoadFile(metin);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("DELETE FROM hasta WHERE hasta_kodu=@hid", baglanti);
            komut.Parameters.AddWithValue("@hid", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            try
            {
                int selectedIndex = dataGridView1.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                    dataGridView1.Rows.RemoveAt(selectedIndex);
            }
            catch
            {
                MessageBox.Show("SİLİNECEK VERİ YOK !!!");
            }

            tablo();

            int[] dizi = new int[dataGridView1.Rows.Count];
            DataGridViewCellStyle renk = new DataGridViewCellStyle();
            DataGridViewCellStyle renk2 = new DataGridViewCellStyle();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dizi[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                if (dizi[i] % 2 == 0)
                {
                    renk.BackColor = Color.LightBlue;
                    dataGridView1.Rows[i].DefaultCellStyle = renk;
                }
                else
                {
                    renk2.BackColor = Color.LightGray;
                    dataGridView1.Rows[i].DefaultCellStyle = renk2;
                }

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            admin_doktor_ichastalik_gh gh = new admin_doktor_ichastalik_gh();
            gh.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dataGridView10.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                    dataGridView10.Rows.RemoveAt(selectedIndex);
            }
            catch
            {
                MessageBox.Show("SİLİNECEK VERİ YOK !");
            }

        }

        private void dataGridView9_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string[] deger = new string[2];
                deger[0] = dataGridView9.CurrentRow.Cells[0].Value.ToString();
                deger[1] = dataGridView9.CurrentRow.Cells[1].Value.ToString();
                tedavi_id += dataGridView9.CurrentRow.Cells[0].Value.ToString() + ",";
                tedavi_adi += dataGridView9.CurrentRow.Cells[1].Value.ToString() + ",";
                dataGridView8.Rows.Add(deger[0], deger[1]);
            }
            catch { }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dataGridView10.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {


                    PrintPreviewDialog onizleme = new PrintPreviewDialog();
                    onizleme.Document = printDocument5;
                    onizleme.ShowDialog();
                    PrintDialog yazdir = new PrintDialog();
                    yazdir.Document = printDocument5;
                    yazdir.UseEXDialog = true;
                    if (yazdir.ShowDialog() == DialogResult.OK)
                    {
                        printDocument5.Print();
                    }
                }
            }
            catch
            {
                MessageBox.Show("LÜTFEN VERİLERİ EKSİKSİZ GİRDİĞİNİZE EMİN OLUN.");
            }

        }

        private void printDocument5_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int iLeftMargin = e.MarginBounds.Left;
                int iTopMargin = e.MarginBounds.Top;
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;
                bFirstPage = true;

                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dataGridView10.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;


                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }

                while (iRow <= dataGridView10.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dataGridView10.Rows[iRow];

                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;

                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {

                            e.Graphics.DrawString("Çıktı Başlığı", new System.Drawing.Font(dataGridView10.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Çıktı Başlığı", new System.Drawing.Font(dataGridView10.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new System.Drawing.Font(dataGridView10.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new System.Drawing.Font(dataGridView10.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Çıktı Başlığı", new System.Drawing.Font(new System.Drawing.Font(dataGridView10.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);


                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dataGridView10.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new System.Drawing.Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new System.Drawing.Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;

                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }

                            e.Graphics.DrawRectangle(Pens.Black, new System.Drawing.Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }


                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument5_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dataGridView10.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView6_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string[] deger = new string[2];
                deger[0] = dataGridView6.CurrentRow.Cells[0].Value.ToString();
                deger[1] = dataGridView6.CurrentRow.Cells[1].Value.ToString();
                rkodu += dataGridView6.CurrentRow.Cells[0].Value.ToString() + ",";
                radkod += dataGridView6.CurrentRow.Cells[1].Value.ToString() + ";";
                dataGridView7.Rows.Add(deger[0], deger[1]);
            }
            catch { }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    baglanti.Open();
                    komut = new SqlCommand("UPDATE radyoloji_sonuclar SET hasta_adsoyad=@adsoyad,radyoloji_tetkikler_id = @rkodu,radyoloji_tetkik_adi=@radkod,sonuc=1 WHERE hasta_id=@hasta_id", baglanti);
                    komut.Parameters.AddWithValue("@hasta_id", textBox1.Text);
                    komut.Parameters.AddWithValue("@adsoyad", dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString());

                    komut.Parameters.AddWithValue("@rkodu", rkodu);
                    komut.Parameters.AddWithValue("@radkod", radkod);
                    komut.ExecuteNonQuery();

                    MessageBox.Show("BAŞARILI");
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("BAŞARAMADIK ABİ");
                }
            }
            catch { }
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            tablo();
            renk_fonksiyon();
        }
    }
}
