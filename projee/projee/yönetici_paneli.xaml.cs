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
    /// Interaction logic for yönetici_paneli.xaml
    /// </summary>
    public partial class yönetici_paneli : Window
    {
        public yönetici_paneli()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
                label6.Content = DateTime.Now.ToString();

        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            ////////FİLM İŞLEMERİ///////////////
            yöneticifilmislem film_y = new yöneticifilmislem();
            film_y.Show();
            this.Close();
            //////////////////////}
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            ///////SEANS İŞLEMLERİ/////////////
            seans_islemleri seans_git = new seans_islemleri();
            seans_git.Show();
            this.Close();
            ///////////////////////////////////
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            ////Kullanıcı İslem//////////
            kullanıcı_islemleri k_islem = new kullanıcı_islemleri();
            k_islem.Show();
            this.Close();
            /////////////////////////////
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            ///////YÖNETİCİ PANEL//////////////
            yonetici_islem duzenle = new yonetici_islem();
            duzenle.Show();
            this.Close();
            /////////////////////////////////
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            ///////BİLET İSLEM/////////
            biletislem ac = new biletislem();
            ac.Show();
            this.Close();
            ///////////////////////////
        }
    }
}
