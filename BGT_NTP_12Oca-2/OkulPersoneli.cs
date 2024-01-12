using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGT_NTP_12Oca_2
{
    public class OkulPersoneli
    {
        public string Ad {  get; set; } 
        public string Soyad { get; set; }
        public virtual void AdSoyadYazdir()
        {
            MessageBox.Show("NAME, SURNAME -> " + Ad + " " + Soyad);
        }
    }
}
