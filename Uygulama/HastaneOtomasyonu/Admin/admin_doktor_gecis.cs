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
    public partial class admin_doktor_gecis : Form
    {
        public admin_doktor_gecis()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ToString());
        SqlCommand komut;
        SqlDataReader dr;
        DataSet ds;

        private void admin_doktor_gecis_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("SELECT * FROM bolum", baglanti);
            dr = komut.ExecuteReader();
            while(dr.Read())
            {
                comboBox1.Items.Add(dr["bolum_ad"]);
            }
            baglanti.Close();
            comboBox1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                DoktorForm.admin_doktor_noroloji adn = new DoktorForm.admin_doktor_noroloji();
                adn.Show();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                DoktorForm.admin_doktor_kardiyoloji adn = new DoktorForm.admin_doktor_kardiyoloji();
                adn.Show();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                DoktorForm.admin_doktor_ortopedi adn = new DoktorForm.admin_doktor_ortopedi();
                adn.Show();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                DoktorForm.admin_doktor_ftr adn = new DoktorForm.admin_doktor_ftr();
                adn.Show();
            }
            if (comboBox1.SelectedIndex == 4)
            {
                DoktorForm.admin_doktor_cocuk adn = new DoktorForm.admin_doktor_cocuk();
                adn.Show();
            }
            if (comboBox1.SelectedIndex == 5)
            {
                DoktorForm.admin_doktor_ichastalik adn = new DoktorForm.admin_doktor_ichastalik();
                adn.Show();
            }
            if (comboBox1.SelectedIndex == 6)
            {
                DoktorForm.admin_doktor_kadind adn = new DoktorForm.admin_doktor_kadind();
                adn.Show();
            }
            if (comboBox1.SelectedIndex == 7) 
            {
                DoktorForm.admin_doktor_psikiyatri adn = new DoktorForm.admin_doktor_psikiyatri();
                adn.Show();
            }
            if (comboBox1.SelectedIndex == 8)
            {
                DoktorForm.admin_doktor_dermatoloji adn = new DoktorForm.admin_doktor_dermatoloji();
                adn.Show();
            }
            if (comboBox1.SelectedIndex == 9)
            {
                DoktorForm.admin_doktor_kbb adn = new DoktorForm.admin_doktor_kbb();
                adn.Show();
            }
            if (comboBox1.SelectedIndex == 10)
            {
                DoktorForm.admin_doktor_goz adn = new DoktorForm.admin_doktor_goz();
                adn.Show();
            }
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
