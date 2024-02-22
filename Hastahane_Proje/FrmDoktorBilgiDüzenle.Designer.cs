namespace Hastahane_Proje
{
    partial class FrmDoktorBilgiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgiDüzenle));
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.mskTCKimlikNo = new System.Windows.Forms.MaskedTextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(175, 209);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(121, 29);
            this.txtSifre.TabIndex = 30;
            // 
            // mskTCKimlikNo
            // 
            this.mskTCKimlikNo.Location = new System.Drawing.Point(175, 130);
            this.mskTCKimlikNo.Mask = "00000000000";
            this.mskTCKimlikNo.Name = "mskTCKimlikNo";
            this.mskTCKimlikNo.Size = new System.Drawing.Size(121, 29);
            this.mskTCKimlikNo.TabIndex = 29;
            this.mskTCKimlikNo.ValidatingType = typeof(int);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(175, 95);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(121, 29);
            this.txtSoyad.TabIndex = 28;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(175, 60);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(121, 29);
            this.txtAd.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "Sifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ad:";
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(175, 165);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(121, 29);
            this.cmbBrans.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Branş:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(185, 255);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(99, 34);
            this.btnGuncelle.TabIndex = 33;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // FrmDoktorBilgiDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(422, 399);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.mskTCKimlikNo);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorBilgiDüzenle";
            this.Text = "FrmDoktorBilgiDüzenle";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.MaskedTextBox mskTCKimlikNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuncelle;
    }
}