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
using System.Windows.Threading;


namespace projee
{
    /// <summary>
    /// Interaction logic for seans_islemleri.xaml
    /// </summary>
    public partial class seans_islemleri : Window
    {
        public seans_islemleri()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source=sinema.accdb");
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            /////////////////Seanslar/////////////////////////////
            baglanti.Open();
            OleDbCommand veri3 = new OleDbCommand("select * from Seanslar", baglanti);
            OleDbDataReader oku3 = veri3.ExecuteReader();
            while (oku3.Read())
            {
                int id = Convert.ToInt32(oku3["id"]);
                string Seans = oku3["seans_saati"].ToString();
                listBox1.Items.Add(id + "  " + Seans);


            }
          
            //////////////////////////////////////////////////////////////////////////////
            
            baglanti.Close();
            //////////////////////////////////////////////////////////////////////////////
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            /////YÖNETİCİ PANELİNE DÖNÜŞ YAP////////
            yönetici_paneli dön = new yönetici_paneli();
            dön.Show();
            this.Close();
            ////////////////////////////////////////
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
        public static int seans_sayac;
        private void listBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void listBox1_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void listBox1_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                seans_sayac = 1;
                seans_duzenle duzenle_ac = new seans_duzenle();
                duzenle_ac.Show();

            }
            if (listBox1.SelectedIndex == 1)
            {
                seans_sayac = 2;
                seans_duzenle duzenle_ac = new seans_duzenle();
                duzenle_ac.Show();
            }
            if (listBox1.SelectedIndex == 2)
            {
                seans_sayac = 3;
                seans_duzenle duzenle_ac = new seans_duzenle();
                duzenle_ac.Show();
            } 
            if (listBox1.SelectedIndex == 3)
            {
                seans_sayac = 4;
                seans_duzenle duzenle_ac = new seans_duzenle();
                duzenle_ac.Show();
            }
            if (listBox1.SelectedIndex == 4)
            {
                seans_sayac = 5;
                seans_duzenle duzenle_ac = new seans_duzenle();
                duzenle_ac.Show();
            }
        }
    }
}
