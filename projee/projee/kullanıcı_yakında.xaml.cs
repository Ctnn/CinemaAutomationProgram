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
    /// Interaction logic for kullanıcı_yakında.xaml
    /// </summary>
    public partial class kullanıcı_yakında : Window
    {
        public kullanıcı_yakında()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source=sinema.accdb");
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            /////////KULLANCI ANASAYFA////////////
            kullanıcıanasayfa k_anasayfa = new kullanıcıanasayfa();
            k_anasayfa.Show();
            this.Close();
            ////////////////////////////
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ///////////VİZYON FORMU/////////////////
            kullanıcı_vizyondakiler k_vizyon = new kullanıcı_vizyondakiler();
            k_vizyon.Show();

            this.Close();
            ////////////////////////////////////////
        }

       

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ////////////////YAKINDA FİLM 1////////////////
            baglanti.Open();
            OleDbCommand veri = new OleDbCommand("select * from yakında where id=1", baglanti);
            OleDbDataReader oku = veri.ExecuteReader();
            while (oku.Read())
            {
                label2.Content = oku["film_adı"].ToString();
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

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            ////YAKINDA FORMU////////////////
            kullanıcı_yakında yakında = new kullanıcı_yakında();
            yakında.Show();
            this.Close();
            //////////////////////////////
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            /////SALONLAR//////
           uye_salonlar salon = new uye_salonlar();
            salon.Show();
            this.Close();
            ///////////////////
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            /////////BİLET AL/////////////
            biletal bilet = new biletal();
            bilet.Show();
            this.Close();
            ////////////////////////////
        }
        public static int k_yakında_film_sayacı = 0;
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            ////////FİLM 1////////////
            k_yakında_film_sayacı = 1;
            kullanıcı_yakında_film_goster yakında = new kullanıcı_yakında_film_goster();
            yakında.Show();
            this.Close();
            //////////////////////////
            
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            ////////FİLM 2////////////
            k_yakında_film_sayacı = 2;
            kullanıcı_yakında_film_goster yakında = new kullanıcı_yakında_film_goster();
            yakında.Show();
            this.Close();
            //////////////////////////
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            //////////BİLETLERİM/////////
            biletlerim git = new biletlerim();
            git.Show();
            this.Close();
            /////////////////////////////
        }
    }
}
