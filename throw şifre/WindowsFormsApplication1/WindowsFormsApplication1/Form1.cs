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
            try
            {
                if (textBox1.Text=="")throw new Exception("Kullanıcı Giriniz");
                if (textBox1.Text !="æ")throw new Exception("Kullanıcı Doğru");
                try
                {
                    if (textBox2.Text=="")throw new Exception("Şifre Giriniz");
                    if (textBox2.Text!="×")throw new Exception("Şifre DOğru");
                    MessageBox.Show("Kabul Edildi ");
                }
                catch(Exception ihata)
                {
                    MessageBox.Show(ihata.Message);
                }
                }
                catch (Exception dhata)
                {
                    MessageBox.Show(dhata.Message);
                }
            }

        }
    }

