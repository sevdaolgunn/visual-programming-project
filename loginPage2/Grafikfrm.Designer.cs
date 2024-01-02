namespace loginPage2
{
    partial class Grafikfrm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.grafikCiz = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tercih Edilen Kitap Türleri";
            // 
            // grafikCiz
            // 
            this.grafikCiz.Location = new System.Drawing.Point(22, 413);
            this.grafikCiz.Name = "grafikCiz";
            this.grafikCiz.Size = new System.Drawing.Size(123, 34);
            this.grafikCiz.TabIndex = 2;
            this.grafikCiz.Text = "Grafiği Göster";
            this.grafikCiz.UseVisualStyleBackColor = true;
            this.grafikCiz.Click += new System.EventHandler(this.grafikCiz_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(273, 111);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "OkumaSayisi";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(524, 433);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // Grafikfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1242, 627);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.grafikCiz);
            this.Controls.Add(this.label1);
            this.Name = "Grafikfrm";
            this.Text = "Grafikler";
            this.Load += new System.EventHandler(this.Grafikfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button grafikCiz;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}