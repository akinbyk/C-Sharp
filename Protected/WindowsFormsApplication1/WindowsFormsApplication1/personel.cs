using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class personel
    {
        protected string adı;
        protected int yas;
        protected int kesinti;
        public personel(string ad, int ya, int kes)
        {
            this.adı = ad;
            this.yas = ya;
            this.kesinti = kes;
        }
        public int degerler()
        {
            if (yas > 30)
            {
                kesinti = kesinti - 10;
            }
            else
            {
                kesinti = kesinti + 10;
            }
            return kesinti;
        }
    }
}
    

	
    
    