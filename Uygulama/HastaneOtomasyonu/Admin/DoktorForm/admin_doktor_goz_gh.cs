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

namespace Uygulama.Admin.DoktorForm
{
    public partial class admin_doktor_goz_gh : Form
    {
        public admin_doktor_goz_gh()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ToString());
        SqlCommand komut;
        SqlDataReader dr;

        private void admin_doktor_goz_gh_Load(object sender, EventArgs e)
        {
            //this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            string kayit = "SELECT hasta.hasta_kodu,hasta.hasta_adi,hasta.hasta_soyadi,hasta.hasta_tcno,hasta.hasta_pasaportno,hasta.hasta_babaadi,hasta.hasta_anneadi,hasta.hasta_dtarihi,hasta.hasta_dyeri,hasta.hasta_cinsiyet,hasta.hasta_boyu,hasta.hasta_kilosu,hasta.hasta_meslegi,hasta.hasta_kayittarihi,hasta.hasta_il,hasta.hasta_ilce,hasta.hasta_mahalle_koy,hasta.hasta_cadde_sokak,hasta.hasta_cepno,hasta.hasta_evno,hasta.hasta_isno,hasta.hasta_email,hasta.hasta_sigara,hasta.hasta_alkol,hasta.hasta_kangrubu,hasta.hasta_hepatit,hasta.hasta_hiv,hasta.hasta_diyabet,hasta.hasta_kulilac,hasta.hasta_gechastalik,hasta.hasta_ailehastalik,hasta.hasta_gecameliyat,hasta.hasta_resim,hasta.hasta_ozcesmis,hasta.hasta_soygecmis,hasta.hasta_esadi,hasta.hasta_essoyadi,hasta.hasta_estelno,hasta.hasta_esmeslegi,hasta.hasta_es_kangrubu,hasta.hasta_uyari_mesaj,hasta.hasta_muayene FROM hasta,doktor WHERE hasta.hasta_doktorid=11 AND doktor.doktor_id=11 AND hasta.hasta_muayene=0";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
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
    }
}
