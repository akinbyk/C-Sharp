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
            try
            {
                nakliye nak1 = new nakliye();
                nak1.yük_gir(int.Parse(textBox1.Text));
                nak1.yol_gir(int.Parse(textBox2.Text));
                nak1.fiyat_gir(int.Parse(textBox3.Text));
                textBox4.Text = nak1.ucret_hesapla().ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
        class nakliye
        {
            private int yük;
            private int yol;
            private int fiyat;
            public void fiyat_gir(int fiyats)
            {
                this.fiyat = fiyats;
            }
            public void yük_gir(int yüks)
            {
                this.yük = yüks_kontrol(yüks);
            }
            private int yüks_kontrol(int yüg)
            {
                if (yüg < 0 || yüg > 25)
                    throw new Exception(" Yük Sınırı Aşıldı..\n Max: 25 TON");
                return yüg;
            }
            public void yol_gir(int yols)
            {
                this.yol = yol_kontrol(yols);
            }
            private int yol_kontrol(int yol1)
            {
                if (yol1 < 100 || yol1 > 2500)
                    throw new Exception("Gidilecek Yol Sınırı Aşıldı..\n Min:100 Km -- Max: 2500 Km");
                return yol1;
            }
            public int ucret_hesapla()
            {
                return yük * yol * fiyat;
            }
        }
    }
}

	
