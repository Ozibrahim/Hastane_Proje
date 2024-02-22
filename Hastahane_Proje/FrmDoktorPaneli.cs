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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            SqlCommand komut1 = new SqlCommand("Select BransAd From Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                cmbBrans.Items.Add(dr1[0]);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtAd.Text);
            komut.Parameters.AddWithValue("@d2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@d4", mskTCNo.Text);
            komut.Parameters.AddWithValue("@d5", txtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Sisteme Eklendi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTCNo.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new  SqlCommand("Delete From Tbl_Doktorlar where DoktorTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mskTCNo.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi");

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar Set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBrans=@d3,DoktorSifre=@d5 where DoktorTC=@d4",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1",txtAd.Text);
            komut.Parameters.AddWithValue("@d2",txtSoyad.Text);
            komut.Parameters.AddWithValue("@d3",cmbBrans.Text);
            komut.Parameters.AddWithValue("@d4",mskTCNo.Text);
            komut.Parameters.AddWithValue("@d5",txtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Bilgisi Güncellendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
