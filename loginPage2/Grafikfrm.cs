using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace loginPage2
{
    public partial class Grafikfrm : Form
    {

       
        public Grafikfrm()
        {
            InitializeComponent();
        }





        private void FillPieChart()
        {
            // Chart kontrolünü temizle
            chart1.Series.Clear();

            // Yeni bir seri oluştur
            Series series = new Series("OkumaSayisi");
            series.ChartType = SeriesChartType.Pie;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(Form1.baglanti.ConnectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT
                    variyant,
                    COUNT(*) as OkumaSayisi,
                    COUNT(*) * 100 / (SELECT COUNT(*) FROM book) as Oran
                FROM
                    book
                GROUP BY
                    tür;
            ";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Graphics g = this.CreateGraphics();
                                string tur = reader["variyant"].ToString();
                                int okumaSayisi = Convert.ToInt32(reader["OkumaSayisi"]);
                                double oran = Convert.ToDouble(reader["Oran"]);

                                series.Points.AddXY($"{tur} ({oran:F2}%)", okumaSayisi);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.ToString());
            }
            finally
            {
                Form1.baglanti.Close(); // Bağlantıyı kapat
            }

            // Seriyi Chart'a ekle
            chart1.Series.Add(series);
        }

        public void grafikCiz_Click(object sender, EventArgs e)
        {
          
           FillPieChart();
        }

        private void Grafikfrm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
