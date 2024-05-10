using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public class Software: Item
    {
        public int Licencekay { get; set; }
        public int SizeMB { get; set; }
        public int Verzija { get; set; }

        public Software()
        {
            //nič
        }
        public Software(string im, int price, int licence, int mb, int verz)
        {
            ItemName = im;
            Price = price;
            Licencekay = licence;
            SizeMB = mb;
            Verzija = verz;
        }
        public new string ToString()
        {
            string podatki =  Licencekay +" "+ SizeMB +" "+ Verzija;
            return podatki;
        }

    }
}
