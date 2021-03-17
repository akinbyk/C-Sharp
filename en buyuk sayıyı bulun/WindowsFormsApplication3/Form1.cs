using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sayi3= Convert.ToInt32(textBox3.Text);

            textBox4.Text = buyukhesapla(sayi1, sayi2, sayi3).ToString();
        }
        static int buyukhesapla(int a, int b, int c)
        {
            int buyuk=0;
            
            if (a > b && a > c)
            {
                buyuk = a;
            }
            else if (b > a && b > c)
            {
                buyuk = b;
            }
            else if (c > a && c > b)
            {
                buyuk = c;
            }

            return buyuk;
        }

    }
}
