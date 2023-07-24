using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class FormGiderGüncelleme : Form
    {
        public FormGiderGüncelleme()
        {
            InitializeComponent();
        }

        public string elektirik, su, dogalgaz, gida, diger, internet, personel, temizlik, id;

        private void FormGiderGüncelleme_Load(object sender, EventArgs e)
       {

            txtGiderid.Text = id;
            TxtElektırık.Text = elektirik;
            txtSu.Text = su;
            txtDogalgaz.Text = dogalgaz;
            txtİnternet.Text = internet;
            txtGıda.Text = gida;
            txtPersonel.Text = personel;
            txtTemizlik.Text = temizlik;
            txtDiğer.Text = diger;

        }

        private void txtTemizlik_TextChanged(object sender, EventArgs e)
        {

        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update YurtGiderler set Su=@p1,Elektirik=@p2,Doğalgaz=@p3,İnternet=@p4,Gıda=@p5,Personel=@p6,Temizlik=@p7,Diğer=@p8 where YurtGiderleriid=@p9", bgl.baglanti());


            try
            {
                komut.Parameters.AddWithValue("@p9", txtGiderid.Text);
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
                MessageBox.Show("Güncelleme Yapıldı");
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu Lütfen Yeniden Deneyiniz");
            }
        }
    }
}
