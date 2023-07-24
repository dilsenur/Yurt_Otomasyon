namespace WindowsFormsApp2
{
    partial class FrmGiderListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiderListesi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yurtGiderleriidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elektirikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doğalgazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gıdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temizlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diğerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yurtGiderlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet4 = new WindowsFormsApp2.YurtOtomasyonuDataSet4();
            this.yurtGiderlerTableAdapter = new WindowsFormsApp2.YurtOtomasyonuDataSet4TableAdapters.YurtGiderlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtGiderlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yurtGiderleriidDataGridViewTextBoxColumn,
            this.suDataGridViewTextBoxColumn,
            this.elektirikDataGridViewTextBoxColumn,
            this.doğalgazDataGridViewTextBoxColumn,
            this.internetDataGridViewTextBoxColumn,
            this.gıdaDataGridViewTextBoxColumn,
            this.personelDataGridViewTextBoxColumn,
            this.temizlikDataGridViewTextBoxColumn,
            this.diğerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yurtGiderlerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Navy;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(942, 329);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yurtGiderleriidDataGridViewTextBoxColumn
            // 
            this.yurtGiderleriidDataGridViewTextBoxColumn.DataPropertyName = "YurtGiderleriid";
            this.yurtGiderleriidDataGridViewTextBoxColumn.HeaderText = "YurtGiderleriid";
            this.yurtGiderleriidDataGridViewTextBoxColumn.Name = "yurtGiderleriidDataGridViewTextBoxColumn";
            this.yurtGiderleriidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suDataGridViewTextBoxColumn
            // 
            this.suDataGridViewTextBoxColumn.DataPropertyName = "Su";
            this.suDataGridViewTextBoxColumn.HeaderText = "Su";
            this.suDataGridViewTextBoxColumn.Name = "suDataGridViewTextBoxColumn";
            // 
            // elektirikDataGridViewTextBoxColumn
            // 
            this.elektirikDataGridViewTextBoxColumn.DataPropertyName = "Elektirik";
            this.elektirikDataGridViewTextBoxColumn.HeaderText = "Elektirik";
            this.elektirikDataGridViewTextBoxColumn.Name = "elektirikDataGridViewTextBoxColumn";
            // 
            // doğalgazDataGridViewTextBoxColumn
            // 
            this.doğalgazDataGridViewTextBoxColumn.DataPropertyName = "Doğalgaz";
            this.doğalgazDataGridViewTextBoxColumn.HeaderText = "Doğalgaz";
            this.doğalgazDataGridViewTextBoxColumn.Name = "doğalgazDataGridViewTextBoxColumn";
            // 
            // internetDataGridViewTextBoxColumn
            // 
            this.internetDataGridViewTextBoxColumn.DataPropertyName = "İnternet";
            this.internetDataGridViewTextBoxColumn.HeaderText = "İnternet";
            this.internetDataGridViewTextBoxColumn.Name = "internetDataGridViewTextBoxColumn";
            // 
            // gıdaDataGridViewTextBoxColumn
            // 
            this.gıdaDataGridViewTextBoxColumn.DataPropertyName = "Gıda";
            this.gıdaDataGridViewTextBoxColumn.HeaderText = "Gıda";
            this.gıdaDataGridViewTextBoxColumn.Name = "gıdaDataGridViewTextBoxColumn";
            // 
            // personelDataGridViewTextBoxColumn
            // 
            this.personelDataGridViewTextBoxColumn.DataPropertyName = "Personel";
            this.personelDataGridViewTextBoxColumn.HeaderText = "Personel";
            this.personelDataGridViewTextBoxColumn.Name = "personelDataGridViewTextBoxColumn";
            // 
            // temizlikDataGridViewTextBoxColumn
            // 
            this.temizlikDataGridViewTextBoxColumn.DataPropertyName = "Temizlik";
            this.temizlikDataGridViewTextBoxColumn.HeaderText = "Temizlik";
            this.temizlikDataGridViewTextBoxColumn.Name = "temizlikDataGridViewTextBoxColumn";
            // 
            // diğerDataGridViewTextBoxColumn
            // 
            this.diğerDataGridViewTextBoxColumn.DataPropertyName = "Diğer";
            this.diğerDataGridViewTextBoxColumn.HeaderText = "Diğer";
            this.diğerDataGridViewTextBoxColumn.Name = "diğerDataGridViewTextBoxColumn";
            // 
            // yurtGiderlerBindingSource
            // 
            this.yurtGiderlerBindingSource.DataMember = "YurtGiderler";
            this.yurtGiderlerBindingSource.DataSource = this.yurtOtomasyonuDataSet4;
            // 
            // yurtOtomasyonuDataSet4
            // 
            this.yurtOtomasyonuDataSet4.DataSetName = "YurtOtomasyonuDataSet4";
            this.yurtOtomasyonuDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yurtGiderlerTableAdapter
            // 
            this.yurtGiderlerTableAdapter.ClearBeforeFill = true;
            // 
            // FrmGiderListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(942, 329);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGiderListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gider Listesi";
            this.Load += new System.EventHandler(this.FrmGiderListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtGiderlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonuDataSet4 yurtOtomasyonuDataSet4;
        private System.Windows.Forms.BindingSource yurtGiderlerBindingSource;
        private YurtOtomasyonuDataSet4TableAdapters.YurtGiderlerTableAdapter yurtGiderlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yurtGiderleriidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elektirikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doğalgazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gıdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temizlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diğerDataGridViewTextBoxColumn;
    }
}