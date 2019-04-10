using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DecToBin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zum konvertieren eine ganze Zahl im Bereich [0 - 255] eingeben und bestätigen.");

            do
            {
                var converter = new Converter();
                var outputter = new OutputGenerator();

                var binärArray  = converter.ConvertInteger(Convert.ToInt32(Console.ReadLine()));
                var binärOutput = "Deine eingegebene Zahl entspricht dieser binären Form : " + outputter.GenerateString(binärArray);

                Console.WriteLine(binärOutput);

            } while (true);
        }
    }
}
