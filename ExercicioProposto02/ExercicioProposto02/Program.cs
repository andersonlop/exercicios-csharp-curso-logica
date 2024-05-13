using System;

namespace ExercicioProposto02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int[] a;

            numero = int.Parse(Console.ReadLine());
            a = new int[numero];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < numero; i++)
            {
                a[i] = int.Parse(s[i]);
            }

            for (int i = 0; i < numero; i++)
            {
                if (a[i] % 2 == 0 )
                {
                    Console.WriteLine(a[i]);
                }
            }

            int soma = 0;

            for (int i = 0; i < numero; i++)
            {
                if (a[i] % 2 == 0)
                {
                    soma++;
                }
            }

            Console.WriteLine(soma);

            Console.ReadLine();

        }
    }
}
