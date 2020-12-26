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
    /// Interaction logic for kullanıcı_duzenle.xaml
    /// </summary>
    public partial class kullanıcı_duzenle : Window
    {
        public kullanıcı_duzenle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source=sinema.accdb");
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            OleDbCommand veri = new OleDbCommand("select * from Üye where id="+Convert.ToInt32(kullanıcı_islemleri.idtutturucu),baglanti);
            OleDbDataReader oku = veri.ExecuteReader();
            while (oku.Read())
            {
                int id = Convert.ToInt32(oku["id"]);
                string ad = oku["ad"].ToString();
                string soyad = oku["soyad"].ToString();
                string dogum_tarihi = oku["dogum_tarihi"].ToString();
                string kullanıcı_adı = oku["kullanıcı_adı"].ToString();
                      string kullanıcı_sifre = oku["kullanıcı_sifre"].ToString();
                string Gizli_soru = oku["Gizli_soru"].ToString();
                string Gizli_soru_cevap = oku["Gizli_soru_cevap"].ToString();
                string Cinsiyet = oku["Cinsiyet"].ToString();
                string ogrenim_durumu = oku["ogrenim_durumu"].ToString();
                string Tel_no = oku["Tel_no"].ToString();
                textBox10.Text = id.ToString();
                textBox1.Text = ad;
                textBox2.Text = soyad;
                textBox3.Text = dogum_tarihi;
                textBox4.Text = kullanıcı_adı;
                textBox5.Text = kullanıcı_sifre;
                textBox6.Text = Gizli_soru;
                textBox7.Text = Gizli_soru_cevap;
                textBox8.Text = Cinsiyet;
                textBox9.Text = ogrenim_durumu;
                textBox11.Text = Tel_no;

            }
            baglanti.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            OleDbCommand veri = new OleDbCommand("update Üye set ad='" + textBox1.Text + "',soyad='" + textBox2.Text + "',dogum_tarihi='" + textBox3.Text + "',kullanıcı_adı='" + textBox4.Text + "',kullanıcı_sifre='" + textBox5.Text + "',Gizli_soru='" + textBox6.Text + "',Gizli_soru_cevap='" + textBox7.Text + "',Cinsiyet='" + textBox8.Text + "',ogrenim_durumu='" + textBox9.Text + "',Tel_no='"+textBox11.Text+"'where id="+Convert.ToInt32(textBox10.Text), baglanti);
            veri.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ///////KULLANICI İŞLEMLERİ//////////
            kullanıcı_islemleri ac = new kullanıcı_islemleri();
            ac.Show();
            this.Close();
            /////////////////////////////////////
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            if (MessageBox.Show("Kayıdı Silmek İstediğinize Emin Misiniz ?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                OleDbCommand veri = new OleDbCommand("delete from üye where id="+Convert.ToInt32(textBox10.Text), baglanti);
                OleDbDataReader oku = veri.ExecuteReader();
                MessageBox.Show("Üyelik İptal Edildi");
                kullanıcı_islemleri ac = new kullanıcı_islemleri();
                ac.Show();
                this.Close();

             
         
            }
            else
            {
                //do yes stuff
            }
            baglanti.Close();
        }
    }
}
