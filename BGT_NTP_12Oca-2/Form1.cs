using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGT_NTP_12Oca_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Her ogretmen okul personelidir.
            Ogretmen ogrt1= new Ogretmen();
            ogrt1.Ad = "Süleyman";
            ogrt1.Soyad = "Ezdemir";
            ogrt1.Brans = "Bilişim";
            ogrt1.AdSoyadYazdir();
            
            // Her okul personeli öğretmen değildir.
            OkulPersoneli pers = new OkulPersoneli();
            pers.Ad = "Ahmet";
            pers.Soyad = "Yılmaz";
            //pers.Brans = "Tarih";    -> HATA VERİR
            pers.AdSoyadYazdir();
        }
    }
}
