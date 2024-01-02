using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace loginPage2
{
    public partial class kitapEklefrm : Form
    {
        public int GelenDeger { get; set; }
        public kitapEklefrm()
        {
            InitializeComponent();

        }

        public static MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=dblogin; Uid=root; Pwd=085716sevda.;");


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            int currentUserId = GelenDeger;

            string barkodNo = txtBarkodNo.Text;
            string kitapAdi = txtKitapAdi.Text;
            string yazar = txtYazar.Text;
            string turu = comboTuru.Text;
            string sayfaNo = txtSayfaNo.Text;
            string aciklama = txtAciklama.Text;

           
                Form1.veritabani_baglantisi();// Form1'de oluşturduğum metodu kullanarak bağlantımı açtım
                MySqlCommand cmd = new MySqlCommand(); //Veritabanına göndereceğim sorguyu tutabilmesi için nesne oluşturdum
                cmd.CommandText = "INSERT INTO book(barkodNo,kitapAdi,yazar,variyant,sayfaNo,aciklama, userId) values(@barkodNo,@kitapAdi,@yazar,@turu,@sayfaNo,@aciklama,@currentUserId)"; //Nesnenin içine sorgumu yazdım
                cmd.Parameters.AddWithValue("@barkodNo",barkodNo );
                cmd.Parameters.AddWithValue("@kitapAdi",kitapAdi );
                cmd.Parameters.AddWithValue("@yazar",yazar );
                cmd.Parameters.AddWithValue("@turu",turu );
                cmd.Parameters.AddWithValue("@sayfaNo",sayfaNo );
                cmd.Parameters.AddWithValue("@aciklama", aciklama);
                cmd.Parameters.AddWithValue("@currentUserId", currentUserId);//textboxlara girilen değerleri, parametrelere aktardım
                cmd.Connection = Form1.baglanti; //Form1'deki public static tanımladığım ve tekrar yazmak zorunda kalmadığım veritabanı bağlantımı kullanarak sorgumu yolladım
                int etki = cmd.ExecuteNonQuery(); //Etkilenen kayıt sayısını "etki" değişkenine atadım
                if (etki != 0) //Eğer kayıt eklendiyse, degisken sıfırdan farklı olacaktır ki o halde kayıt başarılıdır
                {
                    MessageBox.Show("Kayıt başarılı!");
                Form1.baglanti.Close();
            }
                else
                    MessageBox.Show("Kayıt başarısız!");
                Form1.baglanti.Close(); //En son kullanmadığım için bağlantımı kapadım

            

        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kitapEklefrm_Load(object sender, EventArgs e)
        {

        }
    }
}
