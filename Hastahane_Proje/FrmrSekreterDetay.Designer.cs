namespace Hastahane_Proje
{
    partial class FrmrSekreterDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmrSekreterDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDuyuruOlustur = new System.Windows.Forms.Button();
            this.rchDuyuru = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.chkDurum = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtTCNo = new System.Windows.Forms.MaskedTextBox();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.mskSaat = new System.Windows.Forms.MaskedTextBox();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRandevuListe = new System.Windows.Forms.Button();
            this.btnBransPanel = new System.Windows.Forms.Button();
            this.btnDoktorPanel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgisi";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(121, 83);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(75, 21);
            this.lblAdSoyad.TabIndex = 4;
            this.lblAdSoyad.Text = "Null Null";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(121, 51);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(109, 21);
            this.lblTC.TabIndex = 3;
            this.lblTC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad Soyad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDuyuruOlustur);
            this.groupBox2.Controls.Add(this.rchDuyuru);
            this.groupBox2.Location = new System.Drawing.Point(24, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 326);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btnDuyuruOlustur
            // 
            this.btnDuyuruOlustur.Location = new System.Drawing.Point(6, 261);
            this.btnDuyuruOlustur.Name = "btnDuyuruOlustur";
            this.btnDuyuruOlustur.Size = new System.Drawing.Size(304, 37);
            this.btnDuyuruOlustur.TabIndex = 6;
            this.btnDuyuruOlustur.Text = "Oluştur";
            this.btnDuyuruOlustur.UseVisualStyleBackColor = true;
            this.btnDuyuruOlustur.Click += new System.EventHandler(this.btnDuyuruOlustur_Click);
            // 
            // rchDuyuru
            // 
            this.rchDuyuru.Location = new System.Drawing.Point(6, 42);
            this.rchDuyuru.Name = "rchDuyuru";
            this.rchDuyuru.Size = new System.Drawing.Size(304, 194);
            this.rchDuyuru.TabIndex = 6;
            this.rchDuyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbDoktor);
            this.groupBox3.Controls.Add(this.chkDurum);
            this.groupBox3.Controls.Add(this.btnKaydet);
            this.groupBox3.Controls.Add(this.txtTCNo);
            this.groupBox3.Controls.Add(this.cmbBrans);
            this.groupBox3.Controls.Add(this.mskSaat);
            this.groupBox3.Controls.Add(this.mskTarih);
            this.groupBox3.Controls.Add(this.txtid);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(371, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 486);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(169, 195);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(121, 29);
            this.cmbDoktor.TabIndex = 22;
            // 
            // chkDurum
            // 
            this.chkDurum.AutoSize = true;
            this.chkDurum.Location = new System.Drawing.Point(169, 264);
            this.chkDurum.Name = "chkDurum";
            this.chkDurum.Size = new System.Drawing.Size(80, 25);
            this.chkDurum.TabIndex = 8;
            this.chkDurum.Text = "Durum";
            this.chkDurum.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(169, 293);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 37);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(169, 229);
            this.txtTCNo.Mask = "00000000000";
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(120, 29);
            this.txtTCNo.TabIndex = 20;
            this.txtTCNo.ValidatingType = typeof(int);
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(168, 160);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(121, 29);
            this.cmbBrans.TabIndex = 18;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // mskSaat
            // 
            this.mskSaat.Location = new System.Drawing.Point(168, 125);
            this.mskSaat.Mask = "00:00";
            this.mskSaat.Name = "mskSaat";
            this.mskSaat.Size = new System.Drawing.Size(121, 29);
            this.mskSaat.TabIndex = 17;
            this.mskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // mskTarih
            // 
            this.mskTarih.Location = new System.Drawing.Point(168, 89);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(121, 29);
            this.mskTarih.TabIndex = 16;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(168, 54);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(121, 29);
            this.txtid.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(95, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 21);
            this.label10.TabIndex = 13;
            this.label10.Text = "TC No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(95, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Doktor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Branş:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Saat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(832, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(478, 300);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(472, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(835, 322);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(475, 299);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(469, 271);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.btnRandevuListe);
            this.groupBox6.Controls.Add(this.btnBransPanel);
            this.groupBox6.Controls.Add(this.btnDoktorPanel);
            this.groupBox6.Location = new System.Drawing.Point(24, 521);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(786, 100);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 37);
            this.button1.TabIndex = 25;
            this.button1.Text = "Duyurular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRandevuListe
            // 
            this.btnRandevuListe.Location = new System.Drawing.Point(335, 38);
            this.btnRandevuListe.Name = "btnRandevuListe";
            this.btnRandevuListe.Size = new System.Drawing.Size(144, 37);
            this.btnRandevuListe.TabIndex = 24;
            this.btnRandevuListe.Text = "Randevu Listesi";
            this.btnRandevuListe.UseVisualStyleBackColor = true;
            this.btnRandevuListe.Click += new System.EventHandler(this.btnRandevuListe_Click_1);
            // 
            // btnBransPanel
            // 
            this.btnBransPanel.Location = new System.Drawing.Point(185, 38);
            this.btnBransPanel.Name = "btnBransPanel";
            this.btnBransPanel.Size = new System.Drawing.Size(144, 37);
            this.btnBransPanel.TabIndex = 23;
            this.btnBransPanel.Text = "Branş Paneli";
            this.btnBransPanel.UseVisualStyleBackColor = true;
            this.btnBransPanel.Click += new System.EventHandler(this.btnBransPanel_Click_1);
            // 
            // btnDoktorPanel
            // 
            this.btnDoktorPanel.Location = new System.Drawing.Point(35, 38);
            this.btnDoktorPanel.Name = "btnDoktorPanel";
            this.btnDoktorPanel.Size = new System.Drawing.Size(144, 37);
            this.btnDoktorPanel.TabIndex = 22;
            this.btnDoktorPanel.Text = "Doktor Paneli";
            this.btnDoktorPanel.UseVisualStyleBackColor = true;
            this.btnDoktorPanel.Click += new System.EventHandler(this.btnDoktorPanel_Click);
            // 
            // FrmrSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1319, 628);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmrSekreterDetay";
            this.Text = "SekreterDetay";
            this.Load += new System.EventHandler(this.FrmrSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDuyuruOlustur;
        private System.Windows.Forms.RichTextBox rchDuyuru;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkDurum;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.MaskedTextBox txtTCNo;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.MaskedTextBox mskSaat;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnRandevuListe;
        private System.Windows.Forms.Button btnBransPanel;
        private System.Windows.Forms.Button btnDoktorPanel;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.Button button1;
    }
}