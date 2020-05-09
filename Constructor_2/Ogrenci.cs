using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_2
{
    public class Ogrenci
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public int yas { get; set; }
        public Ogrenci(string name, string surname, int age)
        {
            ad = name;
            soyad = surname;
            yas = age;
        }
    }
}