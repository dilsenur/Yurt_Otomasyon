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
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApp2
{
    public partial class FrmSifremiUnuttum : Form
    {
        public FrmSifremiUnuttum()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void btnGönder_Click(object sender, EventArgs e)
        {
            SqlBaglantim bgl = new SqlBaglantim();
            SqlCommand komut = new SqlCommand("select* from Admin where YöneticiAd=@p1 and Email=@p2 and TC=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtkullnıcıAdı.Text);
            komut.Parameters.AddWithValue("@p2", txtemail.Text);
            komut.Parameters.AddWithValue("@p3", txttC.Text);
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                SqlCommand komut2 = new SqlCommand("update Admin set YöneticiSifre='"+txtYeniSifre.Text+"'where YöneticiAd='"+txtkullnıcıAdı.Text+"'",bgl.baglanti());
                komut2.ExecuteNonQuery();
                MessageBox.Show("Şifrenız Başarı ile Güncellendi");
                LoginPage login = new LoginPage();
                login.Show();
                Hide();
                
            }
            else
            {
                MessageBox.Show("Girdiğiniz bilgiler yanlıştır");
            }
            bgl.baglanti().Close();
        }

        private void txttC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage frm = new LoginPage();
            frm.Visible = true;
            this.Visible = false;
        }
    }
}
