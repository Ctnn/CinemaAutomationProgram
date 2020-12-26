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
using System.Windows.Threading;

namespace projee
{
    /// <summary>
    /// Interaction logic for filmbilgi.xaml
    /// </summary>
    public partial class filmbilgi : Window
    {
        public filmbilgi()
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

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button6_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void button7_Click_1(object sender, RoutedEventArgs e)
        {

        }

        void dispatchertimer_Tick(object sender, EventArgs e)
        {
            slider1.Value = mediaElement1.Position.TotalSeconds;
        }
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Play();
        }
        
        OleDbConnection baglanti = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source=sinema.accdb");
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(Timer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start(); 

            baglanti.Open();
           
            OleDbCommand veri = new OleDbCommand("select * from Vizyon where id="+Convert.ToInt32(vizyondakiler.sayac), baglanti);
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


        private void button11_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd;
            ofd = new OpenFileDialog();
            ofd.AddExtension = true;
            ofd.DefaultExt = "*.*";
            ofd.Filter = "Media Files (*.*)|*.*";
            ofd.ShowDialog();
            try
            {
                mediaElement1.Source = new Uri(ofd.FileName);
            }
            catch
            {
                new NullReferenceException("Error");
            }
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(Timer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();


        }
        void Timer_Tick(object sender, EventArgs e)
        {
            slider1.Value = mediaElement1.Position.TotalSeconds;
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

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaElement1.Volume = slider2.Value;
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
         
           
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

        private void button6_Click_2(object sender, RoutedEventArgs e)
        {
          
        }

        private void button7_Click_2(object sender, RoutedEventArgs e)
        {
          
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            e.Handled = false;
        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            e.Handled = false;
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            e.Handled = false;
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

        private void button2_Click_2(object sender, RoutedEventArgs e)
        {
            /////YÖNETİCİ GİRİŞİ//
            yöneticigirisi y_girisi = new yöneticigirisi();
            y_girisi.Show();
            this.Close();
            //////////////////////
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            /////////////Uye Formuna geçiş//////////////
            uyegirisi uyegirisi = new uyegirisi();
            uyegirisi.Show();
            this.Close();
            ////////////////////////////////////////////
        }

        private void slider1_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TimeSpan ts = TimeSpan.FromSeconds(e.NewValue);
            mediaElement1.Position = ts;
       
        }

       
    }
}
