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

namespace WindowsFormsApp2
{
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into YurtGiderler(Su,Elektirik,Doğalgaz,İnternet,Gıda,Personel,Temizlik,Diğer) Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8) ", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtSu.Text);
                komut.Parameters.AddWithValue("@p2", TxtElektırık.Text);
                komut.Parameters.AddWithValue("@p3", txtDogalgaz.Text);
                komut.Parameters.AddWithValue("@p4", txtİnternet.Text);
                komut.Parameters.AddWithValue("@p5", txtGıda.Text);
                komut.Parameters.AddWithValue("@p6", txtPersonel.Text);
                komut.Parameters.AddWithValue("@p7", txtTemizlik.Text);
                komut.Parameters.AddWithValue("@p8", txtDiğer.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Giderler Kaydedildi");
            }
            catch (Exception)
            {
                MessageBox.Show("Kaydedilemedi,Lütfen Tekrar Deneyiniz");
             
            }
        }

        private void FrmGiderler_Load(object sender, EventArgs e)
        {

        }
    }
}
