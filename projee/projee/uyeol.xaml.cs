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
    /// Interaction logic for uyeol.xaml
    /// </summary>
    public partial class uyeol : Window
    {
        public uyeol()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ///////ANA SAYFA FORMU////////////
            MainWindow anamenü = new MainWindow();
            anamenü.Show();
            this.Close();
            /////////////////////////////////
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ///////////VİZYON FORMU/////////////////
            vizyondakiler vizyon = new vizyondakiler();
            vizyon.Show();
            this.Close();
            ////////////////////////////////////////
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            ///////////YAKINDA FORMU/////////////////
            Yakında yakında = new Yakında();
            yakında.Show();
            this.Close();
            ////////////////////////////////////////
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ////////////ÜYE GİRİŞİ/////////////
            uyegirisi giris = new uyegirisi();
            giris.Show();
            this.Close();
            //////////////////////////////////
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            /////YÖNETİCİ GİRİŞİ//
            yöneticigirisi y_girisi = new yöneticigirisi();
            y_girisi.Show();
            this.Close();
            //////////////////////
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {

        }
        OleDbConnection baglanti = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source=sinema.accdb");
        string cinsiyet;
        string ogrenim;
        private void button9_Click(object sender, RoutedEventArgs e)
        {
            //////////////////////CİNSİYET ALMA VE ÖĞRENİM DURUMU/////////////////
            if (radioButton1.IsChecked == true)
            {
                cinsiyet = "Erkek";
            }
            if (radioButton2.IsChecked == true)
            {
                cinsiyet = "Kadın";
            }
            if (radioButton3.IsChecked == true)
            {
                ogrenim = "Sivil";
            }
            if (radioButton4.IsChecked == true)
            {
                ogrenim = "Öğrenci";
            }
            ////////////////////////////////////////////////////
             

            //////////////////////////////BOŞ OLMASIN !/////////////////////////////
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "" && textBox7.Text == "" && textBox8.Text == "" )
            {
                MessageBox.Show("Lütfen Boş Bırakmayınız");

            }
            ///////////////////////////////////////////////////////////////////////
            else
            { 
                /////////////ŞİFRE KONTROL////////////////////////////////////////
                if (textBox5.Text != textBox6.Text)
                {
                    MessageBox.Show("Şifreniz Uyuşmuyor Kontrol Ediniz");
                }
                    ///////////////////////////////////////////////////
                else
                { 
                    ///////////////ŞİFRE UZUNLUĞU///////////////////////
                    if (Convert.ToInt32(textBox5.Text.Length) < 4 && Convert.ToInt32(textBox6.Text.Length) < 4)
                    { 
                    
                    }
               //////////////////////////////////////////////////////////////////
                    else
                    {
                //////////////////KAYIT KISMI///////////////////////////////////

                        baglanti.Open();
                        OleDbCommand veri = new OleDbCommand("insert into Üye(ad,soyad,dogum_tarihi,kullanıcı_adı,kullanıcı_sifre,Gizli_soru,Gizli_soru_cevap,Cinsiyet,ogrenim_durumu,Tel_no)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','"+comboBox1.Text+"','"+textBox7.Text+"','"+cinsiyet+"','"+ogrenim+"','"+textBox8.Text+"')", baglanti);
                    veri.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarıyla Eklendi");
                    baglanti.Close();
                
                }
                }
                
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
