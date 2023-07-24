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
    public partial class FrmOgrenciKayıt : Form
    {
        public FrmOgrenciKayıt()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Bölümleri Listeleme Komutları
            
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                CmbBolum.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();

            //Boş Odaları listeleme Komutları



            SqlCommand komut2 = new SqlCommand("Select OdaNo From Daireler where OdaKapasite != OdaAktif", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                CmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

          
        }

        private void button1_Click(object sender, EventArgs e)
        {//öğrenci bilgilerinin kayıt edilme komutları
            try
            {
                
                SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci (OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDoğum,OgrBolum,OgrNumarası,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@p1", TxtOgrAdı.Text);
                komutkaydet.Parameters.AddWithValue("@p2", TxtOgrSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p3", MskTC.Text);
                komutkaydet.Parameters.AddWithValue("@p4", MskOgrTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p5", MskDogum.Text);
                komutkaydet.Parameters.AddWithValue("@p6", CmbBolum.Text);
                komutkaydet.Parameters.AddWithValue("@p7", MskOkulNo.Text);
                komutkaydet.Parameters.AddWithValue("@p8", TxtEPosta.Text);
               // komutkaydet.Parameters.AddWithValue("@p9", CmbDaireNo.Text);
                komutkaydet.Parameters.AddWithValue("@p9", CmbOdaNo.Text);
                komutkaydet.Parameters.AddWithValue("@p10", TxtVeliAdSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p11", MskVeliTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p12", RchAdres.Text);
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Eklendi");


                //Öğrenci id yi labele çekmek
                SqlCommand komut = new SqlCommand("select Ogrid from Ogrenci", bgl.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    label15.Text = oku[0].ToString();
                }
                bgl.baglanti().Close();


                //Öğrenci borç alanı oluşturma
                SqlCommand komutkaydet2 = new SqlCommand("insert into Borclar (Ogrid,OgrAd,OgrSoyad) values(@b1,@b2,@b3) " , bgl.baglanti());
                komutkaydet2.Parameters.AddWithValue("@b1",label15.Text);
                komutkaydet2.Parameters.AddWithValue("@b2",TxtOgrAdı.Text);
                komutkaydet2.Parameters.AddWithValue("@b3",TxtOgrSoyad.Text);
                komutkaydet2.BeginExecuteNonQuery();
                bgl.baglanti().Close();

            }
            catch (Exception)
            {
                MessageBox.Show("HATA !! Lütfen Yeniden Deneyin");
                
            }

            // Öğrenci Oda Kontenjanı Arttırma
            SqlCommand komutoda = new SqlCommand("update Daireler set OdaAktif = OdaAktif+1 where OdaNo=@oda1",bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda1", CmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
       

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
