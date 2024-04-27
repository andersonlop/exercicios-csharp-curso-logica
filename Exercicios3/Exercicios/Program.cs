using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x)
            {
                case 1
                :
                    dia = "Domingo";
                    break;
                case 2
                :
                    dia = "Segunda-Feira";
                    break;
                case 3
                :
                    dia = "Terça-Feira";
                    break;
                case 4
                :
                    dia = "Quarta-Feira";
                    break;
                case 5
                :
                    dia = "Quinta-Feira";
                    break;
                case 6
                :
                    dia = "Sexta-Feira";
                    break;
                case 7
                :
                    dia = "Sábado";
                    break;
                default:
                    dia = "Valor inválido.";
                    break;
            }
            Console.WriteLine("Dia da semana: " + dia);
            Console.ReadLine();
        }
    }
}
