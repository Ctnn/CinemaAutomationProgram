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
    /// Interaction logic for biletislem.xaml
    /// </summary>
    public partial class biletislem : Window
    {
        public biletislem()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source=sinema.accdb");
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            OleDbCommand veri = new OleDbCommand("select * from satis", baglanti);
            OleDbDataReader oku = veri.ExecuteReader();
            while (oku.Read())
            {
                string bilet_no = oku["satis_ID"].ToString();
                string film_ad = oku["Film_Adi"].ToString();
                string seans = oku["seans"].ToString();
                string film_salon = oku["salon_ID"].ToString();
                string koltuk_No = oku["koltuk_No"].ToString();
                string ucret = oku["ucret"].ToString();
                listBox1.Items.Add("Bilet No= " + bilet_no + "  " + "Film Adı= " + film_ad + "  " + "Seans= " + seans + "  " + "Salon No= " + film_salon + "  " + "Koltuk Numarası= " + koltuk_No + "  " + "Ucret= " + ucret);

            }
            baglanti.Close();
        }

        private void listBox1_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            /////YÖNETİCİ PANELİNE DÖNÜŞ YAP////////
            yönetici_paneli dön = new yönetici_paneli();
            dön.Show();
            this.Close();
            ////////////////////////////////////////
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
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
