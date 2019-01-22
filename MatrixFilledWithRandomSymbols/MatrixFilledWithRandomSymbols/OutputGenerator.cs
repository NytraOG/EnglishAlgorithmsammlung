using System;

namespace MatrixFilledWithRandomSymbols
{
    public class OutputGenerator
    {
        public void MatrixVisualisieren(string[,] symbolMatrix)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(" ");
                Console.WriteLine(new string('_', 79));
                Console.WriteLine($"|\t\t|\t\t|\t\t|\t\t|\t\t|\n|\t{symbolMatrix[i, 0]}\t|\t{symbolMatrix[i, 1]}\t|\t{symbolMatrix[i, 2]}\t|\t{symbolMatrix[i, 3]}\t|\t{symbolMatrix[i, 4]}\t|\n|_______________|_______________|_______________|_______________|_______________|");
            }
        }
    }
}
