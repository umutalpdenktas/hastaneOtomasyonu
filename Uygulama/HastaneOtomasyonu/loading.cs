using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Giris.giris_ekrani ac = new Giris.giris_ekrani();
            ac.Show();
            this.Visible = false;
            timer1.Stop();
            timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text += ".";
        }

        private void loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            Font x = label1.Font;
            label1.Font = new Font(x.FontFamily, x.Size + 6, x.Style);
            label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2baa97");
        }
    }
}
