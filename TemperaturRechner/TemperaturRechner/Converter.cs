using System;

namespace TemperaturRechner
{
    public class Converter
    {
        public string ConvertTemperature(string inputTemp)
        {
            var einheit = inputTemp.Substring(inputTemp.Length - 1).ToLower();
            var eingangsTemperatur = Convert.ToInt32(inputTemp.Remove(inputTemp.Length - 1));

            switch (einheit)
            {
                case "f":
                    return $"Die eingegebene Temperatur entspricht {(eingangsTemperatur - 32) * 5 / 9}°C\n";
                case "c":
                    return $"Die eingegebene Temperatur entspricht {eingangsTemperatur * 9 / 5 + 32}°F\n";
                default:
                    throw new Exception("Es sind nur Celsius(C) und Fahrenheit(F) erlaubt!!!!!!!");
            }
        }
    }
}
