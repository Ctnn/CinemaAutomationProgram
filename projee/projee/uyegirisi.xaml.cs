using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.OleDb;

namespace projee
{
    /// <summary>
    /// Interaction logic for uyegirisi.xaml
    /// </summary>
    public partial class uyegirisi : Window
    {
        public uyegirisi()
        {
            InitializeComponent();
        }

        private void image2_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
        
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow anamenü = new MainWindow();
            anamenü.Show();
            this.Close();

        }
        OleDbConnection baglanti = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source=sinema.accdb");
        public static string ad, soyad, dogum_tarihi, kullanıcı_adı, kullanıcı_sifre, Gizli_soru, Gizli_soru_cevap, Cinsiyet, ogrenim_durumu, Tel_no;
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            OleDbCommand veri = new OleDbCommand("select * from Üye where kullanıcı_adı='"+textBox1.Text+"'and kullanıcı_sifre='"+textBox2.Text+"'  ",baglanti);
            OleDbDataReader oku = veri.ExecuteReader();
            while(oku.Read())
            {
                ///////////////DEĞER ALMA//////////////////////////////
                kullanıcı_adı = oku["kullanıcı_adı"].ToString();
                kullanıcı_sifre = oku["kullanıcı_sifre"].ToString();
                ad=oku["ad"].ToString();
                soyad = oku["soyad"].ToString();
                dogum_tarihi = oku["dogum_tarihi"].ToString();
                Gizli_soru = oku["Gizli_soru"].ToString();
                Gizli_soru_cevap = oku["Gizli_soru_cevap"].ToString();
                Cinsiyet = oku["Cinsiyet"].ToString();
                ogrenim_durumu = oku["ogrenim_durumu"].ToString();
                Tel_no = oku["Tel_no"].ToString();
                ////////////////////////////////////////////////////////
                /////////////ŞİFRE DOĞRULA/////////////////////////
                if (kullanıcı_adı == textBox1.Text && kullanıcı_sifre == textBox2.Text)
                {
                    kullanıcıanasayfa k_anasayfa = new kullanıcıanasayfa();
                    k_anasayfa.Show();
                    this.Close();
                }
                //////////////////////////////////////////////////
            }
            baglanti.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            uye_sifremiunuttum sifreyenile = new uye_sifremiunuttum();
            sifreyenile.Show();
            this.Close();
        }

        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

    }
}
