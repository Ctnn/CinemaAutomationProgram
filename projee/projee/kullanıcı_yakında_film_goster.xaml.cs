using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.OleDb;
using System.IO;
using Microsoft.Win32;

namespace projee
{
    /// <summary>
    /// Interaction logic for kullanıcı_yakında_film_goster.xaml
    /// </summary>
    public partial class kullanıcı_yakında_film_goster : Window
    {
        public kullanıcı_yakında_film_goster()
        {
            InitializeComponent();
        }

        private void button3_Click_1(object sender, RoutedEventArgs e)
        {
            //////Anasayfa//////
            kullanıcıanasayfa anasayfa = new kullanıcıanasayfa();
            anasayfa.Show();
            this.Close();
            ////////////////
        }

        private void button4_Click_1(object sender, RoutedEventArgs e)
        {
            ///////////VİZYON FORMU/////////////////
            kullanıcı_vizyondakiler k_vizyon = new kullanıcı_vizyondakiler();
            k_vizyon.Show();

            this.Close();
            ////////////////////////////////////////
        }

        private void button5_Click_1(object sender, RoutedEventArgs e)
        {
            ///////////VİZYON FORMU/////////////////
            kullanıcı_vizyondakiler k_vizyon = new kullanıcı_vizyondakiler();
            k_vizyon.Show();

            this.Close();
            ////////////////////////////////////////
        }

        private void button6_Click_3(object sender, RoutedEventArgs e)
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

        private void mediaElement1_MediaOpened(object sender, RoutedEventArgs e)
        {
            mediaElement1.Play();
            if (mediaElement1.NaturalDuration.HasTimeSpan)
            {
                TimeSpan tss = TimeSpan.FromMilliseconds(mediaElement1.NaturalDuration.TimeSpan.TotalMilliseconds);
                slider1.Maximum = tss.TotalSeconds;

            }
            TimeSpan ts = mediaElement1.NaturalDuration.TimeSpan;
            slider1.Maximum = ts.TotalSeconds;
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void slider1_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TimeSpan ts = TimeSpan.FromSeconds(e.NewValue);
            mediaElement1.Position = ts;
            mediaElement1.SpeedRatio = (double)slider1.Value;
        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaElement1.Volume = slider2.Value;
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Stop();
        }

        private void button8_Click_1(object sender, RoutedEventArgs e)
        {
            mediaElement1.Play();
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Pause();
        }
        OleDbConnection baglanti = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source=sinema.accdb");
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            baglanti.Open();

            OleDbCommand veri = new OleDbCommand("select * from yakında where id=" + Convert.ToInt32(kullanıcı_yakında.k_yakında_film_sayacı), baglanti);
            OleDbDataReader oku = veri.ExecuteReader();
            while (oku.Read())
            {
                string film_adı = oku["film_adı"].ToString();
                string acıklama = oku["acıklama"].ToString();
                string yonetmen = oku["yonetmen"].ToString();
                string film_turu = oku["film_turu"].ToString();

                label4.Content = film_adı;
                textBox1.Text = acıklama;
                textBox2.Text = yonetmen;
                textBox3.Text = film_turu;
                string a = oku["film_resmi"].ToString();
                image1.Source = new ImageSourceConverter().ConvertFromString("Resimler\\" + a) as ImageSource;
                string b = oku["film_fragmanı"].ToString();
                mediaElement1.Source = new System.Uri(@b, UriKind.Relative);
                mediaElement1.Play();


            }
            baglanti.Close();
        }
    }
}
