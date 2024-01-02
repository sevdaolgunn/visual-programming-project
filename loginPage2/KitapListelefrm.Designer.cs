namespace loginPage2
{
    partial class KitapListelefrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtSayfaNo = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboTuru = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(401, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(796, 489);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(137, 121);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(144, 22);
            this.txtBarkodNo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Barkod No";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1025, 578);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 53);
            this.button3.TabIndex = 5;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(137, 164);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(144, 22);
            this.txtKitapAdi.TabIndex = 6;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(137, 205);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(144, 22);
            this.txtYazar.TabIndex = 7;
            // 
            // txtSayfaNo
            // 
            this.txtSayfaNo.Location = new System.Drawing.Point(137, 290);
            this.txtSayfaNo.Name = "txtSayfaNo";
            this.txtSayfaNo.Size = new System.Drawing.Size(144, 22);
            this.txtSayfaNo.TabIndex = 9;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(137, 331);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(144, 57);
            this.txtAciklama.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kitap Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Yazar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Türü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sayfa No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Açıklama";
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
            this.comboTuru.Location = new System.Drawing.Point(137, 244);
            this.comboTuru.Name = "comboTuru";
            this.comboTuru.Size = new System.Drawing.Size(144, 24);
            this.comboTuru.TabIndex = 16;
            // 
            // KitapListelefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1297, 692);
            this.Controls.Add(this.comboTuru);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtSayfaNo);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KitapListelefrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitaplarım";
            this.Load += new System.EventHandler(this.KitapListelefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtSayfaNo;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboTuru;
    }
}