using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace loginPage2
{
    public partial class Form1 : Form
    {
        int id;
       
        public Form1()
        {
            InitializeComponent();
            
        }


        

        public static MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=dblogin; Uid=root; Pwd=085716sevda.");

        public static void veritabani_baglantisi() // Veritabanı bağlantısını açmak için ayrı bir metot oluşturdum
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        int giris_dogrulama(string kAdi, string sifre) //Girişi doğrulamak için ayrı bir metot oluşturdum, geriye bool tipi değer döndürecek
        {
            veritabani_baglantisi(); //veritabani_baglantisi metotunu çağırarak veritabanına bağlantıyı açtım
            MySqlCommand cmd = new MySqlCommand(); //Veritabanına göndereceğim sorguyu tutabilmesi için nesne oluşturdum
            //NOT: MySqlCommand veritabanı üzerinde sorgulama, ekleme, güncelleme, silme işlemlerini yapmak için kullanılır
            cmd.CommandText = "SELECT id FROM giris_bilgileri WHERE kullanici_adi=@kAdi AND sifre=@sifre" ; //Nesnenin içine sorgumu yazdım
            cmd.Parameters.AddWithValue("@kAdi", kAdi); //textboxlara girilen değerleri, parametrelere aktardım
            cmd.Parameters.AddWithValue("@sifre", sifre); //Not: Parametre kullanarak injection'a karşı önlem alıyorum
            cmd.Connection = baglanti; //Komutu veritabanına yolladım
            MySqlDataReader login = cmd.ExecuteReader(); //MySqlDataReader'ı, yolladığım komuttan dönen değerleri satır satır okuması için kullandım
            if (login.Read()) //Read metodu geriye bool türünde değer döndürür
            {
                id = Convert.ToInt32(login["id"]);
                anasayfa anasayfa = new anasayfa();
                anasayfa.GelenDeger = id;
                anasayfa.Show();
                baglanti.Close();

                return id ; //Okunacak satır var ise true değer döndürür
            }
            else
            {
                baglanti.Close();
                return -1; // Okunacak değer yoksa da false değeri döndürür
            }
        }

        public int getUserId()
        {
            MessageBox.Show(id.ToString());

            return id;
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            /*Uygulamadan çıkmak istediğinizde diğer forma eğer daha önce geçiş yapmışsanız o gizlenmiştir (hide) ve arka planda çalışıyodur.
             * Formu kapatma eventine uygulamadan tamamen çıkma metotunu ekledim.*/
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); //Bu formu gizleyip, arkaplanda bekletsin
            Form2 f2 = new Form2(); //Form2'den bir kopya oluştursun ve
            f2.Show(); //Bunu ekranda göstersin, yani kaydolma ekranına geçiş yapsın
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kAdi = textBox3.Text; //textboxtaki değerleri string değişkenlere atadım
            string sifre = textBox4.Text;
            if (kAdi == "" || sifre == "") //Eğer textboxlardan biri boşsa beni uyarsın ve işlem yapmasın
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
                return;
            }
            int a = giris_dogrulama(kAdi, sifre); //giris_dogrulama metotuna giriş bilgilerini yolladım ve bool tipinde bir değer elde ettim
            if (a.Equals(-1)) //Dönen değer true ise yani bilgiler veritabanındaki kayıtlarda mevcutsa if kod bloğu çalışsın
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!");
              

            }

            else
            {
                this.Hide();
               
            }
        }
      
      

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
