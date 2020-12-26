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
    /// Interaction logic for yöneticigirisi.xaml
    /// </summary>
    public partial class yöneticigirisi : Window
    {
        public yöneticigirisi()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source=sinema.accdb");
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            OleDbCommand veri = new OleDbCommand("select * from yönetici where yönetici_kullanıcıadı='" + textBox1.Text + "'and yönetici_sifre='" + textBox2.Text + "'  ", baglanti);
            OleDbDataReader oku = veri.ExecuteReader();
            while (oku.Read())
            {
                ///////////////DEĞER ALMA//////////////////////////////
                string yönetici_kullanıcıadı = oku["yönetici_kullanıcıadı"].ToString();
                string yönetici_sifre = oku["yönetici_sifre"].ToString();
               
                ////////////////////////////////////////////////////////
                /////////////ŞİFRE DOĞRULA/////////////////////////
                if (yönetici_kullanıcıadı == textBox1.Text && yönetici_sifre == textBox2.Text)
                {
                    kullanıcıanasayfa k_anasayfa = new kullanıcıanasayfa();
                    yönetici_paneli y_panel = new yönetici_paneli();
                    y_panel.Show();
                    this.Close();
                }
                //////////////////////////////////////////////////
            }
            baglanti.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow anamenü = new MainWindow();
            anamenü.Show();
            this.Close();
        }
    }
}
