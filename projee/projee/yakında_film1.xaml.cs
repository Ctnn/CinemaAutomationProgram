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
    /// Interaction logic for yakında_film1.xaml
    /// </summary>
    public partial class yakında_film1 : Window
    {
        public yakında_film1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
         
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
        
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
        
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
      
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
      
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
          
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

        private void mediaElement1_MediaOpened(object sender, RoutedEventArgs e)
        {
            if (mediaElement1.NaturalDuration.HasTimeSpan)
            {

                TimeSpan ts = TimeSpan.FromMilliseconds(mediaElement1.NaturalDuration.TimeSpan.TotalMilliseconds);
                slider1.Maximum = ts.TotalSeconds;
            }

        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           
        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaElement1.Volume = slider2.Value;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }
      void Timer_Tick(object sender, EventArgs e)
        {
            slider1.Value = mediaElement1.Position.TotalSeconds;
         }
        OleDbConnection baglanti = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source=sinema.accdb");
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(Timer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start(); 
            baglanti.Open();

            OleDbCommand veri = new OleDbCommand("select * from yakında where id=" + Convert.ToInt32(Yakında.yakında_sayac), baglanti);
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
        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void button3_Click_1(object sender, RoutedEventArgs e)
        {
            ///////ANA SAYFA FORMU////////////
            MainWindow anamenü = new MainWindow();
            anamenü.Show();
            this.Close();
            /////////////////////////////////
        }

        private void button4_Click_1(object sender, RoutedEventArgs e)
        {
            ///////////VİZYON FORMU/////////////////
            vizyondakiler vizyon = new vizyondakiler();
            vizyon.Show();
            this.Close();
            ////////////////////////////////////////
        }

        private void button5_Click_1(object sender, RoutedEventArgs e)
        {
            ///////////YAKINDA FORMU/////////////////
            Yakında yakında = new Yakında();
            yakında.Show();
            this.Close();
            ////////////////////////////////////////
        }

        private void button6_Click_3(object sender, RoutedEventArgs e)
        {
            ///////SALONLAR///////
            Salonlar salon = new Salonlar();
            salon.Show();
            /////////////////////
        }

        private void button7_Click_3(object sender, RoutedEventArgs e)
        {
            //////////////Üye Ol////////////////////
            uyeol kayıt = new uyeol();
            kayıt.Show();
            this.Close();

            ///////////////////////////////////////
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            /////////////Uye Formuna geçiş//////////////
            uyegirisi uyegirisi = new uyegirisi();
            uyegirisi.Show();
            this.Close();
            ////////////////////////////////////////////
        }

        private void button2_Click_2(object sender, RoutedEventArgs e)
        {
            /////YÖNETİCİ GİRİŞİ//
            yöneticigirisi y_girisi = new yöneticigirisi();
            y_girisi.Show();
            this.Close();
            //////////////////////
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
        }
    }
}
