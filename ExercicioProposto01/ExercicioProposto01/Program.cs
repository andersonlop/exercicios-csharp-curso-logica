using System;
using System.Globalization;

namespace ExercicioProposto01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double[] a;
            
            n = int.Parse(Console.ReadLine());
            a = new double[n];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                a[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }
                        
            double maior = a[0];
            int posMaior = 0;

            // Encontra a posição que esta o valor maior
            for (int i = 0; i < n; i++)
            {
                if (a[i] > maior)
                {
                    maior = a[i];
                    posMaior = i;
                }
            }

            // Encontra o maior digitado
            for (int i = 1; i < n; i++)
            {
                if (a[i] > maior)
                {
                    maior = a[i];
                }
            }            

            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posMaior);

            Console.ReadLine();
        }
    }
}
