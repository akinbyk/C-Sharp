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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ay;
            ay = comboBox1.Text;
            Console.WriteLine(ay);

            switch (ay)
            {
                case "Ocak":
                    textBox1.Text = "Kış Mevsimindedir";
                    break;

                case "Şubat":
                    textBox1.Text = "Kış Mevsimidir";
                    break;

                case "Mart":
                    textBox1.Text = "İlkbahar Mevsimidir";
                    break;

                case "Nisan":
                    textBox1.Text = "İlkBahar Mevsimidir";
                    break;

                case "Mayıs":
                    textBox1.Text = "İlkbahar Mevsimidir";
                    break;

                case "Haziran":
                    textBox1.Text = "Yaz Mevsimidir";
                    break;

                case "Temmuz":
                    textBox1.Text = "Yaz Mevsimidir";
                    break;

                case "Ağustos":
                    textBox1.Text = "Yaz Mevsimidir";
                    break;

                case "Eylül":
                    textBox1.Text = "Sonbahar Mevsimidir";
                    break;

                case "Ekim":
                    textBox1.Text = "Sonbahar Mevsimidir";
                    break;

                case "Kasım":
                    textBox1.Text = "Sonbahar Mevsimidir";
                    break;

                case "Aralık":
                    textBox1.Text = "Kış Mevsimidir";
                    break;
            }
        }
    }
}