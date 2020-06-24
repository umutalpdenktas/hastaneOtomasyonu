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


namespace Uygulama.HastaKabul
{
    public partial class hastakabul_hastalistesi_duzenle : Form
    {
        public hastakabul_hastalistesi_duzenle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ToString());
        SqlCommand komut;
        SqlDataReader dr;

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sql = "UPDATE hasta SET hasta_adi=@had,hasta_soyadi=@hsoyad,hasta_tcno=@htcno,hasta_pasaportno=@hpn,hasta_babaadi=@hbad,hasta_anneadi=@haad,hasta_dtarihi=@hdt,hasta_dyeri=@hdy,hasta_cinsiyet=@hcins,hasta_boyu=@hboy,hasta_kilosu=@hkilo,hasta_meslegi=@hmeslegi,hasta_il=@hil,hasta_ilce=@hilce,hasta_mahalle_koy=@hmk,hasta_cadde_sokak=@hcs,hasta_cepno=@hcepno,hasta_evno=@hevno,hasta_isno=@hisno,hasta_email=@hmail,hasta_sigara=@hsigara,hasta_alkol=@halkol,hasta_kangrubu=@hkg,hasta_hepatit=@hhepa,hasta_hiv=@hhiv,hasta_diyabet=@hdiy,hasta_kulilac=@hki,hasta_gechastalik=@hgh,hasta_ailehastalik=@hai,hasta_gecameliyat=@hgeca,hasta_resim=@hresim,hasta_ozcesmis=@hozg,hasta_soygecmis=@hsoygecmis,hasta_esadi=@hesadi,hasta_essoyadi=@hessoyadi,hasta_estelno=@hestel,hasta_esmeslegi=@hesmeslek,hasta_es_kangrubu=@heskan,hasta_uyari_mesaj=@huyari WHERE hasta_kodu=@hkod";
            komut = new SqlCommand(sql, baglanti);

            komut.Parameters.AddWithValue("@hkod", textBox1.Text);
            komut.Parameters.AddWithValue("@had", textBox2.Text);
            komut.Parameters.AddWithValue("@hsoyad", textBox3.Text);
            komut.Parameters.AddWithValue("@htcno", textBox5.Text);
            komut.Parameters.AddWithValue("@hpn", textBox6.Text);
            komut.Parameters.AddWithValue("@hbad", textBox7.Text);
            komut.Parameters.AddWithValue("@haad", textBox8.Text);
            komut.Parameters.AddWithValue("@hdt", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@hdy", textBox9.Text);
            komut.Parameters.AddWithValue("@hcins", comboBox1.Text);
            komut.Parameters.AddWithValue("@hboy", textBox10.Text);
            komut.Parameters.AddWithValue("@hkilo", textBox11.Text);
            komut.Parameters.AddWithValue("@hmeslegi", textBox12.Text);
            komut.Parameters.AddWithValue("@hil", comboBox2.Text);
            komut.Parameters.AddWithValue("@hilce", comboBox3.Text);
            komut.Parameters.AddWithValue("@hmk", textBox13.Text);
            komut.Parameters.AddWithValue("@hcs", textBox14.Text);
            komut.Parameters.AddWithValue("@hcepno", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@hevno", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("@hisno", maskedTextBox3.Text);
            komut.Parameters.AddWithValue("@hmail", textBox18.Text);
            komut.Parameters.AddWithValue("@hsigara", comboBox4.Text);
            komut.Parameters.AddWithValue("@halkol", comboBox5.Text);
            komut.Parameters.AddWithValue("@hkg", comboBox6.Text);
            komut.Parameters.AddWithValue("@hhepa", comboBox7.Text);
            komut.Parameters.AddWithValue("@hhiv", comboBox8.Text);
            komut.Parameters.AddWithValue("@hdiy", comboBox9.Text);
            komut.Parameters.AddWithValue("@hki", richTextBox1.Text);
            komut.Parameters.AddWithValue("@hgh", richTextBox2.Text);
            komut.Parameters.AddWithValue("@hai", richTextBox3.Text);
            komut.Parameters.AddWithValue("@hgeca", richTextBox4.Text);
            komut.Parameters.AddWithValue("@hresim", textBox22.Text);

            string hastaozgecmis = "";
            for (int i = 0; i < checkedListBo3.CheckedItems.Count; i++)
            {
                hastaozgecmis += (checkedListBo3.CheckedItems[i] + ",");

            }
            komut.Parameters.AddWithValue("@hozg", hastaozgecmis);
            string hastasoygecmis = "";
            for (int i = 0; i < checkedListBox2.CheckedItems.Count; i++)
            {
                hastasoygecmis += (checkedListBox2.CheckedItems[i] + ",");
            }
            komut.Parameters.AddWithValue("@hsoygecmis", hastasoygecmis);
            komut.Parameters.AddWithValue("@hesadi", textBox19.Text);
            komut.Parameters.AddWithValue("@hessoyadi", textBox4.Text);
            komut.Parameters.AddWithValue("@hestel", maskedTextBox4.Text);
            komut.Parameters.AddWithValue("@hesmeslek", textBox21.Text);
            komut.Parameters.AddWithValue("@heskan", comboBox10.Text);
            komut.Parameters.AddWithValue("@huyari", richTextBox5.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt İşlemi Başarılı.");
        }

        private void hastakabul_hastalistesi_duzenle_Load(object sender, EventArgs e)
        {
            //HASTANIN KODUNA GORE BİLGİERLİNİ DOLDURMA
            baglanti.Open();
            komut = new SqlCommand("SELECT * FROM hasta WHERE hasta_kodu =@veri ", baglanti);
            komut.Parameters.AddWithValue("@veri", hastakabul_hastalistesi.gonderilecekveri);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["hasta_kodu"].ToString();
                textBox2.Text = dr["hasta_adi"].ToString();
                textBox3.Text = dr["hasta_soyadi"].ToString();
                textBox5.Text = dr["hasta_tcno"].ToString();
                textBox6.Text = dr["hasta_pasaportno"].ToString();
                textBox7.Text = dr["hasta_babaadi"].ToString();
                textBox8.Text = dr["hasta_anneadi"].ToString();
                dateTimePicker1.Text = dr["hasta_dtarihi"].ToString();
                textBox9.Text = dr["hasta_dyeri"].ToString();
                comboBox1.Text = dr["hasta_cinsiyet"].ToString();
                textBox10.Text = dr["hasta_boyu"].ToString();
                textBox11.Text = dr["hasta_kilosu"].ToString();
                textBox12.Text = dr["hasta_meslegi"].ToString();
                dateTimePicker2.Text = dr["hasta_kayittarihi"].ToString();
                comboBox2.Text = dr["hasta_il"].ToString();
                comboBox3.Text = dr["hasta_ilce"].ToString();
                textBox13.Text = dr["hasta_mahalle_koy"].ToString();
                textBox14.Text = dr["hasta_cadde_sokak"].ToString();
                maskedTextBox1.Text = dr["hasta_cepno"].ToString();
                maskedTextBox2.Text = dr["hasta_evno"].ToString();
                maskedTextBox3.Text = dr["hasta_isno"].ToString();
                textBox18.Text = dr["hasta_email"].ToString();
                comboBox4.Text = dr["hasta_sigara"].ToString();
                comboBox5.Text = dr["hasta_alkol"].ToString();
                comboBox6.Text = dr["hasta_kangrubu"].ToString();
                comboBox7.Text = dr["hasta_hepatit"].ToString();
                comboBox8.Text = dr["hasta_hiv"].ToString();
                comboBox9.Text = dr["hasta_diyabet"].ToString();
                richTextBox1.Text = dr["hasta_kulilac"].ToString();
                richTextBox2.Text = dr["hasta_gechastalik"].ToString();
                richTextBox3.Text = dr["hasta_ailehastalik"].ToString();
                richTextBox4.Text = dr["hasta_gecameliyat"].ToString();
                textBox22.Text = dr["hasta_resim"].ToString();
                pictureBox1.ImageLocation = textBox22.Text;
                string metin = dr["hasta_ozcesmis"].ToString();
                char ayrac = ',';
                string[] ayrim = metin.Split(ayrac);
                string[] dizi = new string[checkedListBo3.Items.Count];
                for (int i = 0; i < checkedListBo3.Items.Count; i++)
                {
                    dizi[i] = checkedListBo3.Items[i].ToString();
                }
                for (int j = 0; j < checkedListBo3.Items.Count; j++)
                {
                    for (int a = 0; a < ayrim.Length; a++)
                    {
                        if (ayrim[a].ToString() == dizi[j].ToString())
                        {
                            checkedListBo3.SetItemChecked(j, true);
                        }
                    }
                }

                string soy_gecmis = dr["hasta_soygecmis"].ToString();
                char ayrac2 = ',';
                string[] ayrim2 = soy_gecmis.Split(ayrac2);
                string[] dizi2 = new string[checkedListBox2.Items.Count];
                for (int i = 0; i < checkedListBox2.Items.Count; i++)
                {
                    dizi2[i] = checkedListBox2.Items[i].ToString();
                }
                for (int a = 0; a < checkedListBox2.Items.Count; a++)
                {
                    for (int b = 0; b < ayrim2.Length; b++)
                    {
                        if (ayrim2[b].ToString() == dizi2[a].ToString())
                        {
                            checkedListBox2.SetItemChecked(a, true);
                        }
                    }
                }

                richTextBox5.Text = dr["hasta_uyari_mesaj"].ToString();
                textBox19.Text = dr["hasta_esadi"].ToString();
                textBox4.Text = dr["hasta_essoyadi"].ToString();
                maskedTextBox4.Text = dr["hasta_estelno"].ToString();
                textBox21.Text = dr["hasta_esmeslegi"].ToString();
                comboBox10.Text = dr["hasta_es_kangrubu"].ToString();

                baglanti.Close();



            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //RESİM EKLEME
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Tüm Dosyalar |*.*";
            dosya.Title = "SAU Hastanesi";
            dosya.ShowDialog();
            pictureBox1.ImageLocation = dosya.FileName;
            textBox22.Text = dosya.FileName;
        }
    }
}
