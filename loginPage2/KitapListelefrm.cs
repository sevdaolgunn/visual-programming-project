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
using MySql.Data.MySqlClient;

namespace loginPage2
{
    public partial class KitapListelefrm : Form
    {

        public int GelenDeger { get; set; }
        

        public KitapListelefrm()
        {
            InitializeComponent();
        }
        DataSet daset = new DataSet();

        public DataGridView KitapListesiDataGridView
        {
            get { return dataGridView1; }
        }

        private void kitapListele()
        {
            Form1.veritabani_baglantisi();

            int currentUserId = GelenDeger;
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from book where userId = @currentUserId", Form1.baglanti);
            adapter.SelectCommand.Parameters.AddWithValue("@currentUserId", currentUserId);
            adapter.Fill(daset, "book");
            dataGridView1.DataSource = daset.Tables["book"];
            Form1.baglanti.Close();
            

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            int currentUserId = GelenDeger;

            string barkodNo = txtBarkodNo.Text;
            string kitapAdi = txtKitapAdi.Text;
            string yazar = txtYazar.Text;
            string turu = comboTuru.Text;
            string sayfaNo = txtSayfaNo.Text;
            string aciklama = txtAciklama.Text;


            Form1.veritabani_baglantisi();
            MySqlCommand cmd = new MySqlCommand("UPDATE book SET kitapAdi=@kitapAdi,yazar=@yazar,variyant=@turu,sayfaNo=@sayfaNo,aciklama=@aciklama where  barkodNo=@barkodNo",Form1.baglanti); //Veritabanına göndereceğim sorguyu tutabilmesi için nesne oluşturdum
            cmd.Parameters.AddWithValue("@barkodNo", barkodNo);
            cmd.Parameters.AddWithValue("@kitapAdi", kitapAdi);
            cmd.Parameters.AddWithValue("@yazar", yazar);
            cmd.Parameters.AddWithValue("@turu", turu);
            cmd.Parameters.AddWithValue("@sayfaNo", sayfaNo);
            cmd.Parameters.AddWithValue("@aciklama", aciklama);
            cmd.ExecuteNonQuery();
            Form1.baglanti.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleştirildi");
            daset.Tables["book"].Clear();
            kitapListele();
            foreach (Control item in Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
       

        }

        private void KitapListelefrm_Load(object sender, EventArgs e)
        {
            kitapListele();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kaydı silmek mis istiyorunuz?", "Sil", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Form1.baglanti.Open();
                MySqlCommand cmd = new MySqlCommand("delete from book where barkodNo=@barkodNo", Form1.baglanti);
                cmd.Parameters.AddWithValue("@barkodNo", dataGridView1.CurrentRow.Cells["barkodNo"].Value.ToString());
                cmd.ExecuteNonQuery();
                Form1.baglanti.Close();
                MessageBox.Show("Silme İşlemi Tamamlandı.");
                daset.Tables["book"].Clear();
                kitapListele();
                foreach(Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }
    }
}
