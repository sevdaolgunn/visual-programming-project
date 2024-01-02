namespace loginPage2
{
    partial class anasayfa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKitapListeleme = new System.Windows.Forms.Button();
            this.btnKitapEkleme = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGrafikler = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKitapListeleme);
            this.groupBox1.Controls.Add(this.btnKitapEkleme);
            this.groupBox1.Location = new System.Drawing.Point(187, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap İşlemleri";
            // 
            // btnKitapListeleme
            // 
            this.btnKitapListeleme.Location = new System.Drawing.Point(64, 72);
            this.btnKitapListeleme.Name = "btnKitapListeleme";
            this.btnKitapListeleme.Size = new System.Drawing.Size(230, 30);
            this.btnKitapListeleme.TabIndex = 1;
            this.btnKitapListeleme.Text = "Kitap Listeleme İşlemleri";
            this.btnKitapListeleme.UseVisualStyleBackColor = true;
            this.btnKitapListeleme.Click += new System.EventHandler(this.btnKitapListeleme_Click);
            // 
            // btnKitapEkleme
            // 
            this.btnKitapEkleme.Location = new System.Drawing.Point(64, 36);
            this.btnKitapEkleme.Name = "btnKitapEkleme";
            this.btnKitapEkleme.Size = new System.Drawing.Size(230, 30);
            this.btnKitapEkleme.TabIndex = 0;
            this.btnKitapEkleme.Text = "Kitap Ekleme İşlemleri";
            this.btnKitapEkleme.UseVisualStyleBackColor = true;
            this.btnKitapEkleme.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGrafikler);
            this.groupBox2.Location = new System.Drawing.Point(187, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grafikler";
            // 
            // btnGrafikler
            // 
            this.btnGrafikler.Location = new System.Drawing.Point(64, 46);
            this.btnGrafikler.Name = "btnGrafikler";
            this.btnGrafikler.Size = new System.Drawing.Size(230, 30);
            this.btnGrafikler.TabIndex = 3;
            this.btnGrafikler.Text = "Grafikler";
            this.btnGrafikler.UseVisualStyleBackColor = true;
            this.btnGrafikler.Click += new System.EventHandler(this.btnGrafikler_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.anasayfacs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnKitapEkleme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnKitapListeleme;
        private System.Windows.Forms.Button btnGrafikler;
    }
}