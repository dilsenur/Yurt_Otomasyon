namespace WindowsFormsApp2
{
    partial class FrmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.PcBolumEkle = new System.Windows.Forms.PictureBox();
            this.PcBolumDuzenle = new System.Windows.Forms.PictureBox();
            this.PcBoumSıl = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBolumid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBolumAd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yurtOtomasyonuDataSet10 = new WindowsFormsApp2.YurtOtomasyonuDataSet10();
            this.bolumlerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bolumlerTableAdapter1 = new WindowsFormsApp2.YurtOtomasyonuDataSet10TableAdapters.BolumlerTableAdapter();
            this.bolumidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PcBolumEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcBolumDuzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcBoumSıl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // PcBolumEkle
            // 
            this.PcBolumEkle.Image = ((System.Drawing.Image)(resources.GetObject("PcBolumEkle.Image")));
            this.PcBolumEkle.Location = new System.Drawing.Point(420, 13);
            this.PcBolumEkle.Margin = new System.Windows.Forms.Padding(4);
            this.PcBolumEkle.Name = "PcBolumEkle";
            this.PcBolumEkle.Size = new System.Drawing.Size(80, 72);
            this.PcBolumEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcBolumEkle.TabIndex = 0;
            this.PcBolumEkle.TabStop = false;
            this.PcBolumEkle.Click += new System.EventHandler(this.PcBolumEkle_Click);
            // 
            // PcBolumDuzenle
            // 
            this.PcBolumDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("PcBolumDuzenle.Image")));
            this.PcBolumDuzenle.Location = new System.Drawing.Point(420, 225);
            this.PcBolumDuzenle.Margin = new System.Windows.Forms.Padding(4);
            this.PcBolumDuzenle.Name = "PcBolumDuzenle";
            this.PcBolumDuzenle.Size = new System.Drawing.Size(80, 68);
            this.PcBolumDuzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcBolumDuzenle.TabIndex = 1;
            this.PcBolumDuzenle.TabStop = false;
            this.PcBolumDuzenle.Click += new System.EventHandler(this.PcBolumDuzenle_Click);
            // 
            // PcBoumSıl
            // 
            this.PcBoumSıl.Image = ((System.Drawing.Image)(resources.GetObject("PcBoumSıl.Image")));
            this.PcBoumSıl.Location = new System.Drawing.Point(420, 128);
            this.PcBoumSıl.Margin = new System.Windows.Forms.Padding(4);
            this.PcBoumSıl.Name = "PcBoumSıl";
            this.PcBoumSıl.Size = new System.Drawing.Size(80, 61);
            this.PcBoumSıl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcBoumSıl.TabIndex = 2;
            this.PcBoumSıl.TabStop = false;
            this.PcBoumSıl.Click += new System.EventHandler(this.PcBoumSıl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bölüm id:";
            // 
            // TxtBolumid
            // 
            this.TxtBolumid.Enabled = false;
            this.TxtBolumid.Location = new System.Drawing.Point(121, 94);
            this.TxtBolumid.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBolumid.Name = "TxtBolumid";
            this.TxtBolumid.Size = new System.Drawing.Size(257, 28);
            this.TxtBolumid.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bölüm Ad:";
            // 
            // TxtBolumAd
            // 
            this.TxtBolumAd.Location = new System.Drawing.Point(121, 201);
            this.TxtBolumAd.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBolumAd.Name = "TxtBolumAd";
            this.TxtBolumAd.Size = new System.Drawing.Size(257, 28);
            this.TxtBolumAd.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumidDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumlerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(533, 297);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yurtOtomasyonuDataSet10
            // 
            this.yurtOtomasyonuDataSet10.DataSetName = "YurtOtomasyonuDataSet10";
            this.yurtOtomasyonuDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerBindingSource1
            // 
            this.bolumlerBindingSource1.DataMember = "Bolumler";
            this.bolumlerBindingSource1.DataSource = this.yurtOtomasyonuDataSet10;
            // 
            // bolumlerTableAdapter1
            // 
            this.bolumlerTableAdapter1.ClearBeforeFill = true;
            // 
            // bolumidDataGridViewTextBoxColumn
            // 
            this.bolumidDataGridViewTextBoxColumn.DataPropertyName = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.HeaderText = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.Name = "bolumidDataGridViewTextBoxColumn";
            this.bolumidDataGridViewTextBoxColumn.ReadOnly = true;
            this.bolumidDataGridViewTextBoxColumn.Width = 200;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            this.bolumAdDataGridViewTextBoxColumn.Width = 277;
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(536, 601);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtBolumAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBolumid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PcBoumSıl);
            this.Controls.Add(this.PcBolumDuzenle);
            this.Controls.Add(this.PcBolumEkle);
            this.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBolumler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bölümler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcBolumEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcBolumDuzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcBoumSıl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PcBolumEkle;
        private System.Windows.Forms.PictureBox PcBolumDuzenle;
        private System.Windows.Forms.PictureBox PcBoumSıl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBolumid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBolumAd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet10 yurtOtomasyonuDataSet10;
        private System.Windows.Forms.BindingSource bolumlerBindingSource1;
        private YurtOtomasyonuDataSet10TableAdapters.BolumlerTableAdapter bolumlerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
    }
}