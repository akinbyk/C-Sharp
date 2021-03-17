using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kilo, boy, yas;
            string ad,cinsiyet,ehliyet,meslek;
            bool sonuc;
            ad=textBox1.Text;
            kilo=Convert.ToInt32(textBox3.Text);
            boy=Convert.ToInt32(textBox4.Text);
            yas=Convert.ToInt32(textBox2.Text);

            if (radioButton1.Checked)
            {
                cinsiyet = radioButton1.Text;
            }
            else
            {
                cinsiyet = radioButton2.Text;
            }
            meslek = comboBox1.SelectedItem.ToString();
            ehliyet = comboBox2.SelectedItem.ToString();
            sonuc = (yas > 25 && yas < 30) && (kilo < 80 || boy > 170) && (cinsiyet == "boy" || ehliyet == "B" && (meslek == "Mühendis" || meslek == "Asker"));
            

            textBox5.Text=sonuc.ToString();
            if(sonuc)
            {
                textBox5.Text="Başvurunuz Uygun";
            }
            else
            {
                textBox5.Text="Başvurunuz Olumsuz";
            }
        
        
        
        }
    }
}
