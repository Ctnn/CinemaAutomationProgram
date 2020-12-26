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
    /// Interaction logic for kullanıcı_vizyondakiler.xaml
    /// </summary>
    public partial class kullanıcı_vizyondakiler : Window
    {
        public kullanıcı_vizyondakiler()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            /////////KULLANCI ANASAYFA////////////
            kullanıcıanasayfa k_anasayfa = new kullanıcıanasayfa();
            k_anasayfa.Show();
            this.Close();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            ///////////YAKINDA FORMU/////////////////
            kullanıcı_yakında k_yakında = new kullanıcı_yakında();
            k_yakında.Show();
            this.Close();
            ////////////////////////////////////////
        }
        public static int kullanıcı_vizyon_sayac=0;
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            //////////FİLM 1//////////
            kullanıcı_vizyon_sayac = 1;
            kullanıcıfilmbilgisi bilgiac = new kullanıcıfilmbilgisi();
            bilgiac.Show();
            this.Close();
            /////////////////////////////

        }
        OleDbConnection baglanti = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source=sinema.accdb");
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ///////////////////FİLM 1//////////////////////////////////////////
            baglanti.Open();
            OleDbCommand veri = new OleDbCommand("select * from Vizyon where id=1", baglanti);
            OleDbDataReader oku = veri.ExecuteReader();
            while (oku.Read())
            {

                string filmadı = oku["filmadı"].ToString();
                string imdbpuanı = oku["imdb_puanı"].ToString();
                label2.Content = filmadı;
                label18.Content = imdbpuanı;


            }
            ///////////////////////FİLM 2///////////////////////////////////////////
            OleDbCommand veri2 = new OleDbCommand("select * from Vizyon where id=2", baglanti);
            OleDbDataReader oku2 = veri2.ExecuteReader();
            while (oku2.Read())
            {

                string filmadı = oku2["filmadı"].ToString();
                string imdbpuanı = oku2["imdb_puanı"].ToString();
                label3.Content = filmadı;
                label19.Content = imdbpuanı;


            }
            ///////////////////////FİLM 3///////////////////////////////////////////
            OleDbCommand veri3 = new OleDbCommand("select * from Vizyon where id=3", baglanti);
            OleDbDataReader oku3 = veri3.ExecuteReader();
            while (oku3.Read())
            {

                string filmadı = oku3["filmadı"].ToString();
                string imdbpuanı = oku3["imdb_puanı"].ToString();
                label4.Content = filmadı;
                label20.Content = imdbpuanı;


            }
            ///////////////////////FİLM 4///////////////////////////////////////////
            OleDbCommand veri4 = new OleDbCommand("select * from Vizyon where id=4", baglanti);
            OleDbDataReader oku4 = veri4.ExecuteReader();
            while (oku4.Read())
            {

                string filmadı = oku4["filmadı"].ToString();
                string imdbpuanı = oku4["imdb_puanı"].ToString();
                label5.Content = filmadı;
                label21.Content = imdbpuanı;


            }
            ///////////////////////FİLM 5///////////////////////////////////////////
            OleDbCommand veri5 = new OleDbCommand("select * from Vizyon where id=5", baglanti);
            OleDbDataReader oku5 = veri5.ExecuteReader();
            while (oku5.Read())
            {

                string filmadı = oku5["filmadı"].ToString();
                string imdbpuanı = oku5["imdb_puanı"].ToString();
                label6.Content = filmadı;
                label22.Content = imdbpuanı;


            }
            ///////////////////////FİLM 6///////////////////////////////////////////
            OleDbCommand veri6 = new OleDbCommand("select * from Vizyon where id=6", baglanti);
            OleDbDataReader oku6 = veri6.ExecuteReader();
            while (oku6.Read())
            {

                string filmadı = oku6["filmadı"].ToString();
                string imdbpuanı = oku6["imdb_puanı"].ToString();
                label7.Content = filmadı;
                label23.Content = imdbpuanı;


            }
            ///////////////////////FİLM 7///////////////////////////////////////////
            OleDbCommand veri7 = new OleDbCommand("select * from Vizyon where id=7", baglanti);
            OleDbDataReader oku7 = veri7.ExecuteReader();
            while (oku7.Read())
            {

                string filmadı = oku7["filmadı"].ToString();
                string imdbpuanı = oku7["imdb_puanı"].ToString();
                label8.Content = filmadı;
                label24.Content = imdbpuanı;


            }
            ///////////////////////FİLM 8///////////////////////////////////////////
            OleDbCommand veri8 = new OleDbCommand("select * from Vizyon where id=8", baglanti);
            OleDbDataReader oku8 = veri8.ExecuteReader();
            while (oku8.Read())
            {

                string filmadı = oku8["filmadı"].ToString();
                string imdbpuanı = oku8["imdb_puanı"].ToString();
                label9.Content = filmadı;
                label25.Content = imdbpuanı;


            }
            baglanti.Close();
            /////////////////////////////////////////////////////////////////////
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            /////SALONLAR//////
            uye_salonlar salon = new uye_salonlar();
            salon.Show();
            this.Close();
            ///////////////////
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            //////////FİLM 2//////////
            kullanıcı_vizyon_sayac = 2;
            kullanıcıfilmbilgisi bilgiac = new kullanıcıfilmbilgisi();
            bilgiac.Show();
            this.Close();
            /////////////////////////////
        }

        private void button10_Click_1(object sender, RoutedEventArgs e)
        {
            //////////FİLM 3//////////
            kullanıcı_vizyon_sayac = 3;
            kullanıcıfilmbilgisi bilgiac = new kullanıcıfilmbilgisi();
            bilgiac.Show();
            this.Close();
            /////////////////////////////
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            //////////FİLM 4//////////
            kullanıcı_vizyon_sayac = 4;
            kullanıcıfilmbilgisi bilgiac = new kullanıcıfilmbilgisi();
            bilgiac.Show();
            this.Close();
            /////////////////////////////
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            //////////FİLM 8//////////
            kullanıcı_vizyon_sayac = 8;
            kullanıcıfilmbilgisi bilgiac = new kullanıcıfilmbilgisi();
            bilgiac.Show();
            this.Close();
            /////////////////////////////
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            //////////FİLM 7//////////
            kullanıcı_vizyon_sayac = 7;
            kullanıcıfilmbilgisi bilgiac = new kullanıcıfilmbilgisi();
            bilgiac.Show();
            this.Close();
            /////////////////////////////
        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            //////////FİLM 6//////////
            kullanıcı_vizyon_sayac = 6;
            kullanıcıfilmbilgisi bilgiac = new kullanıcıfilmbilgisi();
            bilgiac.Show();
            this.Close();
            /////////////////////////////
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            //////////FİLM 5//////////
            kullanıcı_vizyon_sayac =5;
            kullanıcıfilmbilgisi bilgiac = new kullanıcıfilmbilgisi();
            bilgiac.Show();
            this.Close();
            /////////////////////////////
        }

        private void button3_Click_1(object sender, RoutedEventArgs e)
        {
            /////////KULLANCI ANASAYFA////////////
            kullanıcıanasayfa k_anasayfa = new kullanıcıanasayfa();
            k_anasayfa.Show();
            this.Close();
            ////////////////////////////
        }

        private void button4_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void button5_Click_1(object sender, RoutedEventArgs e)
        {
            ////YAKINDA FORMU////////////////
            kullanıcı_yakında yakında = new kullanıcı_yakında();
            yakında.Show();
            this.Close();
            //////////////////////////////
        }

        private void button6_Click_1(object sender, RoutedEventArgs e)
        {
            /////SALONLAR//////
            uye_salonlar salon = new uye_salonlar();
            salon.Show();
            this.Close();
            ///////////////////
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            /////////BİLET AL/////////////
            biletal bilet = new biletal();
            bilet.Show();
            this.Close();
            ////////////////////////////
        }
    }
}
