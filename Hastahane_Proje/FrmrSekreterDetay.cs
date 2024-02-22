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

namespace Hastahane_Proje
{
    public partial class FrmrSekreterDetay : Form
    {
        public FrmrSekreterDetay()
        {
            InitializeComponent();
        }
        public string tcno;
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmrSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = tcno;
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",lblTC.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblAdSoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();
            
            //Branşlar Datagride Aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
            
            //doktorlari listeye aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd+' '+DoktorSoyad) as 'Doktorlar',DoktorBrans From Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Brans Aktarma

            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)",bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", mskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", mskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu");

            
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            cmbDoktor.Text = "";

            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",cmbBrans.Text);            
            SqlDataReader dr3 = komut.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0]+" " + dr3[1]);
            }
        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1",rchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu.");
        }

        private void btnDoktorPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli fr = new FrmDoktorPaneli();
            fr.Show();
        }

        private void btnBransPanel_Click(object sender, EventArgs e)
        {
            FrmBrans fr = new FrmBrans();
            fr.Show();
        }                   

        private void btnRandevuListe_Click_1(object sender, EventArgs e)
        {
            FrmRandevuListesi fr = new FrmRandevuListesi();
            fr.Show();
        }

        private void btnBransPanel_Click_1(object sender, EventArgs e)
        {
            FrmBrans frm = new FrmBrans();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }
    }
}
