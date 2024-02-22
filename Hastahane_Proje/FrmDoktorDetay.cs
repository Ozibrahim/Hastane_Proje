using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace Hastahane_Proje
{
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        public string TC;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TC;

            //doktor ad çekme
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                lblAdSoyad.Text = dr[0]+" "+dr[1];
            }
            bgl.baglanti().Close();

            //Randevular

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='" + lblAdSoyad.Text+"'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnBilgiDüzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle fr = new FrmDoktorBilgiDüzenle();
            fr.TCNo = lblTC.Text;
            fr.Show();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
