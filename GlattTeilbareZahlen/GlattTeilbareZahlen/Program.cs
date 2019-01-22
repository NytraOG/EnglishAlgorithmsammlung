using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlattTeilbareZahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            var teilbarChecker = new TeilbarChecker();

            Console.WriteLine("Überprüfung der glatten Teilbarkeit zweier Zahlen in eine ganze Zahl. \n\nQuotient(integer) eingeben:");
            var quotient = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Divisor(integer) eingeben:");
            int divisor = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(teilbarChecker.CheckTeilbarkeit(quotient, divisor)
                ? $"\n{quotient}/{divisor} ist glatt teilbar. \nErgebnis: {quotient / divisor}\n"
                : $"\n{quotient}/{divisor} ist nicht ohne Rest teilbar.\n");
        }
    }
}
