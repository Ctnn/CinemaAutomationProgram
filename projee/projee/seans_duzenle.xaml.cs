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
    /// Interaction logic for seans_duzenle.xaml
    /// </summary>
    public partial class seans_duzenle : Window
    {
        public seans_duzenle()
        {
            InitializeComponent();
        }
        int id;
        string Seans;
        OleDbConnection baglanti = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source=sinema.accdb");
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            OleDbCommand veri3 = new OleDbCommand("select * from Seanslar where id="+Convert.ToInt32(seans_islemleri.seans_sayac), baglanti);
            OleDbDataReader oku3 = veri3.ExecuteReader();
            while (oku3.Read())
            {
                 id = Convert.ToInt32(oku3["id"]);
                Seans = oku3["seans_saati"].ToString();
                textBox1.Text = id.ToString() ;

                textBox2.Text = Seans;
                


            }
            baglanti.Close();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            baglanti.Open();
            OleDbCommand veri = new OleDbCommand("update Seanslar set seans_saati='"+ textBox2.Text+"'where id="+Convert.ToInt32(textBox1.Text),baglanti);
            veri.ExecuteNonQuery();
            baglanti.Close();
            
        }
    }
}
