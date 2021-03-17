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
            string kullanıcıadı, sifre;
            kullanıcıadı = textBox1.Text;
            sifre = textBox2.Text;
            if (kullanıcıadı == "Looyvel" && sifre == "æ")
            {
                MessageBox.Show("Giriş Başarılı");
                Form3 fr3 = new Form3();
                fr3.Show();
                this.Hide();
            }
            else if (kullanıcıadı == "Looyvel" || sifre == "æ")
            {
                MessageBox.Show("KullanıcıAdı yada Şifre Yanlış");
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");

            }
        }
    }
}