using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public class Hardware: Item
    {
        public int Teza { get; set; }

        public Hardware()
        {
            //nič
        }

        public Hardware( string im, int price, int tez) 
        {
            ItemName = im;
            Price = price;
            Teza = tez;
        }
        public new string ToString()
        {
            string podatki = ItemName +" "+ Price +" "+ Teza;
            return podatki;
        }
    }
}
