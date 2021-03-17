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
            int sayi1 = Convert.ToInt16(textBox1.Text);
            int sayi2 = Convert.ToInt16(textBox2.Text);
            textBox4.Text = ortalamahesap(sayi1, sayi2).ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt16(textBox1.Text);
            int sayi2 = Convert.ToInt16(textBox2.Text);
            int sayi3 = Convert.ToInt16(textBox3.Text);
            textBox4.Text = ortalamahesap(sayi1, sayi2,sayi3).ToString();
            
        }
        double ortalamahesap(double o1,double o2)
        {
            return (o1+o2)/2;
        }
        double ortalamahesap(double o1, double o2, double o3)
        {
            return (o1 + o2 + o3) / 3;
        }

        
        

    
    }
}
