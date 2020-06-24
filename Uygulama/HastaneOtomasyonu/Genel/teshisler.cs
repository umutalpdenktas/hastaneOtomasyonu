using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama.Genel
{
    public partial class teshisler : Form
    {
        public teshisler()
        {
            InitializeComponent();
        }

        private void teshisler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastane_otomasyonu_yDataSet11.teshisler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.teshislerTableAdapter.Fill(this.hastane_otomasyonu_yDataSet11.teshisler);
            
            
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         

           
        }
    }
}
