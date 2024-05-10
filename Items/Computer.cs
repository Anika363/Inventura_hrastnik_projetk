using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public class Computer: Hardware
    {
        public int Noofcores { get; set; }
        public int Amountofram { get; set; }
        public int Hddsize { get; set; }

        public Computer()
        {
            //nič
        }
        public Computer( string im, int price, int tez, int core, int ram, int hdd)
        {
            ItemName = im;
            Price = price;
            Teza = tez;
            Noofcores = core;
            Amountofram = ram;
            Hddsize = hdd;
        }
    }
}
