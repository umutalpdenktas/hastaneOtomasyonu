namespace Uygulama.Genel
{
    partial class teshisler
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.hastane_otomasyonu_yDataSet11 = new Uygulama.hastane_otomasyonu_yDataSet11();
            this.teshislerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teshislerTableAdapter = new Uygulama.hastane_otomasyonu_yDataSet11TableAdapters.teshislerTableAdapter();
            this.teshisadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icdkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_otomasyonu_yDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teshislerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label46);
            this.groupBox2.Controls.Add(this.label47);
            this.groupBox2.Location = new System.Drawing.Point(21, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 339);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Teşhis Arama";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teshisadiDataGridViewTextBoxColumn,
            this.icdkoduDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.teshislerBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(9, 70);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(335, 253);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(9, 41);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(181, 20);
            this.textBox6.TabIndex = 3;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(215, 40);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(129, 20);
            this.textBox7.TabIndex = 2;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(212, 24);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(100, 13);
            this.label46.TabIndex = 1;
            this.label46.Text = "ICD Kod İle Arayınız";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(6, 25);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(109, 13);
            this.label47.TabIndex = 0;
            this.label47.Text = "Teşhis Adı İle Arayınız";
            // 
            // hastane_otomasyonu_yDataSet11
            // 
            this.hastane_otomasyonu_yDataSet11.DataSetName = "hastane_otomasyonu_yDataSet11";
            this.hastane_otomasyonu_yDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teshislerBindingSource
            // 
            this.teshislerBindingSource.DataMember = "teshisler";
            this.teshislerBindingSource.DataSource = this.hastane_otomasyonu_yDataSet11;
            // 
            // teshislerTableAdapter
            // 
            this.teshislerTableAdapter.ClearBeforeFill = true;
            // 
            // teshisadiDataGridViewTextBoxColumn
            // 
            this.teshisadiDataGridViewTextBoxColumn.DataPropertyName = "teshis_adi";
            this.teshisadiDataGridViewTextBoxColumn.HeaderText = "teshis_adi";
            this.teshisadiDataGridViewTextBoxColumn.Name = "teshisadiDataGridViewTextBoxColumn";
            // 
            // icdkoduDataGridViewTextBoxColumn
            // 
            this.icdkoduDataGridViewTextBoxColumn.DataPropertyName = "icd_kodu";
            this.icdkoduDataGridViewTextBoxColumn.HeaderText = "icd_kodu";
            this.icdkoduDataGridViewTextBoxColumn.Name = "icdkoduDataGridViewTextBoxColumn";
            // 
            // teshisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Name = "teshisler";
            this.Text = "teshisler";
            this.Load += new System.EventHandler(this.teshisler_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_otomasyonu_yDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teshislerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private hastane_otomasyonu_yDataSet11 hastane_otomasyonu_yDataSet11;
        private System.Windows.Forms.BindingSource teshislerBindingSource;
        private hastane_otomasyonu_yDataSet11TableAdapters.teshislerTableAdapter teshislerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn teshisadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn icdkoduDataGridViewTextBoxColumn;
    }
}