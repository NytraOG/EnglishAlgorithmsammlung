using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecToBin
{
    public class Converter
    {
        public int[] ConvertInteger(int integer)
        {
            var binärArray = new int[8];
            var zwischenspeicher = integer;

            for (var i = 7; i >= 0; i--)
            {
                binärArray[i] = zwischenspeicher % 2 == 0 ? 0 : 1;
                zwischenspeicher /= 2;
            }

            return binärArray;
        }
    }
}
