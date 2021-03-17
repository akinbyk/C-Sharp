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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string deger;
            deger = textBox1.Text;

            switch (deger)
            {
                case "A":
                    textBox2.Text="Ali";
                 
                    break;

                case "S":
                    textBox2.Text="Sıla";
                    break;

                case "K":
                    textBox2.Text="Kazım";
                    break;

                case "V":
                     textBox2.Text="Veli";
                    break;

                case "T":
                     textBox2.Text="Thomas";
                    break;

                default:
                    textBox2.Text=("Girdiğiniz Harf Harf Değildir");
                    break;




            }
            textBox2.Text= textBox3.Text + "\r\n" + textBox3.Text;
        }
    }
}