using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            turkce_karakter_cevır(textBox1.Text);
        }
        private void turkce_karakter_cevır(string metin)
        {
            metin = metin.Replace('Ğ','G');
            metin = metin.Replace('i','ı');
            metin = metin.Replace('ş','s');
            metin = metin.Replace('ö', 'o');
            metin = metin.Replace('I', 'i');
            metin = metin.Replace('ğ', 'g');
            metin = metin.Replace('ü', 'u');
            metin = metin.Replace('Ö', 'O');
            metin = metin.Replace('ç', 'c');
            metin = metin.Replace('Ç', 'C');
            textBox2.Text = metin;
            MessageBox.Show("Çevdildi");
            

        }
    }
}
