using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturRechner
{
    class Program
    {
        static void Main(string[] args)
        {
            var temperaturRechner = new Converter();

            Console.WriteLine("Geben Sie eine Temperatur mit passendem Einheitenkürzel(Celsius und Fharenheit erlaubt) an.\n \nBeispiel:\t28C \n\t\tfür 28 grad Celsius");

            Console.WriteLine(temperaturRechner.ConvertTemperature(Console.ReadLine()));
        }
    }
}
