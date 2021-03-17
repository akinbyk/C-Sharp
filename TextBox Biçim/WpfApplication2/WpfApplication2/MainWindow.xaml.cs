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

namespace WpfApplication2
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            textBox1.FontSize = 10;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            textBox1.FontSize = 20;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            textBox1.FontSize = 30;
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            textBox1.Foreground = Brushes.Red;
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            textBox1.Foreground = Brushes.Yellow;
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            textBox1.Foreground = Brushes.Blue;
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            textBox1.Background = Brushes.Blue;
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            textBox1.Background = Brushes.Yellow;
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            textBox1.Background = Brushes.Aqua;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = " ";
        }
    }
}
