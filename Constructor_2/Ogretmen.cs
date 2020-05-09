using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_2
{
    public class Ogretmen
    {
        public string ad { get; private set; } // Private set yaparak atama işleminin sadece class                                        içinde yapılabileceğini belirtmiş olduk. Yani                                           sonradan değiştirme işlemleri engellendi.
        public string soyad { get; private set; }
        public int yas { get; private set; }
        public Ogretmen(string ad, string soyad, int yas)
        {
            this.ad = ad; // this burada Ogretmen class'ini ifade eder. this.ad property iken ='in               sağında kalan ad parametredir.
            this.soyad = soyad;
            this.yas = yas;
        }
     }
}