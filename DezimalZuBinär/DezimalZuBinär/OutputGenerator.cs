using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecToBin
{
    public class OutputGenerator
    {
        public string GenerateString(int[] binArray)
        {
            string outputString = null;

            foreach (var number in binArray)
            {
                outputString += number + " ";
            }

            return outputString;
        }
    }
}
