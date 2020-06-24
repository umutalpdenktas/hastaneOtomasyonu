namespace Uygulama.Laboratuvar
{
    partial class laboratuvar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(laboratuvar));
            this.hasta_sonuclarTableAdapter2 = new Uygulama.hastane_otomasyonu_yDataSet26TableAdapters.hasta_sonuclarTableAdapter();
            this.hastadosyalarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hastane_otomasyonu_yDataSet25 = new Uygulama.hastane_otomasyonu_yDataSet25();
            this.hasta_dosyalarTableAdapter = new Uygulama.hastane_otomasyonu_yDataSet24TableAdapters.hasta_dosyalarTableAdapter();
            this.hastadosyalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastane_otomasyonu_yDataSet24 = new Uygulama.hastane_otomasyonu_yDataSet24();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button6 = new System.Windows.Forms.Button();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.hasta_sonuclarTableAdapter1 = new Uygulama.hastane_otomasyonu_yDataSet23TableAdapters.hasta_sonuclarTableAdapter();
            this.hastasonuclarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hastane_otomasyonu_yDataSet23 = new Uygulama.hastane_otomasyonu_yDataSet23();
            this.hasta_sonuclarTableAdapter = new Uygulama.hastane_otomasyonu_yDataSet22TableAdapters.hasta_sonuclarTableAdapter();
            this.hastasonuclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastane_otomasyonu_yDataSet22 = new Uygulama.hastane_otomasyonu_yDataSet22();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.hastane_otomasyonu_yDataSet26 = new Uygulama.hastane_otomasyonu_yDataSet26();
            this.hastasonuclarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hasta_dosyalarTableAdapter1 = new Uygulama.hastane_otomasyonu_yDataSet25TableAdapters.hasta_dosyalarTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.hastadosyalarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_otomasyonu_yDataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastadosyalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_otomasyonu_yDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastasonuclarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_otomasyonu_yDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastasonuclarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_otomasyonu_yDataSet22)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_otomasyonu_yDataSet26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastasonuclarBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // hasta_sonuclarTableAdapter2
            // 
            this.hasta_sonuclarTableAdapter2.ClearBeforeFill = true;
            // 
            // hastadosyalarBindingSource1
            // 
            this.hastadosyalarBindingSource1.DataMember = "hasta_dosyalar";
            this.hastadosyalarBindingSource1.DataSource = this.hastane_otomasyonu_yDataSet25;
            // 
            // hastane_otomasyonu_yDataSet25
            // 
            this.hastane_otomasyonu_yDataSet25.DataSetName = "hastane_otomasyonu_yDataSet25";
            this.hastane_otomasyonu_yDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hasta_dosyalarTableAdapter
            // 
            this.hasta_dosyalarTableAdapter.ClearBeforeFill = true;
            // 
            // hastadosyalarBindingSource
            // 
            this.hastadosyalarBindingSource.DataMember = "hasta_dosyalar";
            this.hastadosyalarBindingSource.DataSource = this.hastane_otomasyonu_yDataSet24;
            // 
            // hastane_otomasyonu_yDataSet24
            // 
            this.hastane_otomasyonu_yDataSet24.DataSetName = "hastane_otomasyonu_yDataSet24";
            this.hastane_otomasyonu_yDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(16, 177);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 33);
            this.button6.TabIndex = 3;
            this.button6.Text = "İşlemi Gönder";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(241, 16);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(363, 207);
            this.axAcroPDF1.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 43);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 33);
            this.button5.TabIndex = 1;
            this.button5.Text = "PDF Ekle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.axAcroPDF1);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(622, 229);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Yapıalcak İşlemler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 378);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(630, 255);
            this.tabControl1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(277, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // hasta_sonuclarTableAdapter1
            // 
            this.hasta_sonuclarTableAdapter1.ClearBeforeFill = true;
            // 
            // hastasonuclarBindingSource1
            // 
            this.hastasonuclarBindingSource1.DataMember = "hasta_sonuclar";
            this.hastasonuclarBindingSource1.DataSource = this.hastane_otomasyonu_yDataSet23;
            // 
            // hastane_otomasyonu_yDataSet23
            // 
            this.hastane_otomasyonu_yDataSet23.DataSetName = "hastane_otomasyonu_yDataSet23";
            this.hastane_otomasyonu_yDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hasta_sonuclarTableAdapter
            // 
            this.hasta_sonuclarTableAdapter.ClearBeforeFill = true;
            // 
            // hastasonuclarBindingSource
            // 
            this.hastasonuclarBindingSource.DataMember = "hasta_sonuclar";
            this.hastasonuclarBindingSource.DataSource = this.hastane_otomasyonu_yDataSet22;
            // 
            // hastane_otomasyonu_yDataSet22
            // 
            this.hastane_otomasyonu_yDataSet22.DataSetName = "hastane_otomasyonu_yDataSet22";
            this.hastane_otomasyonu_yDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.ImageKey = "hastayi_sil.png";
            this.button2.Location = new System.Drawing.Point(94, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 64);
            this.button2.TabIndex = 5;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageKey = "sıradaki_hasta.png";
            this.button1.Location = new System.Drawing.Point(2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 64);
            this.button1.TabIndex = 4;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 69);
            this.panel1.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.ImageKey = "LABO.png";
            this.button3.Location = new System.Drawing.Point(186, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 64);
            this.button3.TabIndex = 6;
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // hastane_otomasyonu_yDataSet26
            // 
            this.hastane_otomasyonu_yDataSet26.DataSetName = "hastane_otomasyonu_yDataSet26";
            this.hastane_otomasyonu_yDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastasonuclarBindingSource2
            // 
            this.hastasonuclarBindingSource2.DataMember = "hasta_sonuclar";
            this.hastasonuclarBindingSource2.DataSource = this.hastane_otomasyonu_yDataSet26;
            // 
            // hasta_dosyalarTableAdapter1
            // 
            this.hasta_dosyalarTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(626, 230);
            this.dataGridView1.TabIndex = 9;
            // 
            // admin_laboratuvar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 656);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "admin_laboratuvar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratuvar";
            this.Load += new System.EventHandler(this.laboratuvar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hastadosyalarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_otomasyonu_yDataSet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastadosyalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_otomasyonu_yDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hastasonuclarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_otomasyonu_yDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastasonuclarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_otomasyonu_yDataSet22)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hastane_otomasyonu_yDataSet26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastasonuclarBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private hastane_otomasyonu_yDataSet26TableAdapters.hasta_sonuclarTableAdapter hasta_sonuclarTableAdapter2;
        private System.Windows.Forms.BindingSource hastadosyalarBindingSource1;
        private hastane_otomasyonu_yDataSet25 hastane_otomasyonu_yDataSet25;
        private hastane_otomasyonu_yDataSet24TableAdapters.hasta_dosyalarTableAdapter hasta_dosyalarTableAdapter;
        private System.Windows.Forms.BindingSource hastadosyalarBindingSource;
        private hastane_otomasyonu_yDataSet24 hastane_otomasyonu_yDataSet24;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button6;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private hastane_otomasyonu_yDataSet23TableAdapters.hasta_sonuclarTableAdapter hasta_sonuclarTableAdapter1;
        private System.Windows.Forms.BindingSource hastasonuclarBindingSource1;
        private hastane_otomasyonu_yDataSet23 hastane_otomasyonu_yDataSet23;
        private hastane_otomasyonu_yDataSet22TableAdapters.hasta_sonuclarTableAdapter hasta_sonuclarTableAdapter;
        private System.Windows.Forms.BindingSource hastasonuclarBindingSource;
        private hastane_otomasyonu_yDataSet22 hastane_otomasyonu_yDataSet22;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private hastane_otomasyonu_yDataSet26 hastane_otomasyonu_yDataSet26;
        private System.Windows.Forms.BindingSource hastasonuclarBindingSource2;
        private hastane_otomasyonu_yDataSet25TableAdapters.hasta_dosyalarTableAdapter hasta_dosyalarTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}