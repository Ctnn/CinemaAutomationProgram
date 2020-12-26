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
    /// Interaction logic for Salonlar.xaml
    /// </summary>
    public partial class Salonlar : Window
    {
        public Salonlar()
        {
            InitializeComponent();
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
            ///////////YAKINDA FORMU/////////////////
            Yakında yakında = new Yakında();
            yakında.Show();
            this.Close();
            ////////////////////////////////////////
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            /////ÜYE OL//////////////
            uyeol kayıt = new uyeol();
            kayıt.Show();
            this.Close();
            ////////////////////////
        }

        private void button1_Click(object sender, RoutedEventArgs e)
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

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            /////YÖNETİCİ GİRİŞİ//
            yöneticigirisi y_girisi = new yöneticigirisi();
            y_girisi.Show();
            this.Close();
            //////////////////////
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ///////////ÜYE GİRİŞ/////////
            uyegirisi giris = new uyegirisi();
            giris.Show();
            this.Close();
            ////////////////////////////
        }
    }
}
