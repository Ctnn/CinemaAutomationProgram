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

namespace projee
{
    /// <summary>
    /// Interaction logic for kullanıcıfilmbilgisi.xaml
    /// </summary>
    public partial class kullanıcıfilmbilgisi : Window
    {
        public kullanıcıfilmbilgisi()
        {
            InitializeComponent();
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

        private void slider1_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TimeSpan ts = TimeSpan.FromSeconds(e.NewValue);
            mediaElement1.Position = ts;
        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaElement1.Volume = slider2.Value;
        }

        private void button8_Click_1(object sender, RoutedEventArgs e)
        {
            mediaElement1.Play();
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Pause();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Stop();
        }

        private void button3_Click_1(object sender, RoutedEventArgs e)
        {
            ///////ANASAYFA/////
            kullanıcıanasayfa anasayfa = new kullanıcıanasayfa();
            anasayfa.Show();
            this.Close();
            ////////////////

        }

        private void button4_Click_1(object sender, RoutedEventArgs e)
        {
         //////VİZYONDAKİLER////
            kullanıcı_vizyondakiler vizyon = new kullanıcı_vizyondakiler();
            vizyon.Show();
            this.Close();
          ///////////////////
        }

        private void button5_Click_1(object sender, RoutedEventArgs e)
        {
            //////YAKINDA/////////
            kullanıcı_yakında yakında = new kullanıcı_yakında();
            yakında.Show();
            this.Close();
            //////////////////////
        }

        private void button6_Click_3(object sender, RoutedEventArgs e)
        {
            /////////SALONLAR//////
            uye_salonlar salon = new uye_salonlar();
            salon.Show();
            this.Close();
            /////////////////////
        }
        OleDbConnection baglanti = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source=sinema.accdb");
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(Timer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start(); 
            OleDbCommand veri = new OleDbCommand("select * from Vizyon where id=" + Convert.ToInt32(kullanıcı_vizyondakiler.kullanıcı_vizyon_sayac), baglanti);
            OleDbDataReader oku = veri.ExecuteReader();
            while (oku.Read())
            {
                string filmadı = oku["filmadı"].ToString();
                string Film_açıklaması = oku["filmacıklaması"].ToString();
                string yonetmen = oku["yonetmen"].ToString();
                string film_turu = oku["film_turu"].ToString();

                label4.Content = filmadı;
                textBox1.Text = Film_açıklaması;
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
        void Timer_Tick(object sender, EventArgs e)
        {
            slider1.Value = mediaElement1.Position.TotalSeconds;
        }
        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            /////////BİLET AL/////////////
            biletal bilet = new biletal();
            bilet.Show();
            this.Close();
            ////////////////////////////
        }
    }
}
