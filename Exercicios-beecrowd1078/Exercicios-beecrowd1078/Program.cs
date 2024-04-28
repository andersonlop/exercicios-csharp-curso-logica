using System;

namespace Exercicios_beecrowd1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int r = i * n;
                Console.WriteLine(i + " x " + n + " = " + r);                
            }
            Console.ReadLine();
        }
    }
}
