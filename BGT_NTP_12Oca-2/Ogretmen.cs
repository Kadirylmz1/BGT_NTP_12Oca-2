using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGT_NTP_12Oca_2
{
    public class Ogretmen : OkulPersoneli
    {
        public string Brans {  get; set; }
        public override void AdSoyadYazdir()
        {
            MessageBox.Show("Ad, Soyad ->"+Ad +" "+Soyad);
        }
    }
}
