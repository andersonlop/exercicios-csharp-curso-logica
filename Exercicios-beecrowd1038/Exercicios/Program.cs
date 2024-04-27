using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double total, valor;

            String[] vet = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

            if (codigo == 1)
            {
                valor = 4.00;
            }else if (codigo == 2)
            {
                valor = 4.50;
            }  else if (codigo == 3)
            {
                valor = 5.00;
            } else if(codigo == 4)
            {
                valor = 2.00;
            }
            else
            {
                valor = 1.50;
            }

            total = valor * quantidade;
            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
