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
    /// Interaction logic for yönetici_film_düzenle.xaml
    /// </summary>
    public partial class yönetici_film_düzenle : Window
    {
        public yönetici_film_düzenle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source=sinema.accdb");
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            OleDbCommand veri = new OleDbCommand("select * from Vizyon where id=" + yöneticifilmislem.genelvizyondakifilmsayacı, baglanti);
            OleDbDataReader oku = veri.ExecuteReader();
            while (oku.Read())
            {
                int id = Convert.ToInt32(oku["id"]);
                string filmadı = oku["filmadı"].ToString();
                string imdb_puanı = oku["imdb_puanı"].ToString();
                string filmacıklaması = oku["filmacıklaması"].ToString();
                textBox1.Text = filmadı;
                textBox2.Text = imdb_puanı;
                textBox3.Text = filmacıklaması;
                label4.Content = filmadı;
                string yonetmen = oku["yonetmen"].ToString();
                string film_turu = oku["film_turu"].ToString();
                string a = oku["film_resmi"].ToString();
                string b = oku["film_fragmanı"].ToString();
                textBox4.Text = a;
                textBox5.Text = b;
                textBox6.Text = yonetmen;
                textBox7.Text = film_turu;
                image1.Source = new ImageSourceConverter().ConvertFromString("Resimler\\" + a) as ImageSource;



            }
            baglanti.Close();
        }
        OpenFileDialog afd = new OpenFileDialog();
        string a;
        string filmacıklaması;
        private void button5_Click(object sender, RoutedEventArgs e)
        {

            afd.ShowDialog();
            textBox4.Text = afd.FileName;
            a = afd.SafeFileName;
            File.Copy(textBox4.Text, "Resimler\\" + a);
            image1.Source = new ImageSourceConverter().ConvertFromString("Resimler\\" + a) as ImageSource;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
          OleDbCommand veri = new OleDbCommand("update Vizyon set filmadı='"+textBox1.Text+"',imdb_puanı='"+textBox2.Text+"',filmacıklaması='"+textBox3.Text+"',film_resmi='"+textBox4.Text+"',film_fragmanı='"+textBox5.Text+"',yonetmen='"+textBox6.Text+"',film_turu='"+textBox7.Text+"' where id="+Convert.ToInt32(yöneticifilmislem.genelvizyondakifilmsayacı)+"'", baglanti);

            veri.ExecuteNonQuery();
            baglanti.Close();
          
        }
        string b;
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd;
            ofd = new OpenFileDialog();
            ofd.AddExtension = true;
            ofd.DefaultExt = "*.*";
            ofd.Filter = "Media Files (*.*)|*.*";
            ofd.ShowDialog();
            b = ofd.SafeFileName;
            textBox5.Text = ofd.FileName;
            File.Copy(textBox5.Text, "Resimler\\" + b);
            textBox5.Text = b;
            try
            {
               
        //        b = new Uri(ofd.FileName).ToString();
            //    textBox5.Text = b;
               
            
            }

            catch
            { 
            }

        }
    }
}
