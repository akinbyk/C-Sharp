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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        interface Iotobüs
        {
            string yakıt_tipi { get; set; }
            int yolcu_sayısı { get; set; }
            string marka { get; set; }
            void otobusbilgileri(string yakıt, int yolcu, string marka);
            string bilgilerigoster();
        }
        class sehirici : Iotobüs
        {
            private string Yakıt;
            private int Yolcu;
            private string Marka;
            public string yakıt_tipi
            {
                get
                {
                    return Yakıt;
                }
                set
                {
                    Yakıt = value;
                }
            }

            public int  yolcu_sayısı
            {
	           get 
	           { 
		          return Yolcu;
	           }
	           set 
	           { 
		          Yolcu = value; 
	           }
           }

            public string  marka
             {
	            get 
	            { 
		           return Marka;
	            }
	            set 
	            { 
		           Marka = value;
	            }
            }

            public void  otobusbilgileri(string yakıt, int yolcu, string marka)
            {
                this.Yakıt = yakıt;
                this.Yolcu = yolcu;
                this.Marka = marka;
            }

             public string  bilgilerigoster()
             {
 	              return " Yakıt :" + Yakıt + " Yolcu SAyısı :" + Yolcu + " Marka : " + Marka;
             }
           }
        class sehirlerarası : sehirici
        {
        }
        sehirici sehir = new sehirici();
        sehirlerarası sehirara = new sehirlerarası();

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            sehir.yakıt_tipi = textBox1.Text;
            sehir.yolcu_sayısı = Convert.ToInt32(textBox2.Text);
            sehir.marka = textBox3.Text;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }





       
    }
}
