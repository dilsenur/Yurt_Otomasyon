namespace WindowsFormsApp2
{
    partial class OgrList
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.yurtOtomasyonuDataSet91 = new WindowsFormsApp2.YurtOtomasyonuDataSet9();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOgrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrDoğum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrBolum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrNumarası = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrOdaNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrVeliAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrVeliTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOgrVeliAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet32 = new WindowsFormsApp2.YurtOtomasyonuDataSet3();
            this.yurtOtomasyonuDataSet31 = new WindowsFormsApp2.YurtOtomasyonuDataSet3();
            this.ogrenciTableAdapter1 = new WindowsFormsApp2.YurtOtomasyonuDataSet8TableAdapters.OgrenciTableAdapter();
            this.ogrenciTableAdapter2 = new WindowsFormsApp2.YurtOtomasyonuDataSet8TableAdapters.OgrenciTableAdapter();
            this.ogrenciTableAdapter3 = new WindowsFormsApp2.YurtOtomasyonuDataSet9TableAdapters.OgrenciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet91)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet31)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Ogrenci";
            this.gridControl1.DataSource = this.yurtOtomasyonuDataSet91;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1343, 362);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.gridView1});
            // 
            // yurtOtomasyonuDataSet91
            // 
            this.yurtOtomasyonuDataSet91.DataSetName = "YurtOtomasyonuDataSet9";
            this.yurtOtomasyonuDataSet91.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.Appearance.Row.Options.UseBorderColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOgrid,
            this.colOgrAd,
            this.colOgrSoyad,
            this.colOgrTC,
            this.colOgrTelefon,
            this.colOgrDoğum,
            this.colOgrBolum,
            this.colOgrNumarası,
            this.colOgrMail,
            this.colOgrOdaNo,
            this.colOgrVeliAdSoyad,
            this.colOgrVeliTelefon,
            this.colOgrVeliAdres});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colOgrid
            // 
            this.colOgrid.FieldName = "Ogrid";
            this.colOgrid.Name = "colOgrid";
            this.colOgrid.Visible = true;
            this.colOgrid.VisibleIndex = 0;
            // 
            // colOgrAd
            // 
            this.colOgrAd.FieldName = "OgrAd";
            this.colOgrAd.Name = "colOgrAd";
            this.colOgrAd.Visible = true;
            this.colOgrAd.VisibleIndex = 1;
            // 
            // colOgrSoyad
            // 
            this.colOgrSoyad.FieldName = "OgrSoyad";
            this.colOgrSoyad.Name = "colOgrSoyad";
            this.colOgrSoyad.Visible = true;
            this.colOgrSoyad.VisibleIndex = 2;
            // 
            // colOgrTC
            // 
            this.colOgrTC.FieldName = "OgrTC";
            this.colOgrTC.Name = "colOgrTC";
            this.colOgrTC.Visible = true;
            this.colOgrTC.VisibleIndex = 3;
            // 
            // colOgrTelefon
            // 
            this.colOgrTelefon.FieldName = "OgrTelefon";
            this.colOgrTelefon.Name = "colOgrTelefon";
            this.colOgrTelefon.Visible = true;
            this.colOgrTelefon.VisibleIndex = 4;
            // 
            // colOgrDoğum
            // 
            this.colOgrDoğum.FieldName = "OgrDoğum";
            this.colOgrDoğum.Name = "colOgrDoğum";
            this.colOgrDoğum.Visible = true;
            this.colOgrDoğum.VisibleIndex = 5;
            // 
            // colOgrBolum
            // 
            this.colOgrBolum.FieldName = "OgrBolum";
            this.colOgrBolum.Name = "colOgrBolum";
            this.colOgrBolum.Visible = true;
            this.colOgrBolum.VisibleIndex = 6;
            // 
            // colOgrNumarası
            // 
            this.colOgrNumarası.FieldName = "OgrNumarası";
            this.colOgrNumarası.Name = "colOgrNumarası";
            this.colOgrNumarası.Visible = true;
            this.colOgrNumarası.VisibleIndex = 7;
            // 
            // colOgrMail
            // 
            this.colOgrMail.FieldName = "OgrMail";
            this.colOgrMail.Name = "colOgrMail";
            this.colOgrMail.Visible = true;
            this.colOgrMail.VisibleIndex = 8;
            // 
            // colOgrOdaNo
            // 
            this.colOgrOdaNo.FieldName = "OgrOdaNo";
            this.colOgrOdaNo.Name = "colOgrOdaNo";
            this.colOgrOdaNo.Visible = true;
            this.colOgrOdaNo.VisibleIndex = 9;
            // 
            // colOgrVeliAdSoyad
            // 
            this.colOgrVeliAdSoyad.FieldName = "OgrVeliAdSoyad";
            this.colOgrVeliAdSoyad.Name = "colOgrVeliAdSoyad";
            this.colOgrVeliAdSoyad.Visible = true;
            this.colOgrVeliAdSoyad.VisibleIndex = 10;
            // 
            // colOgrVeliTelefon
            // 
            this.colOgrVeliTelefon.FieldName = "OgrVeliTelefon";
            this.colOgrVeliTelefon.Name = "colOgrVeliTelefon";
            this.colOgrVeliTelefon.Visible = true;
            this.colOgrVeliTelefon.VisibleIndex = 11;
            // 
            // colOgrVeliAdres
            // 
            this.colOgrVeliAdres.FieldName = "OgrVeliAdres";
            this.colOgrVeliAdres.Name = "colOgrVeliAdres";
            this.colOgrVeliAdres.Visible = true;
            this.colOgrVeliAdres.VisibleIndex = 12;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            this.ogrenciBindingSource.DataSource = this.yurtOtomasyonuDataSet32;
            this.ogrenciBindingSource.Sort = "Ogrid ASC,OgrAd ASC,OgrSoyad ASC,OgrDoğum ASC,OgrOdaNo ASC,OgrNumarası ASC";
            // 
            // yurtOtomasyonuDataSet32
            // 
            this.yurtOtomasyonuDataSet32.DataSetName = "YurtOtomasyonuDataSet3";
            this.yurtOtomasyonuDataSet32.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yurtOtomasyonuDataSet31
            // 
            this.yurtOtomasyonuDataSet31.DataSetName = "YurtOtomasyonuDataSet3";
            this.yurtOtomasyonuDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciTableAdapter1
            // 
            this.ogrenciTableAdapter1.ClearBeforeFill = true;
            // 
            // ogrenciTableAdapter2
            // 
            this.ogrenciTableAdapter2.ClearBeforeFill = true;
            // 
            // ogrenciTableAdapter3
            // 
            this.ogrenciTableAdapter3.ClearBeforeFill = true;
            // 
            // OgrList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 362);
            this.Controls.Add(this.gridControl1);
            this.Name = "OgrList";
            this.Text = "OgrList";
            this.Load += new System.EventHandler(this.OgrList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet91)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet31)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private YurtOtomasyonuDataSet3 yurtOtomasyonuDataSet31;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrid;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrAd;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrTC;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrDoğum;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrBolum;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrNumarası;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrMail;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrOdaNo;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrVeliAdSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrVeliTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colOgrVeliAdres;
        private YurtOtomasyonuDataSet8TableAdapters.OgrenciTableAdapter ogrenciTableAdapter1;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private YurtOtomasyonuDataSet3 yurtOtomasyonuDataSet32;
        private YurtOtomasyonuDataSet8TableAdapters.OgrenciTableAdapter ogrenciTableAdapter2;
        private YurtOtomasyonuDataSet9 yurtOtomasyonuDataSet91;
        private YurtOtomasyonuDataSet9TableAdapters.OgrenciTableAdapter ogrenciTableAdapter3;
    }
}