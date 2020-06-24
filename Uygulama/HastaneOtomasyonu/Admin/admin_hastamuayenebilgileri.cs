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

namespace Uygulama.Admin
{
    public partial class admin_hastamuayenebilgileri : Form
    {
        public admin_hastamuayenebilgileri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ToString());
        SqlCommand komut;
        SqlDataReader dr;
        DataSet ds;

        private void button1_Click(object sender, EventArgs e)
        {
            admin_hastalistesi_yenikayit yeni = new admin_hastalistesi_yenikayit();
            yeni.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void admin_hastamuayenebilgileri_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("SELECT * FROM hasta WHERE hasta_tcno = @tcno", baglanti);
            komut.Parameters.AddWithValue("@tcno", admin_hastalistesi.gonderilecekveri2);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
