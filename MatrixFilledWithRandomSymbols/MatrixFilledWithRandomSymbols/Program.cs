namespace MatrixFilledWithRandomSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var zeichenermittlung = new Zeichenermittlung();
            var outputter = new OutputGenerator();

            var symbolMatrix = zeichenermittlung.SymboleErmitteln();

            outputter.MatrixVisualisieren(symbolMatrix);
        }
    }
}
