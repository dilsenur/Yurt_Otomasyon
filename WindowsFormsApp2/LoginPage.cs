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
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class LoginPage : DevExpress.XtraEditors.XtraForm
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Admin where YöneticiAd =@p1 and YöneticiSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tb_kAdi.Text);
            komut.Parameters.AddWithValue("@p2", tb_Password.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                AnaMenu fr = new AnaMenu();
                fr.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre");
                tb_kAdi.Clear();
                tb_Password.Text = "";
                tb_kAdi.Focus();
            }
            bgl.baglanti().Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FrmSifremiUnuttum fr = new FrmSifremiUnuttum();
            //fr.ShowDialog();
            fr.Show();
            Hide();
        }
    }
}