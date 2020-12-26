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
    /// Interaction logic for yonetici_islem.xaml
    /// </summary>
    public partial class yonetici_islem : Window
    {
        public yonetici_islem()
        {
            InitializeComponent();
        }
        string idaldırma;
        public static string idtutturucu;
        private void listBox1_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {

            idaldırma = listBox1.SelectedItem.ToString();

            idtutturucu = idaldırma.Substring(0, 3);
            textBox3.Text = idtutturucu;
         



        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {

            /////YÖNETİCİ PANELİNE DÖNÜŞ YAP////////
            yönetici_paneli dön = new yönetici_paneli();
            dön.Show();
            this.Close();
            ////////////////////////////////////////
        }
        OleDbConnection baglanti = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source=sinema.accdb");
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();
                 baglanti.Open();
            OleDbCommand veri = new OleDbCommand("select * from yönetici ", baglanti);
            OleDbDataReader oku = veri.ExecuteReader();
            while (oku.Read())
            {
                int id = Convert.ToInt32(oku["id"]);
                string kullanıcıadı = oku["yönetici_kullanıcıadı"].ToString();
                string sifre = oku["yönetici_sifre"].ToString();
                listBox1.Items.Add(id+"  "+kullanıcıadı+"  "+sifre);
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            OleDbCommand veri = new OleDbCommand("insert into yönetici(yönetici_kullanıcıadı,yönetici_sifre)values('"+textBox1.Text+"','"+textBox2.Text+"')",baglanti);
            veri.ExecuteNonQuery();
            

            baglanti.Close();
            Window_Loaded(sender, e);

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            if (MessageBox.Show("Kayıdı Silmek İstediğinize Emin Misiniz ?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                OleDbCommand veri = new OleDbCommand("delete from yönetici where id=" + Convert.ToInt32(textBox3.Text), baglanti);
                OleDbDataReader oku = veri.ExecuteReader();
                MessageBox.Show("Üyelik İptal Edildi");
                baglanti.Close();
                
                Window_Loaded(sender,e);
               
              



            }
            else
            {
                //do yes stuff
            }
        
        }
    }
}
