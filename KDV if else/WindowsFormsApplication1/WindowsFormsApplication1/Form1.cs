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
            double hacim, kdvsiz, kdvli;
            hacim = Convert.ToDouble(textBox1.Text);
            kdvsiz = Convert.ToDouble(textBox2.Text);

            if (hacim < 1000)
            {
                kdvli = kdvsiz * 8 / 100 + kdvsiz;
                textBox3.Text = kdvsiz.ToString();
            }
            else if (hacim > 1000 && hacim < 1299)
            {
                kdvli = kdvsiz * 10 / 100 + kdvsiz;
                textBox3.Text = kdvli.ToString();
            }
            else
            {

                kdvli=kdvsiz*14/100+kdvsiz;
                textBox3.Text = kdvli.ToString();

            }
            
        }
    }
}
