using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            var twister = new StringTwister();

            Console.WriteLine("Beliebigen Text eingeben:\n");
            Console.WriteLine(twister.TwistString(Console.ReadLine()));
        }
    }
}
