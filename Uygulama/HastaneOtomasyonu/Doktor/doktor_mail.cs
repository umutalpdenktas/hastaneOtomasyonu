using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using System.Data.SqlClient;

namespace Uygulama.Doktor
{
    public partial class doktor_mail : Form
    {
        public doktor_mail()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ToString());
        SqlConnection baglanti2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ToString());
        SqlCommand komut;
        SqlCommand komut2;
        SqlDataReader dr;
        SqlDataReader dr2;

        public static string ad;

        public void kimden()
        {
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string veri = "";
            baglanti2.Open();
            komut2 = new SqlCommand("SELECT * FROM doktor WHERE doktor_id = @id", baglanti2);
            komut2.Parameters.AddWithValue("@id", Giris.giris_ekrani.tutt);
            SqlDataReader dr2;
            dr2 = komut2.ExecuteReader();
            if (dr2.Read())
            {
                ad = dr2["doktor_ad"].ToString() + " " + dr2["doktor_soyad"].ToString();
            }
            baglanti.Close();

            string[] degisken = new string[listBox2.Items.Count];
            string yazi = "SAU Hastanesinden Mesaj var. " + textBox1.Text;
            MailMessage mail = new MailMessage();
            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
            
            mail.From = new MailAddress("alperemekci006@gmail.com");//MAİLİ GÖNDEREN KİŞİ
            for(int i=0;i<listBox2.Items.Count;i++)
            {
                mail.To.Add(listBox2.Items[i].ToString());//Maili giden kişinin mailini
            }          
            mail.Subject = "SAU Hastanesinden Mesaj var. " + textBox1.Text;
            mail.Body = richTextBox2.Text ;
            Attachment attachment;
            attachment = new Attachment(listBox1.Items[0].ToString());
            mail.Attachments.Add(attachment);
            baglanti.Open();
            komut = new SqlCommand("INSERT INTO mail(kime,konu,icerik,tarih,kimden) VALUES(@kime,@konu,@icerik,@tarih,@kimden)", baglanti);
            komut.Parameters.AddWithValue("@kimden", ad);
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                degisken[i] = listBox2.Items[i].ToString() + " ";//Maili giden kişinin mailini
            }
            for(int j=0;j<degisken.Length;j++)
            {
                veri += degisken[j].ToString();
                
            }
            komut.Parameters.AddWithValue("@kime", veri);
            komut.Parameters.AddWithValue("@konu", yazi);
            komut.Parameters.AddWithValue("@icerik", richTextBox2.Text + " " + listBox1.Items[0].ToString());
            komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToLongDateString());
            komut.ExecuteNonQuery();
            baglanti.Close();

            smtpServer.Port = 587;
            smtpServer.Credentials = new System.Net.NetworkCredential("alperemekci006@gmail.com", "alper123deneme");//HASTANENİN MAİLİ VE ŞİFRESİ
            smtpServer.EnableSsl = true;
            smtpServer.Send(mail);
            MessageBox.Show("Mesajınız başarıyla gönderilmiştir.");
            
        }

        private void doktor_mail_Load(object sender, EventArgs e)
        {           
            // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet29.doktor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.doktorTableAdapter2.Fill(this.hastane_otomasyonu_yDataSet29.doktor);
            // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet28.doktor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.doktorTableAdapter1.Fill(this.hastane_otomasyonu_yDataSet28.doktor);
            // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet27.doktor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.doktorTableAdapter.Fill(this.hastane_otomasyonu_yDataSet27.doktor);

            // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet4.hasta' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastaTableAdapter1.Fill(this.hastane_otomasyonu_yDataSet4.hasta);
            // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet3.hasta' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastaTableAdapter.Fill(this.hastane_otomasyonu_yDataSet3.hasta);

            try
            {
                string kayit = "SELECT * FROM hasta WHERE hasta_doktorid=@id";
                baglanti.Open();
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                
                komut.Parameters.AddWithValue("@id", Giris.giris_ekrani.tutt);
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            listBox2.Items.Add(dataGridView1.CurrentRow.Cells[21].Value.ToString());
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //1 tane string dizi değişkeni tanımlıyoruz.
            string[] secilendosyayolu;
            //dosya seçtirmek için dialoğu çıkartıyoruz.
            openFileDialog1.ShowDialog();
            //seçtiğimiz dosyanın yolunu dizimize alıyoruz.
            secilendosyayolu = openFileDialog1.FileNames;
            //dosyayının uzunluğu kadar dönüp listboxa basıyoruz.
            for (int i = 0; i < secilendosyayolu.Length; i++)
            {
                listBox1.Items.Add(secilendosyayolu[i]);
            }
        }

       

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            listBox2.Items.Add(dataGridView3.CurrentRow.Cells[5].Value.ToString());
        }
    }
}
