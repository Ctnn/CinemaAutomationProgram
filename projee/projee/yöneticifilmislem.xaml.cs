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
using System.IO;
using Microsoft.Win32;
using System.Data.OleDb;


namespace projee
{
    /// <summary>
    /// Interaction logic for yöneticifilmislem.xaml
    /// </summary>
    public partial class yöneticifilmislem : Window
    {
        public yöneticifilmislem()
        {
            InitializeComponent();
        }
    


        
        OleDbConnection baglanti = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source=sinema.accdb");
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
            /////////////LİSTBOX GÜNCEL FİLMLER//////////////////////
            baglanti.Open();
            OleDbCommand veri = new OleDbCommand("select * from Vizyon",baglanti);
            OleDbDataReader oku = veri.ExecuteReader();
            while(oku.Read())
            {
                int id = Convert.ToInt32(oku["id"]);
                string filmadı = oku["filmadı"].ToString();
                string imdb_puanı = oku["imdb_puanı"].ToString();
                string filmacıklaması = oku["filmacıklaması"].ToString();
                listBox1.Items.Add(id+"  "+filmadı+"  "+imdb_puanı+"  "+filmacıklaması);
                listBox1.Items.Add("___________________________________________________________________________");
            }
            
            ////////////////////////////////////////////////////////
            /////////////LİSTBOX Yakındaki FİLMLER//////////////////////
           
            OleDbCommand veri2 = new OleDbCommand("select * from yakında", baglanti);
            OleDbDataReader oku2 = veri2.ExecuteReader();
            while (oku2.Read())
            {
                int id = Convert.ToInt32(oku2["id"]);
                string filmadı = oku2["film_adı"].ToString();
                string imdb = oku2["imdb"].ToString();
                string cıkıs_tarihi = oku2["cıkıs_tarihi"].ToString();
                string acıklama = oku2["acıklama"].ToString();
                listBox2.Items.Add(id + "  " + filmadı + "  " + imdb + "  " + cıkıs_tarihi+"  "+acıklama);
                listBox2.Items.Add("___________________________________________________________________________");
            }
            baglanti.Close();

            ////////////////////////////////////////////////////////
           
           
        }
        OpenFileDialog afd = new OpenFileDialog();
        string a;
        string filmacıklaması;
      

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
        public static int genelvizyondakifilmsayacı = 0;
        public static int genelyakındakifilmsayacı = 0;
        private void listBox1_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            /////////////VİZYONDAKİ FİLMLERİ DÜZENLE//////////////////////////
            if (listBox1.SelectedIndex == 0)
            {
                genelvizyondakifilmsayacı = 1;
                yönetici_film_düzenle git = new yönetici_film_düzenle();
                git.Show();
                
            }
            if (listBox1.SelectedIndex == 2)
            {
                genelvizyondakifilmsayacı = 2;
                yönetici_film_düzenle git = new yönetici_film_düzenle();
                git.Show();
            }
            if (listBox1.SelectedIndex == 4)
            {
                genelvizyondakifilmsayacı = 3;
                yönetici_film_düzenle git = new yönetici_film_düzenle();
                git.Show();
            }
            if (listBox1.SelectedIndex == 6)
            {
                genelvizyondakifilmsayacı = 4;
                yönetici_film_düzenle git = new yönetici_film_düzenle();
                git.Show();
            }
            if (listBox1.SelectedIndex == 8)
            {
                genelvizyondakifilmsayacı = 5;
                yönetici_film_düzenle git = new yönetici_film_düzenle();
                git.Show();
            }
            if (listBox1.SelectedIndex == 10)
            {
                genelvizyondakifilmsayacı = 6;
                yönetici_film_düzenle git = new yönetici_film_düzenle();
                git.Show();
            }
            if (listBox1.SelectedIndex == 12)
            {
                genelvizyondakifilmsayacı = 7;
                yönetici_film_düzenle git = new yönetici_film_düzenle();
                git.Show();
            }
            if (listBox1.SelectedIndex == 14)
            {
                genelvizyondakifilmsayacı = 8;
                yönetici_film_düzenle git = new yönetici_film_düzenle();
                git.Show();
            }
            else
            { 
            
            }
            //////////////////////////////////////////////////////////////
            
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

      

        private void listBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //////////////////YAKINDAKİ FİLMLERİ DÜZENLE/////////////////
            if (listBox2.SelectedIndex == 0)
            {
                genelyakındakifilmsayacı = 1;
                yönetici_yakındafilm_düzenle git2 = new yönetici_yakındafilm_düzenle();
                git2.Show();

            }
            else if (listBox2.SelectedIndex == 2)
            {
                genelyakındakifilmsayacı = 2;
                yönetici_yakındafilm_düzenle git2 = new yönetici_yakındafilm_düzenle();
                git2.Show();

            }
            else
            { 
            
            }
            ///////////////////////////////////////////////////////////////
        }
    }
}
