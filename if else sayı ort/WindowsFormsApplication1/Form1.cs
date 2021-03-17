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
            int y1, y2, s, ortalama, not;
            y1 = Convert.ToInt32(textBox1.Text);
            y2 = Convert.ToInt32(textBox2.Text);
            s = Convert.ToInt32(textBox3.Text);
            ortalama = (y1 + y2 + s) / 3;
            label5.Text = Convert.ToString(ortalama);

            if (ortalama >= 0 && ortalama <= 24)
                not = 0;
            else if (ortalama >= 25 && ortalama <= 44)
                not = 1;
            else if (ortalama >= 45 && ortalama <= 54)
                not = 2;
            else if (ortalama >= 55 && ortalama <= 69)
                not = 3;
            else if (ortalama >= 70 && ortalama <= 84)
                not = 4;
            else
                not = 5;
            label7.Text = not.ToString();


        }
    }
}
