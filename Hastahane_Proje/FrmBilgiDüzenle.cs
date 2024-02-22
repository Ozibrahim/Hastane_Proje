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

namespace Hastahane_Proje
{
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }
        public string tcno;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            mskTCKimlikNo.Text = tcno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTCKimlikNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text= dr[1].ToString();
                txtSoyad.Text= dr[2].ToString();
                mskTelefon.Text= dr[4].ToString();
                txtSifre.Text= dr[5].ToString();
                cmbCinsiyet.Text= dr[6].ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p4,HastaSifre=@p5,HastaCinsiyet=@p6 Where HastaTC=@p3",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtAd.Text);
            komut.Parameters.AddWithValue("@p2",txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3",mskTCKimlikNo.Text);
            komut.Parameters.AddWithValue("@p4",mskTelefon.Text);
            komut.Parameters.AddWithValue("@p5",txtSifre.Text);
            komut.Parameters.AddWithValue("@p6",cmbCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler Güncellendi");
        }
    }
}
