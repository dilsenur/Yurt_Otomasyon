using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WindowsFormsApp2
{
    public partial class AnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmOgrenciKayıt fr = new FrmOgrenciKayıt();
            fr.ShowDialog();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormOgrList fr = new FormOgrList();
            fr.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormOgrList fr = new FormOgrList();
            fr.ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            FrmBolumler fr = new FrmBolumler();
            fr.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            FrmBolumler fr = new FrmBolumler();
            fr.ShowDialog();
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmOdemeler fr = new FrmOdemeler();
            fr.ShowDialog();
        }

        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPersonel fr = new FrmPersonel();
            fr.ShowDialog();
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("MsPaint.exe");
        }

        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmRadyo fr = new FrmRadyo();
            fr.Show();
        }

        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTanıtım fr = new FrmTanıtım();
            fr.Show();
        }

        private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmYöneticiDüzenle fr = new FrmYöneticiDüzenle();
            fr.ShowDialog();
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNotEkle fr = new FrmNotEkle();
            fr.ShowDialog();
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmÖğrenciRapor fr = new FrmÖğrenciRapor();
            fr.Show();
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGelirİstatistik fr = new FrmGelirİstatistik();
            fr.ShowDialog();
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGiderler fr = new FrmGiderler();
            fr.ShowDialog();
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGiderListesi fr = new FrmGiderListesi();
            fr.ShowDialog();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            listele();
        }
        public void listele()
        {
            //FormOgrList frm = new FormOgrList();
            //frm.MdiParent = this;
            //frm.Show();
            OgrList frm = new OgrList();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}