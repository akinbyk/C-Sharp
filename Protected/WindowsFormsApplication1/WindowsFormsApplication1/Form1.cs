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
            personel pr1 =new personel(textBox1.Text,Convert.ToInt32(textBox2.Text),Convert.ToInt32(textBox3.Text));
            textBox4.Text=pr1.degerler().ToString();
        }
    }
}
