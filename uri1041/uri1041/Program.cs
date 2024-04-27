using System;
using System.Globalization;

namespace uri1041
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            double x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double y = double.Parse(vet[1], CultureInfo.InvariantCulture);

            if(x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if(y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
