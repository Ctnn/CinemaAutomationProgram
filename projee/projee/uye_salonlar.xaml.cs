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
    /// Interaction logic for uye_salonlar.xaml
    /// </summary>
    public partial class uye_salonlar : Window
    {
        public uye_salonlar()
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
            ///////////VİZYON FORMU/////////////////
            kullanıcı_vizyondakiler k_vizyon = new kullanıcı_vizyondakiler();
            k_vizyon.Show();

            this.Close();
            ////////////////////////////////////////
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            ///////////YAKINDA FORMU/////////////////
            kullanıcı_yakında k_yakında = new kullanıcı_yakında();
            k_yakında.Show();
            this.Close();
            ////////////////////////////////////////
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            ////////Salon formu////////////////
            uye_salonlar salon = new uye_salonlar();
            salon.Show();
            this.Close();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            ///////////BİLET AL/////////////////
            biletal bilet = new biletal();
            bilet.Show();
            this.Close();
            ////////////////////////////////////
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
