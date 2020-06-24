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
using System.IO;
using System.Collections;
using System.Configuration;


namespace Uygulama.Admin
{
    public partial class admin_hastalistesi : Form
    {
        public admin_hastalistesi()
        {
            InitializeComponent();
        }
        public static string gonderilecekveri;
        public static string gonderilecekveri2;

        private void button1_Click(object sender, EventArgs e)
        {
            admin_hastalistesi_yenikayit yeni = new admin_hastalistesi_yenikayit();
            yeni.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_hasta_duzenle ahd = new admin_hasta_duzenle();
            gonderilecekveri = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ahd.Show();
            //admin_hasta_duzenle2 ahd = new admin_hasta_duzenle2();
            //gonderilecekveri = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //ahd.Show();

        }

        private void getir()
        {
            baglanti.Open();
            komut = new SqlCommand("SELECT * FROM hasta", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);            
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ToString());
        SqlCommand komut;
        SqlDataReader dr;
        DataSet ds;

        private void admin_hastalistesi_Load(object sender, EventArgs e)
        {
            //data grıd view Renklendirme
           
            // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet6.hasta' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastaTableAdapter3.Fill(this.hastane_otomasyonu_yDataSet6.hasta);
            // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet5.hasta' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastaTableAdapter2.Fill(this.hastane_otomasyonu_yDataSet5.hasta);
            // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet2.hasta' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.hastaTableAdapter1.Fill(this.hastane_otomasyonu_yDataSet2.hasta);

            // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet.hasta' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            getir();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            baglanti.Open();
            string sql= ("SELECT * FROM hasta WHERE (hasta_adi LIKE '%" + (textBox3.Text + "%')"));
            komut = new SqlCommand(sql, baglanti);
            komut.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }

        private void verigetir()
        {
            baglanti.Open();
            string kayit = "SELECT * from hasta";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                verigetir();
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
            else
            {

                baglanti.Open();

                string srg = textBox2.Text;
                string sorgu = "Select * from hasta where  hasta_tcno Like '%" + srg + "%'";
                SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                adap.Fill(dt);
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                if (textBox3.Text != "")
                {
                    string srg1 = textBox1.Text;
                    string sorgu1 = "Select * from hasta where hasta_adi Like '%" + textBox3.Text + "%' AND hasta_soyadi Like '%" + srg1 + "%'";
                    SqlDataAdapter adap = new SqlDataAdapter(sorgu1, baglanti);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
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
                else
                {
                    string srg = textBox1.Text;
                    string sorgu = "Select * from hasta where  hasta_soyadi Like '%" + srg + "%'";
                    SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
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
            else
            {

                baglanti.Open();

                string srg = textBox3.Text;
                string sorgu = "Select * from hasta where  hasta_adi Like '%" + srg + "%'";
                SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                adap.Fill(dt);
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

        DataTable dt = new DataTable("hasta");
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("hasta_adi LIKE '%{0}%'", textBox3.Text);
                dataGridView1.DataSource = dv.ToTable();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            baglanti.Open();
            string sql = ("SELECT * FROM hasta WHERE (hasta_tcno LIKE '%" + (textBox2.Text + "%')"));
            komut = new SqlCommand(sql, baglanti);
            komut.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //cumbubux yanlıs çalısıyo
            //baglanti.Open();
            //string sql = ("SELECT * FROM hasta WHERE (hasta_kangrubu LIKE '%" + (comboBox6.Text + "%')"));
            //komut = new SqlCommand(sql, baglanti);
            //komut.ExecuteNonQuery();
            //SqlDataAdapter da = new SqlDataAdapter(komut);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //baglanti.Close();
            //if (comboBox6.Text != "")
            //{
            //    timer3.Stop();
            //}

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox6.Text != "")
            {
                string srg1 = comboBox6.Text;
                string sorgu1 = "Select * from hasta where hasta_kangrubu Like '%" + srg1 + "%'";
                SqlDataAdapter adap = new SqlDataAdapter(sorgu1, baglanti);
                DataTable dt = new DataTable();
                adap.Fill(dt);
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

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("DELETE FROM hasta WHERE hasta_tcno=@htc", baglanti);
            komut.Parameters.AddWithValue("@htc", dataGridView1.CurrentRow.Cells[3].Value.ToString());
            komut.ExecuteNonQuery();
            MessageBox.Show("Veri başarıyla silinmiştir.");
            baglanti.Close();
            getir();
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

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            getir();
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            admin_hastamuayenebilgileri mua = new admin_hastamuayenebilgileri();
            gonderilecekveri2 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            mua.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
                SaveFileDialog save = new SaveFileDialog();
                save.OverwritePrompt = false;
                save.Title = "Excel Dosyaları";
                save.DefaultExt = "xlsx";
                save.Filter = "xlsx Dosyaları (*.xlsx)|*.xlsx|Tüm Dosyalar(*.*)|*.*";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                    app.Visible = true;
                    worksheet = workbook.Sheets["Sayfa1"];
                    worksheet = workbook.ActiveSheet;
                    worksheet.Name = "Excel Dışa Aktarım";
                    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    app.Quit();
                }
            
            
        }
        

        private void button7_Click(object sender, EventArgs e)
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
                    foreach (DataGridViewColumn GridCol in dataGridView1.Columns)
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

                while (iRow <= dataGridView1.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dataGridView1.Rows[iRow];

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

                            e.Graphics.DrawString("Çıktı Başlığı", new System.Drawing.Font(dataGridView1.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Çıktı Başlığı", new System.Drawing.Font(dataGridView1.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new System.Drawing.Font(dataGridView1.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new System.Drawing.Font(dataGridView1.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Çıktı Başlığı", new System.Drawing.Font(new System.Drawing.Font(dataGridView1.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);


                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dataGridView1.Columns)
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
                foreach (DataGridViewColumn dgvGridCol in dataGridView1.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            admin_mailhepsi yeni = new admin_mailhepsi();
            yeni.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                //verigetir();
                //textBox3.Text = "";
                baglanti.Open();

                string srg = textBox3.Text;
                string sorgu = "Select * from hasta where  hasta_adi Like '%" + srg + "%'";
                SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                adap.Fill(dt);
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
            else
            {

                baglanti.Open();
                if(textBox3.Text != "")
                {
                    string srg1 = textBox1.Text;
                    string sorgu1 = "Select * from hasta where hasta_adi Like '%" + textBox3.Text + "%' AND hasta_soyadi Like '%" + srg1 + "%'";
                    SqlDataAdapter adap = new SqlDataAdapter(sorgu1, baglanti);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
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
                else
                {
                    string srg = textBox1.Text;
                    string sorgu = "Select * from hasta where  hasta_soyadi Like '%" + srg + "%'";
                    SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
