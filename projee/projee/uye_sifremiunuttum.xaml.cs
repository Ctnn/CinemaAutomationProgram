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
    /// Interaction logic for uye_sifremiunuttum.xaml
    /// </summary>
    public partial class uye_sifremiunuttum : Window
    {
        public uye_sifremiunuttum()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source=sinema.accdb");
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public static string ad,Cinsiyet;
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            OleDbCommand veri = new OleDbCommand("select * from üye where kullanıcı_adı='" + textBox1.Text + "'", baglanti);
            OleDbDataReader oku = veri.ExecuteReader();
            while (oku.Read())
            {
                 ad = oku["ad"].ToString();
                 Cinsiyet = oku["Cinsiyet"].ToString();
                string Gizli_soru = oku["Gizli_soru"].ToString();
                string Gizli_soru_cevap = oku["Gizli_soru_cevap"].ToString();
                if (Gizli_soru == comboBox1.Text && Gizli_soru_cevap == textBox2.Text)
                {
                    label1.Visibility = Visibility.Hidden;
                    label2.Visibility = Visibility.Hidden;
                    label3.Visibility = Visibility.Hidden;
                    textBox1.Visibility = Visibility.Hidden;
                    textBox2.Visibility = Visibility.Hidden;
                    label4.Visibility = Visibility.Visible;
                    label5.Visibility = Visibility.Visible;
                    textBox3.Visibility = Visibility.Visible;
                    textBox4.Visibility = Visibility.Visible;
                    comboBox1.Visibility = Visibility.Hidden;
                    button1.Visibility = Visibility.Visible;
                    button3.Visibility = Visibility.Hidden;
                }

            }
            baglanti.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(textBox3.Text.Length) < 4 && Convert.ToInt32(textBox4.Text.Length) < 4)
            {
                MessageBox.Show("Şifreniz 4'ten Küçük Olamaz");
            }
            else
            {
                if (textBox3.Text == textBox4.Text)
                {
                    baglanti.Open();
                    /////////////////////OLMUYOR ACCESS'E 0 OLARAK ATIYOR BUNU ÇÖZ !//////////////////
                    OleDbCommand veri = new OleDbCommand("update Üye set kullanıcı_sifre='" + textBox3.Text + "',kullanıcı_sifre_tekrarı='" + textBox4.Text + "' where kullanıcı_adı='" + textBox1.Text + "'", baglanti);
                    veri.ExecuteNonQuery();
                    MessageBox.Show("Şifre Değişimi Başarıyla Tamamlandı.");
                    kullanıcıanasayfa dönüş = new kullanıcıanasayfa();
                    dönüş.Show();
                    this.Close();
                    baglanti.Close();
                }
                else
                { 
                 MessageBox.Show("Uyuşmayan Parola");
                }
            }
        }
    }
}
