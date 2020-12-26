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
    /// Interaction logic for biletal.xaml
    /// </summary>
    public partial class biletal : Window
    {
        public biletal()
        {
            InitializeComponent();
        }
        public static string  film, tarih, seans;
        public static int filmno , tarihno, seansno;
           private void button1_Click(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            
            
            film = listBox2.SelectedItem.ToString();
            tarih = listBox3.SelectedItem.ToString();
            seans = listBox4.SelectedItem.ToString();
            //////////////////////
            biletal_devamı ac = new biletal_devamı();
            ac.Show();
            this.Close();
         
           
        
            
           
        }
        OleDbConnection baglanti = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source=sinema.accdb");
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
       

            //////////////////////////////
            ////////Film LİSTBOX/////////
            baglanti.Open();
            OleDbCommand veri2 = new OleDbCommand("select * from Vizyon", baglanti);
            OleDbDataReader oku2 = veri2.ExecuteReader();
            while (oku2.Read())
            {
                string filmadı = oku2["filmadı"].ToString();
                listBox2.Items.Add(filmadı);
            }


            //////////////////////////////
            ////////Film LİSTBOX/////////

            OleDbCommand veri3 = new OleDbCommand("select * from Tarih", baglanti);
            OleDbDataReader oku3 = veri3.ExecuteReader();
            while (oku3.Read())
            {
                string tarih = oku3["tarihler"].ToString();
                listBox3.Items.Add(tarih);
            }

           
            //////////////////////////////
            ////////Seans LİSTBOX/////////

            OleDbCommand veri4 = new OleDbCommand("select * from Seanslar", baglanti);
            OleDbDataReader oku4 = veri4.ExecuteReader();
            while (oku4.Read())
            {
                string seans_saati = oku4["seans_saati"].ToString();
                listBox4.Items.Add(seans_saati);
            }

            baglanti.Close();
            //////////////////////////////
            ////////değer aldırma//////
            
           
            /////////////////////////////

        }

       

        private void listBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox2.SelectedIndex == 0)
            {
                label6.Content = listBox2.SelectedItem;
                filmno = 1;
            }
            if (listBox2.SelectedIndex == 1)
            {
                label6.Content = listBox2.SelectedItem;
                filmno = 2;
            }
            if (listBox2.SelectedIndex == 2)
            {
                label6.Content = listBox2.SelectedItem;
                filmno = 3;
            }
            if (listBox2.SelectedIndex == 3)
            {
                label6.Content = listBox2.SelectedItem;
                filmno = 4;
            }
            if (listBox2.SelectedIndex ==4)
            {
                label6.Content = listBox2.SelectedItem;
                filmno = 5;
            }
            if (listBox2.SelectedIndex == 5)
            {
                label6.Content = listBox2.SelectedItem;
                filmno = 6;
            }
            if (listBox2.SelectedIndex == 6)
            {
                label6.Content = listBox2.SelectedItem;
                filmno = 7;
            }
            if (listBox2.SelectedIndex == 7)
            {
                label6.Content = listBox2.SelectedItem;
                filmno = 8;
            }
        }

        private void listBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox3.SelectedIndex == 0)
            {
                label7.Content = listBox3.SelectedItem;
                tarihno = 1;
            }
            if (listBox3.SelectedIndex == 1)
            {
                label7.Content = listBox3.SelectedItem;
                tarihno = 2;
            }
            if (listBox3.SelectedIndex == 2)
            {
                label7.Content = listBox3.SelectedItem;
                tarihno = 3;
            }
            if (listBox3.SelectedIndex == 3)
            {
                label7.Content = listBox3.SelectedItem;
                tarihno = 4;
            }
            if (listBox3.SelectedIndex ==4)
            {
                label7.Content = listBox3.SelectedItem;
                tarihno = 5;
            }
            if (listBox3.SelectedIndex == 5)
            {
                label7.Content = listBox3.SelectedItem;
                tarihno = 6;
            }
            if (listBox3.SelectedIndex ==6)
            {
                label7.Content = listBox3.SelectedItem;
                tarihno = 7;
            }
           
        }

        private void listBox4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox4.SelectedIndex == 0)
            {
                label8.Content = listBox4.SelectedItem;
                seansno = 1;
            }
            if (listBox4.SelectedIndex == 1)
            {
                label8.Content = listBox4.SelectedItem;
                seansno = 2;
            }
            if (listBox4.SelectedIndex == 2)
            {
                label8.Content = listBox4.SelectedItem;
                seansno = 3;
            }
            if (listBox4.SelectedIndex == 3)
            {
                label8.Content = listBox4.SelectedItem;
                seansno = 4;
            }
            if (listBox4.SelectedIndex ==4)
            {
                label8.Content = listBox4.SelectedItem;
                seansno = 5;
            }
        }
    }
}
