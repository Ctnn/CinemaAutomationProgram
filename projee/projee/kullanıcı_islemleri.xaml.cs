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
    /// Interaction logic for kullanıcı_islemleri.xaml
    /// </summary>
    public partial class kullanıcı_islemleri : Window
    {
        public kullanıcı_islemleri()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        int id;
        OleDbConnection baglanti = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source=sinema.accdb");
        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            OleDbCommand veri = new OleDbCommand("select * from Üye ", baglanti);
            OleDbDataReader oku = veri.ExecuteReader();
            while (oku.Read())
            {
                id = Convert.ToInt32(oku["id"]);
                string Ad = oku["ad"].ToString();
                string Soyad = oku["soyad"].ToString();
                string dogum_tarihi = oku["dogum_tarihi"].ToString();
                string kullanıcı_adı = oku["kullanıcı_adı"].ToString();
                string Cinsiyet = oku["Cinsiyet"].ToString();
                string ogrenim = oku["ogrenim_durumu"].ToString();
                string tel_no = oku["tel_no"].ToString();
                string sifre = oku["kullanıcı_sifre"].ToString();
                listBox1.Items.Add(id + "   " + Ad+"  "+Soyad+"  "+dogum_tarihi+"  "+kullanıcı_adı+"  "+sifre+"  "+Cinsiyet+"  "+ogrenim+"  "+tel_no);


            }
            baglanti.Close();
        }
        string idaldırma;
        public static string idtutturucu;
        private void listBox1_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {
           
            idaldırma = listBox1.SelectedItem.ToString();
          
           idtutturucu = idaldırma.Substring(0,3);
   
           kullanıcı_duzenle ac = new kullanıcı_duzenle();
           ac.Show();
           this.Close();
     
            
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void listBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {

            /////YÖNETİCİ PANELİNE DÖNÜŞ YAP////////
            yönetici_paneli dön = new yönetici_paneli();
            dön.Show();
            this.Close();
            ////////////////////////////////////////
        }
    }
}
