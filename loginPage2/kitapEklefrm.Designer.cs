namespace loginPage2
{
    partial class kitapEklefrm
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
            this.components = new System.ComponentModel.Container();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtSayfaNo = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.comboTuru = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(95, 53);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(171, 22);
            this.txtBarkodNo.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(95, 103);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(171, 22);
            this.txtKitapAdi.TabIndex = 2;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(95, 296);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(171, 22);
            this.txtAciklama.TabIndex = 3;
            // 
            // txtSayfaNo
            // 
            this.txtSayfaNo.Location = new System.Drawing.Point(95, 247);
            this.txtSayfaNo.Name = "txtSayfaNo";
            this.txtSayfaNo.Size = new System.Drawing.Size(171, 22);
            this.txtSayfaNo.TabIndex = 4;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(95, 149);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(171, 22);
            this.txtYazar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Barkod No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kitap Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yazar:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Türü:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sayfa No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Açıklama:";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEkle.Location = new System.Drawing.Point(95, 381);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnIptal.Location = new System.Drawing.Point(191, 381);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 14;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // comboTuru
            // 
            this.comboTuru.FormattingEnabled = true;
            this.comboTuru.Items.AddRange(new object[] {
            "Anı",
            "Anlatı",
            "Araştırma-İnceleme",
            "Bilim",
            "Biyografi",
            "Çizgi Roman",
            "Deneme",
            "Edebiyat",
            "Eğitim",
            "Felsefe",
            "Gezi",
            "Hikâye",
            "Hobi",
            "İnceleme",
            "İş Ekonomi – Hukuk",
            "Kişisel Gelişim",
            "Konuşmalar",
            "Masal",
            "Mektup",
            "Öykü",
            "Psikoloji",
            "Roman",
            "Söyleşi",
            "Şiir"});
            this.comboTuru.Location = new System.Drawing.Point(95, 198);
            this.comboTuru.Name = "comboTuru";
            this.comboTuru.Size = new System.Drawing.Size(171, 24);
            this.comboTuru.TabIndex = 15;
            // 
            // kitapEklefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(359, 471);
            this.Controls.Add(this.comboTuru);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.txtSayfaNo);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.txtBarkodNo);
            this.Name = "kitapEklefrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ekleme Sayfası";
            this.Load += new System.EventHandler(this.kitapEklefrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtSayfaNo;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.ComboBox comboTuru;
    }
}