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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c,delta,x1,x2;
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            c = Convert.ToInt16(textBox3.Text);
            
            delta = (b * b) - 4 * a * c;
            if (delta < 0)
            {
                textBox4.Text="Denklemin Reel Kökü Yoktur";
            }
            else if (delta == 0)
            {
                textBox4.Text = "Denklemin Tek Kökü Vardır";
                x1 = -b / 2 * a;
                textBox6.Text = x1.ToString();
            }
            else
            {
                textBox4.Text = "Denklemin İki Kökü Vardır";
                x1 = -b - Math.Sqrt(delta) / 2 * a;
                x2 = -b + Math.Sqrt(delta) / 2 * a;
                textBox4.Text = x1.ToString();
                textBox5.Text = x2.ToString();
            }

        }
    }
}
