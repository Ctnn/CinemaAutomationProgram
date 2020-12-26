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
    /// Interaction logic for vizyondakiler.xaml
    /// </summary>
    public partial class vizyondakiler : Window
    {
        public vizyondakiler()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source=sinema.accdb");
        int dolu_bos = 0;
          private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
         /*   baglanti.Open();
            for (int i = 1; i <= 7; i++)
            {
                int hafta = i;
                for (int j = 1; j <= 5; j++)
                {
                    int seans = j;
                    for (int k = 1; k <= 50; k++)
                    {
                        int koltuk = k;
                        OleDbCommand veria = new OleDbCommand("insert into salon2(haftano,seansno,koltukno,dolu_bos)values('"+Convert.ToInt32(hafta)+"','"+Convert.ToInt32(seans)+"','"+Convert.ToInt32(koltuk)+"','"+Convert.ToInt32(dolu_bos)+"');",baglanti);
                        veria.ExecuteNonQuery();
                    }
                }
            }
         
      
   
      
         
            baglanti.Close();*/
       
           
            ///////////////////FİLM 1//////////////////////////////////////////
            baglanti.Open();
            OleDbCommand veri = new OleDbCommand("select * from Vizyon where id=1",baglanti);
            OleDbDataReader oku = veri.ExecuteReader();
            while(oku.Read())
            {
               
                   string filmadı = oku["filmadı"].ToString();
                    string imdbpuanı = oku["imdb_puanı"].ToString();
                    string a = oku["film_resmi"].ToString();
                    label2.Content = filmadı;
                    label18.Content = imdbpuanı;
                    image1.Source = new ImageSourceConverter().ConvertFromString("Resimler\\" + a) as ImageSource;
           

                
            }
            ///////////////////////FİLM 2///////////////////////////////////////////
            OleDbCommand veri2 = new OleDbCommand("select * from Vizyon where id=2", baglanti);
            OleDbDataReader oku2 = veri2.ExecuteReader();
            while (oku2.Read())
            {

                string filmadı = oku2["filmadı"].ToString();
                string imdbpuanı = oku2["imdb_puanı"].ToString();
                string a = oku2["film_resmi"].ToString();
                label3.Content = filmadı;
                label19.Content = imdbpuanı;
                image2.Source = new ImageSourceConverter().ConvertFromString("Resimler\\" + a) as ImageSource;


            }
            ///////////////////////FİLM 3///////////////////////////////////////////
            OleDbCommand veri3 = new OleDbCommand("select * from Vizyon where id=3", baglanti);
            OleDbDataReader oku3 = veri3.ExecuteReader();
            while (oku3.Read())
            {

                string filmadı = oku3["filmadı"].ToString();
                string imdbpuanı = oku3["imdb_puanı"].ToString();
                label4.Content = filmadı;
                label20.Content = imdbpuanı;
                string a = oku3["film_resmi"].ToString();
                image3.Source = new ImageSourceConverter().ConvertFromString("Resimler\\" + a) as ImageSource;


            }
            ///////////////////////FİLM 4///////////////////////////////////////////
            OleDbCommand veri4 = new OleDbCommand("select * from Vizyon where id=4", baglanti);
            OleDbDataReader oku4 = veri4.ExecuteReader();
            while (oku4.Read())
            {

                string filmadı = oku4["filmadı"].ToString();
                string imdbpuanı = oku4["imdb_puanı"].ToString();
                label5.Content = filmadı;
                label21.Content = imdbpuanı;
                string a = oku4["film_resmi"].ToString();
                image4.Source = new ImageSourceConverter().ConvertFromString("Resimler\\" + a) as ImageSource;


            }
            ///////////////////////FİLM 5///////////////////////////////////////////
            OleDbCommand veri5 = new OleDbCommand("select * from Vizyon where id=5", baglanti);
            OleDbDataReader oku5 = veri5.ExecuteReader();
            while (oku5.Read())
            {

                string filmadı = oku5["filmadı"].ToString();
                string imdbpuanı = oku5["imdb_puanı"].ToString();
                label6.Content = filmadı;
                label22.Content = imdbpuanı;
                string a = oku5["film_resmi"].ToString();
                image5.Source = new ImageSourceConverter().ConvertFromString("Resimler\\" + a) as ImageSource;


            }
            ///////////////////////FİLM 6///////////////////////////////////////////
            OleDbCommand veri6 = new OleDbCommand("select * from Vizyon where id=6", baglanti);
            OleDbDataReader oku6 = veri6.ExecuteReader();
            while (oku6.Read())
            {

                string filmadı = oku6["filmadı"].ToString();
                string imdbpuanı = oku6["imdb_puanı"].ToString();
                label7.Content = filmadı;
                label23.Content = imdbpuanı;
                string a = oku6["film_resmi"].ToString();
                image6.Source = new ImageSourceConverter().ConvertFromString("Resimler\\" + a) as ImageSource;


            }
            ///////////////////////FİLM 7///////////////////////////////////////////
            OleDbCommand veri7 = new OleDbCommand("select * from Vizyon where id=7", baglanti);
            OleDbDataReader oku7 = veri7.ExecuteReader();
            while (oku7.Read())
            {

                string filmadı = oku7["filmadı"].ToString();
                string imdbpuanı = oku7["imdb_puanı"].ToString();
                label8.Content = filmadı;
                label24.Content = imdbpuanı;
                string a = oku7["film_resmi"].ToString();
                image7.Source = new ImageSourceConverter().ConvertFromString("Resimler\\" + a) as ImageSource;


            }
               ///////////////////////FİLM 8///////////////////////////////////////////
            OleDbCommand veri8 = new OleDbCommand("select * from Vizyon where id=8", baglanti);
            OleDbDataReader oku8 = veri8.ExecuteReader();
            while (oku8.Read())
            {

                string filmadı = oku8["filmadı"].ToString();
                string imdbpuanı = oku8["imdb_puanı"].ToString();
                label9.Content = filmadı;
                label25.Content = imdbpuanı;
                string a = oku8["film_resmi"].ToString();
                image8.Source = new ImageSourceConverter().ConvertFromString("Resimler\\" + a) as ImageSource;


            }
            baglanti.Close();
              /////////////////////////////////////////////////////////////////////
            
        }
         
        private void button1_Click(object sender, RoutedEventArgs e)
        {
        
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
         
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
           
        }
        public static int sayac = 0;
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            ///////FİLM 1///////////
            sayac = 1;
            filmbilgi filmac = new filmbilgi();
            filmac.Show();
            this.Close();
            //////////////////////
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
       
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            ///FİLM 2///////
            sayac = 2;
            filmbilgi filmac = new filmbilgi();
            filmac.Show();
            this.Close();
            ////////////////
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void button10_Click_1(object sender, RoutedEventArgs e)
        {
            //FİLM 3////
            sayac = 3;
            filmbilgi filmac = new filmbilgi();
            filmac.Show();
            this.Close();
            //////////
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            //FİLM 4////
            sayac = 4;
            filmbilgi filmac = new filmbilgi();
            filmac.Show();
            this.Close();
            //////////
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            //////FİLM 5//////////
            sayac = 5;
            filmbilgi filmac = new filmbilgi();
            filmac.Show();
            this.Close();
            ////////////////

        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            //////FİLM 6//////////
            sayac = 6;
            filmbilgi filmac = new filmbilgi();
            filmac.Show();
            this.Close();
            ////////////////
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            //////FİLM 7//////////
            sayac = 7;
            filmbilgi filmac = new filmbilgi();
            filmac.Show();
            this.Close();
            ////////////////
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            //////FİLM 8//////////
            sayac = 8;
            filmbilgi filmac = new filmbilgi();
            filmac.Show();
            this.Close();
            ////////////////
        }

        private void button3_Click_1(object sender, RoutedEventArgs e)
        {
            ///////ANA SAYFA FORMU////////////
            MainWindow anamenü = new MainWindow();
            anamenü.Show();
            this.Close();
            /////////////////////////////////
        }

        private void button4_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void button5_Click_1(object sender, RoutedEventArgs e)
        {
            ///////////YAKINDA FORMU/////////////////
            Yakında yakında = new Yakında();
            yakında.Show();
            this.Close();
            ////////////////////////////////////////
        }

        private void button6_Click_1(object sender, RoutedEventArgs e)
        {
            ///////SALONLAR///////
            Salonlar salon = new Salonlar();
            salon.Show();
            this.Close();
            /////////////////////
        }

        private void button9_Click_1(object sender, RoutedEventArgs e)
        {
            /////ÜYE OL//////////////
            uyeol kayıt = new uyeol();
            kayıt.Show();
            this.Close();
            ////////////////////////
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            ///////////ÜYE GİRİŞ/////////
            uyegirisi giris = new uyegirisi();
            giris.Show();
            this.Close();
            ////////////////////////////
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            /////YÖNETİCİ GİRİŞİ//
            yöneticigirisi y_girisi = new yöneticigirisi();
            y_girisi.Show();
            this.Close();
            //////////////////////
        }
       
    }
}
