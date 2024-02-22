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
    public partial class FrmDoktorBilgiDüzenle : Form
    {
        public FrmDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }

        public string TCNo;
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            mskTCKimlikNo.Text=TCNo.ToString();

            SqlCommand sql = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            sql.Parameters.AddWithValue("@p1", mskTCKimlikNo.Text);
            SqlDataReader dr = sql.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                cmbBrans.Text = dr[3].ToString();
                txtSifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p5 where DoktorTC=@p4",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtAd.Text);
            komut.Parameters.AddWithValue("@p2",txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3",cmbBrans.Text);
            komut.Parameters.AddWithValue("@p4",mskTCKimlikNo.Text);
            komut.Parameters.AddWithValue("@p5",txtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayit Güncellendi");

        }
    }
}
