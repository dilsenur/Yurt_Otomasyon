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
    public partial class FrmOgrDüzenle : Form
    {
        public FrmOgrDüzenle()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Ogrenci set OgrAd =@p2, OgrSoyad=@p3,OgrTC=@p4,OgrTelefon=@p5, OgrDoğum=@p6,OgrBolum=@p7,OgrNumarası=@p8, OgrMail=@p9,OgrOdaNo=@p10,OgrVeliAdSoyad=@p11, OgrVeliTelefon=@p12,OgrVeliAdres=@p13 where Ogrid=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtOgrid.Text);
                komut.Parameters.AddWithValue("@p2", TxtOgrAdı.Text);
                komut.Parameters.AddWithValue("@p3", TxtOgrSoyad.Text);
                komut.Parameters.AddWithValue("@p4", MskTC.Text);
                komut.Parameters.AddWithValue("@p5", MskOgrTelefon.Text);
                komut.Parameters.AddWithValue("@p6", MskDogum.Text);
                komut.Parameters.AddWithValue("@p7", CmbBolum.Text);
                komut.Parameters.AddWithValue("@p8", MskOkulNo.Text);
                komut.Parameters.AddWithValue("@p9", TxtEPosta.Text);
                komut.Parameters.AddWithValue("@p10", CmbOdaNo.Text);
                komut.Parameters.AddWithValue("@p11", TxtVeliAdSoyad.Text);
                komut.Parameters.AddWithValue("@p12", MskVeliTelefon.Text);
                komut.Parameters.AddWithValue("@p13", RchAdres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata,Yeniden Deneyin");
                
            }
        }

        public string id, ad, soyad, TC, telefon, dogum, bolum;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //Öğrenci silme
            SqlCommand komutsil = new SqlCommand("delete from Ogrenci where Ogrid=@k1",bgl.baglanti());
            komutsil.Parameters.AddWithValue("@k1",TxtOgrid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi");

            //Odanın Aktif Öğrenci Saysını Azaltma
            SqlCommand komutoda = new SqlCommand("update Daireler set OdaAktif=OdaAktif-1 where OdaNo=@oda",bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda", CmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        public string ogrno, mail, odano, veliAdSoyad, veliTelefon, veliAdres;
        //public string Ogrid, OgrAdı, OgrSoyad, OgrTC, OgrTelefon, OgrDoğum, OgrBolum;    
           

        private void FrmOgrDüzenle_Load(object sender, EventArgs e)
        {
            TxtOgrid.Text = id;
            TxtOgrAdı.Text = ad;
            TxtOgrSoyad.Text = soyad;
            MskTC.Text = TC;
            MskOgrTelefon.Text = telefon;
            MskDogum.Text = dogum;
            CmbBolum.Text = bolum;
            MskOkulNo.Text = ogrno;
            TxtEPosta.Text = mail;
            CmbOdaNo.Text = odano;
            TxtVeliAdSoyad.Text = veliAdSoyad;
            MskVeliTelefon.Text = veliTelefon;
            RchAdres.Text = veliAdres;
               
        }
    }
}
