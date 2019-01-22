using System;

namespace MatrixFilledWithRandomSymbols
{
    public class Zeichenermittlung
    {
        public string[,] SymboleErmitteln()
        {
            Random rng = new Random();

            string[] symbole = { "Zehn", "Bube", "Dame", "König", "Ass", "Statue", "Käfer", "Pharaoh", "NYT", "Buch" };

            string[,] ausgewürfelteSymbole = new string[3, 5];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    ausgewürfelteSymbole[i, j] = symbole[rng.Next(0, 10)];
                }
            }

            return ausgewürfelteSymbole;
        }
    }
}
