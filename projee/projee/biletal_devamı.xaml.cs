using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.OleDb;
using System.Windows.Threading;


//using Microsoft.Win32;

namespace projee
{
    /// <summary>
    /// Interaction logic for biletal_devamı.xaml
    /// </summary>
    public partial class biletal_devamı : Window
    {
        public biletal_devamı()
        {
            InitializeComponent();
        }
        
        int a = 0, a1 = 0, a2 = 0, a3 = 0, a4 = 0, a5 = 0, a6 = 0, a7 = 0, a8 = 0, a9 = 0, a10 = 0, a11 = 0, a12 = 0, a13 = 0, a14 = 0, a15 = 0, a16 = 0, a17 = 0, a18 = 0, a19 = 0, a20 = 0, a21 = 0, a22 = 0, a23 = 0, a24 = 0, a25 = 0, a26 = 0, a27 = 0, a28 = 0, a29 = 0, a30 = 0, a31 = 0, a32 = 0, a33 = 0, a34, a35 = 0, a36 = 0, a37 = 0, a38 = 0, a39 = 0, a40 = 0,a41=0,a42=0,a43=0,a44=0,a45=0,a46=0,a47=0,a48=0,a49=0;
        string[] dizi = new string[50];
      
        OleDbConnection baglanti = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source=sinema.accdb");
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            //////////////LABELA SALON FELAN YAZDIRMA :D//////////////
            label3.Content = biletal.film;
            label5.Content = biletal.filmno;
            label7.Content = biletal.seans;
            textBox1.Text = uyegirisi.kullanıcı_adı;

            //////////////////////////////////////////////////////////
            ///////////GÜN ALDIRMA//////////////////////////////////
             gun = DateTime.Now.Day;
             ay=DateTime.Now.Month;
             yıl = DateTime.Now.Year;
            ///////////////////////////////////////////////////////
            ///////////KOLTUK KONTROL/////////////////////////////
            //////////////////E SIRASI////////////////////////////
             baglanti.Open();
             OleDbCommand veri2 = new OleDbCommand("select * from satis where film_ID='"+label5.Content+"' and salon_ID='"+label5.Content+"'", baglanti);
             OleDbDataReader oku2 = veri2.ExecuteReader();
            
             while (oku2.Read())
             {
                 string a=button2.Content.ToString();

                                  
                 string dolu_bos = oku2["dolu_bos"].ToString();
                 string koltuk_No = oku2["koltuk_No"].ToString();
                 
                 
                 if (a==koltuk_No)
                 {
               
                     if (dolu_bos =="1")
                     {
                         
                     
                         button2.IsEnabled = false;
                     
                     }
                     
                 }
             }
             baglanti.Close();
             baglanti.Open();
             OleDbCommand veri3 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku3 = veri3.ExecuteReader();

             while (oku3.Read())
             {
                 string a = button3.Content.ToString();


                 string dolu_bos = oku3["dolu_bos"].ToString();
                 string koltuk_No = oku3["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {
                  
                     if (dolu_bos == "1")
                     {

                       
                         button3.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close();
             baglanti.Open();
             OleDbCommand veri4 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku4 = veri4.ExecuteReader();

             while (oku4.Read())
             {
                 string a = button4.Content.ToString();


                 string dolu_bos = oku4["dolu_bos"].ToString();
                 string koltuk_No = oku4["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {
                     //    listBox1.Items.Add(dolu_bos + koltuk_No);
                     if (dolu_bos == "1")
                     {

                  
                         button4.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close();
             baglanti.Open();
             OleDbCommand veri5 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku5 = veri5.ExecuteReader();

             while (oku5.Read())
             {
                 string a = button5.Content.ToString();


                 string dolu_bos = oku5["dolu_bos"].ToString();
                 string koltuk_No = oku5["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {
                     //    listBox1.Items.Add(dolu_bos + koltuk_No);
                     if (dolu_bos == "1")
                     {  
                         button5.IsEnabled = false;
                     }

                 }
             }
             baglanti.Close();
             baglanti.Open();
             OleDbCommand veri6 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku6 = veri6.ExecuteReader();

             while (oku6.Read())
             {
                 string a = button6.Content.ToString();


                 string dolu_bos = oku6["dolu_bos"].ToString();
                 string koltuk_No = oku6["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {
                    
                     if (dolu_bos == "1")
                     {

                        
                         button6.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close();
             baglanti.Open();
             OleDbCommand veri7 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku7 = veri7.ExecuteReader();

             while (oku7.Read())
             {
                 string a = button7.Content.ToString();


                 string dolu_bos = oku7["dolu_bos"].ToString();
                 string koltuk_No = oku7["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button7.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close();
             baglanti.Open();
             OleDbCommand veri8 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku8 = veri8.ExecuteReader();

             while (oku8.Read())
             {
                 string a = button8.Content.ToString();


                 string dolu_bos = oku8["dolu_bos"].ToString();
                 string koltuk_No = oku8["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button8.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close();
             baglanti.Open();
             OleDbCommand veri9 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku9 = veri9.ExecuteReader();

             while (oku9.Read())
             {
                 string a = button9.Content.ToString();


                 string dolu_bos = oku9["dolu_bos"].ToString();
                 string koltuk_No = oku9["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button9.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close();
            ///////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////D SIRASI///////////////////////////////////////////////////////
             baglanti.Open();
             OleDbCommand veri10 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku10 = veri10.ExecuteReader();

             while (oku10.Read())
             {
                 string a = button10.Content.ToString();


                 string dolu_bos = oku10["dolu_bos"].ToString();
                 string koltuk_No = oku10["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button10.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close();
             baglanti.Open();
             OleDbCommand veri11 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku11 = veri11.ExecuteReader();

             while (oku11.Read())
             {
                 string a = button11.Content.ToString();


                 string dolu_bos = oku11["dolu_bos"].ToString();
                 string koltuk_No = oku11["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button11.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close();
             baglanti.Open();
             OleDbCommand veri12 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku12 = veri12.ExecuteReader();

             while (oku12.Read())
             {
                 string a = button12.Content.ToString();


                 string dolu_bos = oku12["dolu_bos"].ToString();
                 string koltuk_No = oku12["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button12.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close();
             baglanti.Open();
             OleDbCommand veri13 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku13 = veri13.ExecuteReader();

             while (oku13.Read())
             {
                 string a = button13.Content.ToString();


                 string dolu_bos = oku13["dolu_bos"].ToString();
                 string koltuk_No = oku13["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button13.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close();
             baglanti.Open();
             OleDbCommand veri14 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku14 = veri14.ExecuteReader();

             while (oku14.Read())
             {
                 string a = button14.Content.ToString();


                 string dolu_bos = oku14["dolu_bos"].ToString();
                 string koltuk_No = oku14["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button14.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close();
             baglanti.Open();
             OleDbCommand veri15 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku15 = veri15.ExecuteReader();

             while (oku15.Read())
             {
                 string a = button15.Content.ToString();


                 string dolu_bos = oku15["dolu_bos"].ToString();
                 string koltuk_No = oku15["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button15.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri16 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku16 = veri16.ExecuteReader();

             while (oku16.Read())
             {
                 string a = button16.Content.ToString();


                 string dolu_bos = oku16["dolu_bos"].ToString();
                 string koltuk_No = oku16["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button16.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri17 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku17 = veri17.ExecuteReader();

             while (oku17.Read())
             {
                 string a = button17.Content.ToString();


                 string dolu_bos = oku17["dolu_bos"].ToString();
                 string koltuk_No = oku17["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button17.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close();
            /////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////C SIRASI////////////////////////////////////////////////
             baglanti.Open();
             OleDbCommand veri18 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku18= veri18.ExecuteReader();

             while (oku18.Read())
             {
                 string a = button18.Content.ToString();


                 string dolu_bos = oku18["dolu_bos"].ToString();
                 string koltuk_No = oku18["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button18.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri19 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku19 = veri19.ExecuteReader();

             while (oku19.Read())
             {
                 string a = button19.Content.ToString();


                 string dolu_bos = oku19["dolu_bos"].ToString();
                 string koltuk_No = oku19["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button19.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri20 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku20 = veri20.ExecuteReader();

             while (oku20.Read())
             {
                 string a = button20.Content.ToString();


                 string dolu_bos = oku20["dolu_bos"].ToString();
                 string koltuk_No = oku20["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button20.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri21 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku21 = veri21.ExecuteReader();

             while (oku21.Read())
             {
                 string a = button21.Content.ToString();


                 string dolu_bos = oku21["dolu_bos"].ToString();
                 string koltuk_No = oku21["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button21.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri22 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku22 = veri22.ExecuteReader();

             while (oku22.Read())
             {
                 string a = button22.Content.ToString();


                 string dolu_bos = oku22["dolu_bos"].ToString();
                 string koltuk_No = oku22["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button22.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri23 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku23 = veri23.ExecuteReader();

             while (oku23.Read())
             {
                 string a = button23.Content.ToString();


                 string dolu_bos = oku23["dolu_bos"].ToString();
                 string koltuk_No = oku23["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button23.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri24 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku24= veri24.ExecuteReader();

             while (oku24.Read())
             {
                 string a = button24.Content.ToString();


                 string dolu_bos = oku24["dolu_bos"].ToString();
                 string koltuk_No = oku24["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button24.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri25 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku25 = veri25.ExecuteReader();

             while (oku25.Read())
             {
                 string a = button25.Content.ToString();


                 string dolu_bos = oku25["dolu_bos"].ToString();
                 string koltuk_No = oku25["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button25.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri26 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku26 = veri26.ExecuteReader();

             while (oku26.Read())
             {
                 string a = button26.Content.ToString();


                 string dolu_bos = oku26["dolu_bos"].ToString();
                 string koltuk_No = oku26["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button26.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri27 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku27 = veri27.ExecuteReader();

             while (oku27.Read())
             {
                 string a = button27.Content.ToString();


                 string dolu_bos = oku27["dolu_bos"].ToString();
                 string koltuk_No = oku27["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button27.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close();
            ///////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////B SIRASI///////////////////////////////////////////
             baglanti.Open();
             OleDbCommand veri28 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku28 = veri28.ExecuteReader();

             while (oku28.Read())
             {
                 string a = button28.Content.ToString();


                 string dolu_bos = oku28["dolu_bos"].ToString();
                 string koltuk_No = oku28["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button28.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri29 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku29 = veri29.ExecuteReader();

             while (oku29.Read())
             {
                 string a = button29.Content.ToString();


                 string dolu_bos = oku29["dolu_bos"].ToString();
                 string koltuk_No = oku29["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button29.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri30 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku30 = veri30.ExecuteReader();

             while (oku30.Read())
             {
                 string a = button30.Content.ToString();


                 string dolu_bos = oku30["dolu_bos"].ToString();
                 string koltuk_No = oku30["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button30.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri31 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku31 = veri31.ExecuteReader();

             while (oku31.Read())
             {
                 string a = button31.Content.ToString();


                 string dolu_bos = oku31["dolu_bos"].ToString();
                 string koltuk_No = oku31["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button31.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri32 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku32 = veri32.ExecuteReader();

             while (oku32.Read())
             {
                 string a = button32.Content.ToString();


                 string dolu_bos = oku32["dolu_bos"].ToString();
                 string koltuk_No = oku32["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button32.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri33 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku33 = veri33.ExecuteReader();

             while (oku33.Read())
             {
                 string a = button33.Content.ToString();


                 string dolu_bos = oku33["dolu_bos"].ToString();
                 string koltuk_No = oku33["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button33.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri34 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku34 = veri34.ExecuteReader();

             while (oku34.Read())
             {
                 string a = button34.Content.ToString();


                 string dolu_bos = oku34["dolu_bos"].ToString();
                 string koltuk_No = oku34["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button34.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri35 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku35 = veri35.ExecuteReader();

             while (oku35.Read())
             {
                 string a = button35.Content.ToString();


                 string dolu_bos = oku35["dolu_bos"].ToString();
                 string koltuk_No = oku35["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button35.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri36 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku36 = veri36.ExecuteReader();

             while (oku36.Read())
             {
                 string a = button36.Content.ToString();


                 string dolu_bos = oku36["dolu_bos"].ToString();
                 string koltuk_No = oku36["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button36.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri37 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku37 = veri37.ExecuteReader();

             while (oku37.Read())
             {
                 string a = button37.Content.ToString();


                 string dolu_bos = oku37["dolu_bos"].ToString();
                 string koltuk_No = oku37["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button37.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri38 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku38 = veri38.ExecuteReader();

             while (oku38.Read())
             {
                 string a = button38.Content.ToString();


                 string dolu_bos = oku38["dolu_bos"].ToString();
                 string koltuk_No = oku38["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button38.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri39 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku39 = veri39.ExecuteReader();

             while (oku39.Read())
             {
                 string a = button39.Content.ToString();


                 string dolu_bos = oku39["dolu_bos"].ToString();
                 string koltuk_No = oku39["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button39.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close();
            ////////////////////////////////////A SIRASI/////////////////////////////////////////////////
             baglanti.Open();
             OleDbCommand veri40 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku40 = veri40.ExecuteReader();

             while (oku40.Read())
             {
                 string a = button40.Content.ToString();


                 string dolu_bos = oku40["dolu_bos"].ToString();
                 string koltuk_No = oku40["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button40.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri41 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku41 = veri41.ExecuteReader();

             while (oku41.Read())
             {
                 string a = button41.Content.ToString();


                 string dolu_bos = oku41["dolu_bos"].ToString();
                 string koltuk_No = oku41["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button41.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri42 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku42 = veri42.ExecuteReader();

             while (oku42.Read())
             {
                 string a = button42.Content.ToString();


                 string dolu_bos = oku42["dolu_bos"].ToString();
                 string koltuk_No = oku42["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button42.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri43 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku43 = veri43.ExecuteReader();

             while (oku43.Read())
             {
                 string a = button43.Content.ToString();


                 string dolu_bos = oku43["dolu_bos"].ToString();
                 string koltuk_No = oku43["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button43.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri44 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku44 = veri44.ExecuteReader();

             while (oku44.Read())
             {
                 string a = button44.Content.ToString();


                 string dolu_bos = oku44["dolu_bos"].ToString();
                 string koltuk_No = oku44["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button44.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri45 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku45 = veri45.ExecuteReader();

             while (oku45.Read())
             {
                 string a = button45.Content.ToString();


                 string dolu_bos = oku45["dolu_bos"].ToString();
                 string koltuk_No = oku45["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button45.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri46 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku46 = veri46.ExecuteReader();

             while (oku46.Read())
             {
                 string a = button46.Content.ToString();


                 string dolu_bos = oku46["dolu_bos"].ToString();
                 string koltuk_No = oku46["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button46.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri47= new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku47 = veri47.ExecuteReader();

             while (oku47.Read())
             {
                 string a = button47.Content.ToString();


                 string dolu_bos = oku47["dolu_bos"].ToString();
                 string koltuk_No = oku47["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button47.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri48 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku48 = veri48.ExecuteReader();

             while (oku48.Read())
             {
                 string a = button48.Content.ToString();


                 string dolu_bos = oku48["dolu_bos"].ToString();
                 string koltuk_No = oku48["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button48.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri49 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku49 = veri49.ExecuteReader();

             while (oku49.Read())
             {
                 string a = button49.Content.ToString();


                 string dolu_bos = oku49["dolu_bos"].ToString();
                 string koltuk_No = oku49["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button49.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri50 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku50 = veri50.ExecuteReader();

             while (oku50.Read())
             {
                 string a = button50.Content.ToString();


                 string dolu_bos = oku50["dolu_bos"].ToString();
                 string koltuk_No = oku50["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button50.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close(); baglanti.Open();
             OleDbCommand veri51 = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
             OleDbDataReader oku51 = veri51.ExecuteReader();

             while (oku51.Read())
             {
                 string a = button51.Content.ToString();


                 string dolu_bos = oku51["dolu_bos"].ToString();
                 string koltuk_No = oku51["koltuk_No"].ToString();


                 if (a == koltuk_No)
                 {

                     if (dolu_bos == "1")
                     {


                         button51.IsEnabled = false;

                     }

                 }
             }
             baglanti.Close();
            /////////////////////////////////////////////////////////////////////////////////////////////


        
        }
        int yıl, ay, gun;
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if(a==0)
            {
            button2.Background = Brushes.Red;
                a = 1;

              
                textBox7.Text = "e1";

            }
            else
            {
                button2.Background = Brushes.Chartreuse;
                a=0;
                textBox7.Text = "";
            }
            baglanti.Open();
            OleDbCommand veri = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
            OleDbDataReader oku = veri.ExecuteReader();

            while (oku.Read())
            {
                string b = button2.Content.ToString();


                string dolu_bos = oku["dolu_bos"].ToString();
                string koltuk_No = oku["koltuk_No"].ToString();
               

                if (b == koltuk_No)
                {
                    
                    if (dolu_bos == "0")
                    {
                        if (a == 1)
                        {
                            dizi[0] = "e1";
                          
                        }
                        if (a == 0)
                        {
                            dizi[0] = "";
                            
                        }
                       
                        

                    }

                }
            }
            baglanti.Close();
            

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
          /*  string tarih_alıcı;
            tarih_alıcı=gun.ToString()+"."+ay.ToString()+"."+yıl.ToString();
            textBox7.Text= tarih_alıcı;*/
            baglanti.Open();
            OleDbCommand veri = new OleDbCommand("insert into satis(Film_Adi,film_ID,salon_ID,seans,satis_Adi,satis_Soyadi,koltuk_No,ucret)values('"+label3.Content+"','" + label5.Content + "','" + label5.Content + "','" + label7.Content + "','" + uyegirisi.ad + "','" + uyegirisi.soyad + "','" + textBox7.Text + "','" + ucret + "')", baglanti);
            veri.ExecuteNonQuery();
          //BURAYA BAK HATALI  MessageBox.Show("Rezervasyon Başarıyla Gerçekleştirilmiştir Gişelerden Ödemenizi Yaparak Biletinizi Alabilirsinizi");
            kullanıcıanasayfa k_anasayfa = new kullanıcıanasayfa();
            k_anasayfa.Show();
            this.Close();
            baglanti.Close();
        
        }
       

    
        

        private void button52_Click(object sender, RoutedEventArgs e)
        {
            ///////GERİ SAYFA////////
            this.Show();
            biletal ac = new biletal();
            ac.Show();
          
            /////////////////////////
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (a1 == 0)
            {
                button3.Background = Brushes.Red;
                a1 = 1;
                textBox7.Text = "e2";
            }
            else
            {
                button3.Background = Brushes.Chartreuse;
                a1 = 0;
                textBox7.Text = "";
            }
            baglanti.Open();
            OleDbCommand veri = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
            OleDbDataReader oku = veri.ExecuteReader();

            while (oku.Read())
            {
                string b = button3.Content.ToString();


                string dolu_bos = oku["dolu_bos"].ToString();
                string koltuk_No = oku["koltuk_No"].ToString();


                if (b == koltuk_No)
                {

                    if (dolu_bos == "0")
                    {
                        if (a == 1)
                        {
                            dizi[1] = "e2";

                        }
                        if (a == 0)
                        {
                            dizi[1] = "";

                        }



                    }

                }
            }
            baglanti.Close();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (a2 == 0)
            {
                button4.Background = Brushes.Red;
                a2 = 1; textBox7.Text = "e3";
            }
            else
            {
                button4.Background = Brushes.Chartreuse;
                a2 = 0;
                textBox7.Text = "";
            }
            baglanti.Open();
            OleDbCommand veri = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
            OleDbDataReader oku = veri.ExecuteReader();

            while (oku.Read())
            {
                string b = button4.Content.ToString();


                string dolu_bos = oku["dolu_bos"].ToString();
                string koltuk_No = oku["koltuk_No"].ToString();


                if (b == koltuk_No)
                {

                    if (dolu_bos == "0")
                    {
                        if (a == 1)
                        {
                            dizi[2] = "e3";

                        }
                        if (a == 0)
                        {
                            dizi[2] = "";

                        }



                    }

                }
            }
            baglanti.Close();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (a3 == 0)
            {
                button5.Background = Brushes.Red;
                a3 = 1; textBox7.Text = "e4";
            }
            else
            {
                button5.Background = Brushes.Chartreuse;
                a3 = 0; textBox7.Text = "";
            }
            baglanti.Open();
            OleDbCommand veri = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
            OleDbDataReader oku = veri.ExecuteReader();

            while (oku.Read())
            {
                string b = button5.Content.ToString();


                string dolu_bos = oku["dolu_bos"].ToString();
                string koltuk_No = oku["koltuk_No"].ToString();


                if (b == koltuk_No)
                {

                    if (dolu_bos == "0")
                    {
                        if (a == 1)
                        {
                            dizi[3] = "e4";

                        }
                        if (a == 0)
                        {
                            dizi[3] = "";

                        }



                    }

                }
            }
            baglanti.Close();

        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (a4 == 0)
            {
                button6.Background = Brushes.Red;
                a4 = 1; textBox7.Text = "e5";
            }
            else
            {
                button6.Background = Brushes.Chartreuse;
                a4 = 0; textBox7.Text = "";
            }
            baglanti.Open();
            OleDbCommand veri = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
            OleDbDataReader oku = veri.ExecuteReader();

            while (oku.Read())
            {
                string b = button6.Content.ToString();


                string dolu_bos = oku["dolu_bos"].ToString();
                string koltuk_No = oku["koltuk_No"].ToString();


                if (b == koltuk_No)
                {

                    if (dolu_bos == "0")
                    {
                        if (a == 1)
                        {
                            dizi[4] = "e5";

                        }
                        if (a == 0)
                        {
                            dizi[4] = "";

                        }



                    }

                }
            }
            baglanti.Close();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (a5 == 0)
            {
                button7.Background = Brushes.Red; textBox7.Text = "e6";
                a5 = 1;
            }
            else
            {
                button4.Background = Brushes.Chartreuse;
                a5 = 0; textBox7.Text = "";
            }
            baglanti.Open();
            OleDbCommand veri = new OleDbCommand("select * from satis where film_ID='" + label5.Content + "' and salon_ID='" + label5.Content + "'", baglanti);
            OleDbDataReader oku = veri.ExecuteReader();

            while (oku.Read())
            {
                string b = button7.Content.ToString();


                string dolu_bos = oku["dolu_bos"].ToString();
                string koltuk_No = oku["koltuk_No"].ToString();


                if (b == koltuk_No)
                {

                    if (dolu_bos == "0")
                    {
                        if (a == 1)
                        {
                            dizi[5] = "e6";

                        }
                        if (a == 0)
                        {
                            dizi[5] = "";

                        }



                    }

                }
            }
            baglanti.Close();
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (a6 == 0)
            {
                button8.Background = Brushes.Red;
                a6 = 1; textBox7.Text = "e";
            }
            else
            {
                button8.Background = Brushes.Chartreuse;
                a6 = 0; textBox7.Text = "";
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (a7 == 0)
            {
                button9.Background = Brushes.Red; textBox7.Text = "e8";
                a7 = 1;
            }
            else
            {
                button9.Background = Brushes.Chartreuse;
                a7 = 0; textBox7.Text = "";
            }
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            if (a8 == 0)
            {
                button10.Background = Brushes.Red; textBox7.Text = "d1";
                a8= 1;
            }
            else
            {
                button10.Background = Brushes.Chartreuse;
                a8 = 0; textBox7.Text = "";
            }
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            if (a9 == 0)
            {
                button11.Background = Brushes.Red; textBox7.Text = "d2";
                a9 = 1;
            }
            else
            {
                button11.Background = Brushes.Chartreuse;
                a9 = 0; textBox7.Text = "";
            }
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            if (a10 == 0)
            {
                button12.Background = Brushes.Red;
                a10 = 1; textBox7.Text = "d3";
            }
            else
            {
                button12.Background = Brushes.Chartreuse;
                a10 = 0; textBox7.Text = "";
            }
        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            if (a11 == 0)
            {
                button13.Background = Brushes.Red;
                a11 = 1; textBox7.Text = "d4";
            }
            else
            {
                button13.Background = Brushes.Chartreuse;
                a11 = 0; textBox7.Text = "";
            }
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            if (a12 == 0)
            {
                button14.Background = Brushes.Red;
                a12 = 1; textBox7.Text = "d5";
             
            }
            else
            {
                button14.Background = Brushes.Chartreuse;
                a12 = 0; textBox7.Text = "";
            }
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            if (a13== 0)
            {
                button15.Background = Brushes.Red;
                a13 = 1; textBox7.Text = "d6";
            }
            else
            {
                button15.Background = Brushes.Chartreuse;
                a13 = 0; textBox7.Text = "";
            }
        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            if (a14 == 0)
            {
                button16.Background = Brushes.Red;
                a14 = 1; textBox7.Text = "d7";
            }
            else
            {
                button16.Background = Brushes.Chartreuse;
                a14 = 0; textBox7.Text = "";
            }
        }

        private void button17_Click(object sender, RoutedEventArgs e)
        {
            if (a15 == 0)
            {
                button17.Background = Brushes.Red;
                a15 = 1; textBox7.Text = "d8";
            }
            else
            {
                button17.Background = Brushes.Chartreuse;
                a15 = 0; textBox7.Text = "";
            }
        }

        private void button18_Click(object sender, RoutedEventArgs e)
        {
            if (a16 == 0)
            {
                button18.Background = Brushes.Red;
                a16 = 1; textBox7.Text = "c1";
            }
            else
            {
                button18.Background = Brushes.Chartreuse;
                a16 = 0; textBox7.Text = "";
            }
        }

        private void button19_Click(object sender, RoutedEventArgs e)
        {
            if (a17 == 0)
            {
                button19.Background = Brushes.Red;
                a17 = 1; textBox7.Text = "c2";
            }
            else
            {
                button19.Background = Brushes.Chartreuse;
                a17 = 0; textBox7.Text = "";
            }
        }

        private void button20_Click(object sender, RoutedEventArgs e)
        {
            if (a18 == 0)
            {
                button20.Background = Brushes.Red;
                a18 = 1; textBox7.Text = "c3";
            }
            else
            {
                button20.Background = Brushes.Chartreuse;
                a18 = 0; textBox7.Text = "";
            }
        }

        private void button21_Click(object sender, RoutedEventArgs e)
        {
            if (a19== 0)
            {
                button21.Background = Brushes.Red;
                a19 = 1; textBox7.Text = "c4";
            }
            else
            {
                button21.Background = Brushes.Chartreuse;
                a19 = 0; textBox7.Text = "";
            }

        }

        private void button22_Click(object sender, RoutedEventArgs e)
        {
            if (a20 == 0)
            {
                button22.Background = Brushes.Red;
                a20 = 1; textBox7.Text = "c5";
            }
            else
            {
                button22.Background = Brushes.Chartreuse;
                a20 = 0; textBox7.Text = "";
            }
        }

        private void button23_Click(object sender, RoutedEventArgs e)
        {
            if (a21== 0)
            {
                button23.Background = Brushes.Red;
                a21 = 1; textBox7.Text = "c6";
            }
            else
            {
                button23.Background = Brushes.Chartreuse;
                a21 = 0; textBox7.Text = "";
            }
        }

        private void button24_Click(object sender, RoutedEventArgs e)
        {
            if (a22 == 0)
            {
                button24.Background = Brushes.Red;
                a22 = 1; textBox7.Text = "c7";
            }
            else
            {
                button24.Background = Brushes.Chartreuse;
                a22 = 0; textBox7.Text = "";
            }
        }

        private void button25_Click(object sender, RoutedEventArgs e)
        {
            if (a23 == 0)
            {
                button25.Background = Brushes.Red;
                a23 = 1; textBox7.Text = "c8";
            }
            else
            {
                button25.Background = Brushes.Chartreuse;
                a23 = 0; textBox7.Text = "";
            }
        }

        private void button26_Click(object sender, RoutedEventArgs e)
        {
            if (a24 == 0)
            {
                button26.Background = Brushes.Red;
                a24 = 1; textBox7.Text = "c9";
            }
            else
            {
                button26.Background = Brushes.Chartreuse;
                a24 = 0; textBox7.Text = "";
            }
        }

        private void button27_Click(object sender, RoutedEventArgs e)
        {
            if (a25 == 0)
            {
                button27.Background = Brushes.Red;
                a25 = 1; textBox7.Text = "c10";
            }
            else
            {
                button27.Background = Brushes.Chartreuse;
                a25 = 0; textBox7.Text = "";
            }
        }

        private void button28_Click(object sender, RoutedEventArgs e)
        {
            if (a26 == 0)
            {
                button28.Background = Brushes.Red;
                a26 = 1; textBox7.Text = "b1";
            }
            else
            {
                button28.Background = Brushes.Chartreuse;
                a26 = 0; textBox7.Text = "";
            }
        }

        private void button29_Click(object sender, RoutedEventArgs e)
        {
            if (a27 == 0)
            {
                button29.Background = Brushes.Red;
                a27 = 1; textBox7.Text = "b2";
            }
            else
            {
                button29.Background = Brushes.Chartreuse;
                a27 = 0; textBox7.Text = "";
            }
        }

        private void button30_Click(object sender, RoutedEventArgs e)
        {
            if (a28 == 0)
            {
                button30.Background = Brushes.Red;
                a28 = 1; textBox7.Text = "b3";
            }
            else
            {
                button30.Background = Brushes.Chartreuse;
                a28 = 0; textBox7.Text = "";
            }
        }

        private void button31_Click(object sender, RoutedEventArgs e)
        {
            if (a29 == 0)
            {
                button31.Background = Brushes.Red;
                a29 = 1; textBox7.Text = "b4";
            }
            else
            {
                button31.Background = Brushes.Chartreuse;
                a29 = 0; textBox7.Text = "";
            }
        }

        private void button32_Click(object sender, RoutedEventArgs e)
        {
            if (a30 == 0)
            {
                button32.Background = Brushes.Red;
                a30 = 1; textBox7.Text = "b5";
            }
            else
            {
                button32.Background = Brushes.Chartreuse;
                a30 = 0; textBox7.Text = "";
            }
        }

        private void button33_Click(object sender, RoutedEventArgs e)
        {
            if (a31 == 0)
            {
                button33.Background = Brushes.Red;
                a31 = 1; textBox7.Text = "b6";
            }
            else
            {
                button33.Background = Brushes.Chartreuse;
                a31 = 0; textBox7.Text = "";
            }
        }

        private void button34_Click(object sender, RoutedEventArgs e)
        {
            if (a32 == 0)
            {
                button34.Background = Brushes.Red;
                a32 = 1; textBox7.Text = "b7";
            }
            else
            {
                button34.Background = Brushes.Chartreuse;
                a32 = 0; textBox7.Text = "";
            }
        }

        private void button35_Click(object sender, RoutedEventArgs e)
        {
            if (a33 == 0)
            {
                button35.Background = Brushes.Red;
                a33 = 1; textBox7.Text = "b8";
            }
            else
            {
                button35.Background = Brushes.Chartreuse;
                a33 = 0; textBox7.Text = "";
            }
        }

        private void button36_Click(object sender, RoutedEventArgs e)
        {
            if (a34 == 0)
            {
                button36.Background = Brushes.Red;
                a34 = 1; textBox7.Text = "b9";
            }
            else
            {
                button36.Background = Brushes.Chartreuse;
                a34 = 0; textBox7.Text = "";
            }
        }

        private void button37_Click(object sender, RoutedEventArgs e)
        {
            if (a35 == 0)
            {
                button37.Background = Brushes.Red;
                a35 = 1; textBox7.Text = "b10";
            }
            else
            {
                button37.Background = Brushes.Chartreuse;
                a35 = 0; textBox7.Text = "";
            }
        }

        private void button38_Click(object sender, RoutedEventArgs e)
        {
            if (a36 == 0)
            {
                button38.Background = Brushes.Red;
                a36 = 1; textBox7.Text = "b11";
            }
            else
            {
                button38.Background = Brushes.Chartreuse;
                a36 = 0; textBox7.Text = "";
            }
        }

        private void button39_Click(object sender, RoutedEventArgs e)
        {
            if (a37 == 0)
            {
                button39.Background = Brushes.Red;
                a37 = 1; textBox7.Text = "b12";
            }
            else
            {
                button39.Background = Brushes.Chartreuse;
                a37 = 0; textBox7.Text = "";
            }
        }

        private void button40_Click(object sender, RoutedEventArgs e)
        {
            if (a38 == 0)
            {
                button40.Background = Brushes.Red;
                a38 = 1; textBox7.Text = "a1";
            }
            else
            {
                button40.Background = Brushes.Chartreuse;
                a38 = 0; textBox7.Text = "";
            }
        }

        private void button41_Click(object sender, RoutedEventArgs e)
        {
            if (a39 == 0)
            {
                button41.Background = Brushes.Red;
                a39 = 1; textBox7.Text = "a2";
            }
            else
            {
                button41.Background = Brushes.Chartreuse;
                a39 = 0; textBox7.Text = "";
            }
        }

        private void button42_Click(object sender, RoutedEventArgs e)
        {
            if (a40 == 0)
            {
                button42.Background = Brushes.Red;
                a40 = 1; textBox7.Text = "a3";
            }
            else
            {
                button42.Background = Brushes.Chartreuse;
                a40 = 0; textBox7.Text = "";
            }
        }

        private void button43_Click(object sender, RoutedEventArgs e)
        {
            if (a41== 0)
            {
                button43.Background = Brushes.Red;
                a41 = 1; textBox7.Text = "a4";
            }
            else
            {
                button43.Background = Brushes.Chartreuse;
                a41 = 0; textBox7.Text = "";
            }
        }

        private void button44_Click(object sender, RoutedEventArgs e)
        {
            if (a42 == 0)
            {
                button44.Background = Brushes.Red;
                a42 = 1; textBox7.Text = "a5";
            }
            else
            {
                button44.Background = Brushes.Chartreuse;
                a42 = 0; textBox7.Text = "";
            }
        }

        private void button45_Click(object sender, RoutedEventArgs e)
        {
            if (a43 == 0)
            {
                button45.Background = Brushes.Red;
                a43 = 1; textBox7.Text = "a6";
            }
            else
            {
                button45.Background = Brushes.Chartreuse;
                a43 = 0; textBox7.Text = "";
            }
        }

        private void button46_Click(object sender, RoutedEventArgs e)
        {
            if (a44 == 0)
            {
                button46.Background = Brushes.Red;
                a44 = 1; textBox7.Text = "a7";
            }
            else
            {
                button46.Background = Brushes.Chartreuse;
                a44 = 0; textBox7.Text = "";
            }
        }

        private void button47_Click(object sender, RoutedEventArgs e)
        {
            if (a45== 0)
            {
                button47.Background = Brushes.Red;
                a45 = 1; textBox7.Text = "a8";
            }
            else
            {
                button47.Background = Brushes.Chartreuse;
                a45 = 0; textBox7.Text = "";
            }
        }

        private void button48_Click(object sender, RoutedEventArgs e)
        {
            if (a46 == 0)
            {
                button48.Background = Brushes.Red;
                a46 = 1; textBox7.Text = "a9";
            }
            else
            {
                button48.Background = Brushes.Chartreuse;
                a46 = 0; textBox7.Text = "";
            }
        }

        private void button49_Click(object sender, RoutedEventArgs e)
        {
            if (a47 == 0)
            {
                button49.Background = Brushes.Red;
                a47 = 1; textBox7.Text = "a10";
            }
            else
            {
                button49.Background = Brushes.Chartreuse;
                a47 = 0; textBox7.Text = "";
            }
        }

        private void button50_Click(object sender, RoutedEventArgs e)
        {
            if (a48 == 0)
            {
                button50.Background = Brushes.Red;
                a48 = 1; textBox7.Text = "a11";
            }
            else
            {
                button50.Background = Brushes.Chartreuse;
                a48 = 0; textBox7.Text = "";
            }
        }

        private void button51_Click(object sender, RoutedEventArgs e)
        {
            if (a49== 0)
            {
                button51.Background = Brushes.Red;
                a49 = 1; textBox7.Text = "a12";
            }
            else
            {
                button51.Background = Brushes.Chartreuse;
                a49 = 0; textBox7.Text = "";
            }
        }
        int ucret;
        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            if (radioButton1.IsChecked == true)
            {
                ucret = 10;
            }
        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {
            if (radioButton2.IsChecked == true)
            {
                ucret = 15;
            }
        } 
    }
}

