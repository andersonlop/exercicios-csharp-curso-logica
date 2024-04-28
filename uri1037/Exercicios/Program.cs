using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (A < 0.0 || A > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if(A <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if(A <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if(A <= 75.0)
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }

        }
    }
}
