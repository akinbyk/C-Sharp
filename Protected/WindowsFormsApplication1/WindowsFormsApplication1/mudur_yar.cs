using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class mudur_yar : personel
    {
        public mudur_yar(string ad, int ya, int kes)
            : base(ad, kes, ya)
        {
            this.adı = ad;
            this.yas = ya;
            this.kesinti = kes;
        }
            
    }
}
