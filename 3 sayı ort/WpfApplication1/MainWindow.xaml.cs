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
            int c = Int16.Parse(textBox1.Text);
            int s = Int16.Parse(textBox2.Text);
            int g = Int16.Parse(textBox3.Text);
            textBox4.Text = (ortahesap(c, s, g)).ToString();
        }
            double ortahesap(double c,double s,double g) 
            {
                double ort=(c+s+g)/3;
                return ort;
                
                
        }
    }
}
