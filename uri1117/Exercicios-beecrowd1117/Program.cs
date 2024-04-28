using System;
using System.Globalization;

namespace Exercicios_beecrowd1117
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1, N2 , MEDIA;

            N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (N1 < 0.0 || N1 > 10.0)
            {
                Console.WriteLine("nota invalida");
                N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (N2 < 0.0 || N2 > 10.0)
            {
                Console.WriteLine("nota invalida");
                N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            MEDIA = (N1 + N2) / 2.0;
            Console.WriteLine("media = " + MEDIA.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
