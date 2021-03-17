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
            int[] deger = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                deger[i] = rnd.Next(100);
                listBox1.Items.Add(deger[i].ToString());
            }
        }
    }
}
