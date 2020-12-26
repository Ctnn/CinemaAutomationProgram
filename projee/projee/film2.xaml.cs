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

namespace projee
{
    /// <summary>
    /// Interaction logic for film2.xaml
    /// </summary>
    public partial class film2 : Window
    {
        public film2()
        {
            InitializeComponent();
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            label2.Content = " Her şeyin muhteşem olduğu günlerin üzerinden beş yıl geçmiştir ve şimdi şehir sakinleri yep-" + Environment.NewLine + "yeni bir  tehditle karşı karşıyadırlar:Uzaydan gelen LEGO DUPLO istilacıları her şeyi yeniden" + Environment.NewLine + "inşa edilebileceklerinden daha hızlı bir şekilde paramparça etmektedirler.İstilacıları yenme" + Environment.NewLine + "ve LEGO evrenine uyumu geri getirme sorumluluğu Emmet, Lucy, Batman ve dostlarını çok" + Environment.NewLine + "uzak,keşfedilmemiş dünyalara, hatta her şeyin müzikal olduğu tuhaf bir galaksiye bile götüre-" + Environment.NewLine + "cektir.Bu görev onların cesaretini, yaratıcılığını, Usta Yapıcılık becerilerini sınayacak ve gerçek-" + Environment.NewLine + "ten ne kadar özel olduklarını ortaya çıkaracaktır.";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            /////////////Uye Formuna geçiş//////////////
            uyegirisi uyegirisi = new uyegirisi();
            uyegirisi.Show();
            this.Close();
            ////////////////////////////////////////////
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            ///////SALONLAR///////
            Salonlar salon = new Salonlar();
            salon.Show();
            /////////////////////
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            ///////////YAKINDA FORMU/////////////////
            Yakında yakında = new Yakında();
            yakında.Show();
            this.Close();
            ////////////////////////////////////////
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ///////////VİZYON FORMU/////////////////
            vizyondakiler vizyon = new vizyondakiler();
            vizyon.Show();
            this.Close();
            ////////////////////////////////////////
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ///////ANA SAYFA FORMU////////////
            MainWindow anamenü = new MainWindow();
            anamenü.Show();
            this.Close();
            /////////////////////////////////
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Stop();
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Pause();
        }

        private void mediaElement1_MediaOpened(object sender, RoutedEventArgs e)
        {
            if (mediaElement1.NaturalDuration.HasTimeSpan)
            {

                TimeSpan ts = TimeSpan.FromMilliseconds(mediaElement1.NaturalDuration.TimeSpan.TotalMilliseconds);
                slider1.Maximum = ts.TotalSeconds;
            }
        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaElement1.Volume = slider2.Value;
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TimeSpan ts = TimeSpan.FromSeconds(e.NewValue);
            mediaElement1.Position = ts;
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            //////////////Üye Ol////////////////////
            uyeol kayıt = new uyeol();
            kayıt.Show();
            this.Close();

            ///////////////////////////////////////
        }

       
    }
}
