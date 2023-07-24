﻿using System;
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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet6.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet6.Personel);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Personel (PersonelAdSoyad,PersonelAlan) values (@p1,@p2)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtPersonelAd.Text);
            komut.Parameters.AddWithValue("@p2",txtPersonelGörev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Eklendi");
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet6.Personel); 

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Personel where Personelid=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TxtPersonelid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi");
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet6.Personel);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string yoneticiid,personelAd,personelAlan;

            yoneticiid = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            personelAd = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            personelAlan = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            TxtPersonelid.Text = yoneticiid;
            txtPersonelAd.Text = personelAd;
            txtPersonelGörev.Text = personelAlan;

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Personel set PersonelAdSoyad=@p1,PersonelAlan=@p2 where Personelid=@p3",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtPersonelAd.Text);
            komut.Parameters.AddWithValue("@P2", txtPersonelGörev.Text);
            komut.Parameters.AddWithValue("@p3", TxtPersonelid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Güncellendi");
            this.personelTableAdapter.Fill(this.yurtOtomasyonuDataSet6.Personel);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
