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
    /// Interaction logic for Yakında.xaml
    /// </summary>
    public partial class Yakında : Window
    {
        public Yakında()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source=sinema.accdb");
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            

            ////////////////YAKINDA FİLM 1////////////////
            baglanti.Open();
            OleDbCommand veri = new OleDbCommand("select * from yakında where id=1",baglanti);
            OleDbDataReader oku = veri.ExecuteReader();
            while(oku.Read())
            {
                label2.Content=oku["film_adı"].ToString();
                label4.Content = oku["cıkıs_tarihi"].ToString();
                label18.Content = oku["imdb"].ToString();
            
            }
            ////////////YAKINDA FİLM 2////////////////
            OleDbCommand veri2 = new OleDbCommand("select * from yakında where id=2", baglanti);
            OleDbDataReader oku2 = veri2.ExecuteReader();
            while (oku2.Read())
            {
                label5.Content = oku2["film_adı"].ToString();
                label9.Content = oku2["cıkıs_tarihi"].ToString();
                label7.Content = oku2["imdb"].ToString();

            }
            //////////////////////////////////////////////////

            baglanti.Close();



        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ///////ANA SAYFA FORMU////////////
            MainWindow anamenü = new MainWindow();
            anamenü.Show();
            this.Close();
            /////////////////////////////////
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ///////////VİZYON FORMU/////////////////
            vizyondakiler vizyon = new vizyondakiler();
            vizyon.Show();
            this.Close();
            ////////////////////////////////////////
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            ///////SALONLAR///////
            Salonlar salon = new Salonlar();
            salon.Show();
            this.Close();
            /////////////////////
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ///////////ÜYE GİRİŞ/////////
            uyegirisi giris = new uyegirisi();
            giris.Show();
            this.Close();
            ////////////////////////////
        }

        private void button7_Click_1(object sender, RoutedEventArgs e)
        {
            /////ÜYE OL//////////////
            uyeol kayıt = new uyeol();
            kayıt.Show();
            this.Close();
            ////////////////////////
        }
        public static int yakında_sayac = 0;
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            ///FİLM 1////////
            yakında_sayac = 1;
            yakında_film1 y_film1 = new yakında_film1();
            y_film1.Show();
            this.Close();
            /////////////////////////
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            ////FİLM 2////////
            yakında_sayac = 2;
            yakında_film1 y_film1 = new yakında_film1();
            y_film1.Show();
            
            this.Close();
            /////////////////////////

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            /////YÖNETİCİ GİRİŞİ//
            yöneticigirisi y_girisi = new yöneticigirisi();
            y_girisi.Show();
            this.Close();
            //////////////////////
        }
    }
}
