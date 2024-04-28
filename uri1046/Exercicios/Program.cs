using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vet = Console.ReadLine().Split(' ');
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);

            int duracao;

            if (A < B)
            {
                duracao = B - A;
            }
            else
            {
                duracao = 24 - A + B;
            }
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

        }
    }
}
