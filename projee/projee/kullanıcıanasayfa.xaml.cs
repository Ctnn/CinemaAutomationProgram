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

namespace projee
{
    /// <summary>
    /// Interaction logic for kullanıcıanasayfa.xaml
    /// </summary>
    public partial class kullanıcıanasayfa : Window
    {
        public kullanıcıanasayfa()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ///////////HİTAP ŞEKİLİ///////////////////////
            if(uyegirisi.Cinsiyet=="Erkek")
            {
                label2.Content = uyegirisi.ad + " " + "Bey Hoşgeldiniz";
                
                
            }
            else if (uyegirisi.Cinsiyet == "Kadın")
            {
                label2.Content = uyegirisi.ad + " " + "Hanım Hoşgeldiniz";
            }
            else
            { 
            
            }
            if (uye_sifremiunuttum.Cinsiyet == "Erkek")
            {
                label2.Content = uye_sifremiunuttum.ad + " " + "Bey Hoşgeldiniz";
            }
            else if (uye_sifremiunuttum.Cinsiyet == "Kadın")
            {
                label2.Content = uye_sifremiunuttum.ad + " " + "Hanım Hoşgeldiniz";
            }
            ////////////////////////////////////////////////
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            ///////////YAKINDA FORMU/////////////////
            kullanıcı_yakında k_yakında = new kullanıcı_yakında();
            k_yakında.Show();
            this.Close();
            ////////////////////////////////////////
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ///////////VİZYON FORMU/////////////////
            kullanıcı_vizyondakiler k_vizyon = new kullanıcı_vizyondakiler();
            k_vizyon.Show();

            this.Close();
            ////////////////////////////////////////
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

        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            //////////BİLETLERİM/////////
            biletlerim git = new biletlerim();
            git.Show();
            this.Close();
            /////////////////////////////
        }

        private void button9_Click_1(object sender, RoutedEventArgs e)
        {
            /////////BİLET AL/////////////
            biletal bilet = new biletal();
            bilet.Show();
            this.Close();
            ////////////////////////////
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a =new MainWindow();
            a.Show();
            this.Close();

        }

        private void button7_Click_1(object sender, RoutedEventArgs e)
        {
            //////////BİLETLERİM/////////
            biletlerim git = new biletlerim();
            git.Show();
            this.Close();
            /////////////////////////////
        }
    }
}
