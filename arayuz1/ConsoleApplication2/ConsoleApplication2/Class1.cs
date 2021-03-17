using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class roman : Ikitap
    {
        private string Ad;
        private string Yazar_ad;
        private int Sayfa_sayisi=560;
        private int Fiyat;
        public string ad
        {
            get { return Ad; }
            set { Ad = value; }
        }
        public string yazar_ad
        {
            get { return Yazar_ad; }
            set { Yazar_ad = value; }
        }
        public int sayfa_sayisi
        {
            get { return Sayfa_sayisi; }
        }
        public int fiyat
        {
            set { Fiyat = value; }
        }
    }
}
