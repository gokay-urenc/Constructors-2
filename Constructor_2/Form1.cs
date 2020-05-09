using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci("Negan", "Lucille", 52);
            // ogr.ad = "xyz"; // Şuan istenirse değiştirme yapılabilir.
            // ogr.soyad = "zyx"; // Şuan istenirse değiştirme yapılabilir.
            // ogr.yas = 55; // Şuan istenirse değiştirme yapılabilir.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ogretmen ogt = new Ogretmen("Rick", "Grimes", 47);
            // ogr.ad = "xyz"; // Class'ta private set yapıldığı için tekrar atama yapılamaz.
            // ogr.soyad = "zyx"; // Class'ta private set yapıldığı için tekrar atama yapılamaz.
            // ogr.yas = 55; // Class'ta private set yapıldığı için tekrar atama yapılamaz.
        }
    }
}