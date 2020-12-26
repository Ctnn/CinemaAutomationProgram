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
    /// Interaction logic for biletlerim.xaml
    /// </summary>
    public partial class biletlerim : Window
    {
        public biletlerim()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source=sinema.accdb");
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            label3.Content = uyegirisi.ad;
            label4.Content = uyegirisi.soyad;
            OleDbCommand veri = new OleDbCommand("select * from satis where satis_Adi='" + label3.Content + "'", baglanti);
            OleDbDataReader oku = veri.ExecuteReader();
            while(oku.Read())
            {
                string bilet_no = oku["satis_ID"].ToString();
                string film_ad = oku["Film_Adi"].ToString();
                 string seans= oku["seans"].ToString();
                 string film_salon = oku["salon_ID"].ToString();
                 string koltuk_No = oku["koltuk_No"].ToString();
                 string ucret = oku["ucret"].ToString();
                 listBox1.Items.Add("Bilet No= "+bilet_no+"  "+"Film Adı= "+film_ad+"  "+"Seansınız= "+seans+"  "+"Salon No= "+film_salon+"  "+"Koltuk Numaranız= "+koltuk_No+"  "+"Ucret= "+ucret);
                
            }
            baglanti.Close();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            //////////BİLETLERİM/////////
            biletlerim git = new biletlerim();
            git.Show();
            this.Close();
            /////////////////////////////
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            /////////KULLANCI ANASAYFA////////////
            kullanıcıanasayfa k_anasayfa = new kullanıcıanasayfa();
            k_anasayfa.Show();
            this.Close();
            ////////////////////////////
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
            /////SALONLAR//////
            uye_salonlar salon = new uye_salonlar();
            salon.Show();
            this.Close();
            ///////////////////
        }

        private void button9_Click_1(object sender, RoutedEventArgs e)
        {
            /////////BİLET AL/////////////
            biletal bilet = new biletal();
            bilet.Show();
            this.Close();
            ////////////////////////////
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            if (MessageBox.Show("Bileti İptal Etmek İstediğinizden Emin Misiniz  ?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                OleDbCommand veri = new OleDbCommand("delete from satis where satis_ID=" + Convert.ToInt32(textBox1.Text), baglanti);
                OleDbDataReader oku = veri.ExecuteReader();
                MessageBox.Show("Bilet İptal Edildi");
                



            }
            else
            {
                //do yes stuff
            }
            baglanti.Close();
            Window_Loaded(sender, e);
        }

       
    }
}
