using System;
using System.Linq;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array de números
            int[] listaNumeros = { 5, 6, 4, 13 };
            int[] numeros = new int[4];

            Console.WriteLine("Digite 4 números separados por espaço:");
            string[] entrada = Console.ReadLine().Split(' ');

            if (entrada.Length != listaNumeros.Length)
            {
                Console.WriteLine("Você deve digitar exatamente 4 números.");
                return;
            }
            for (int i = 0; i < entrada.Length; i++)
            {
                if (int.TryParse(entrada[i], out int numero))
                {
                    numeros[i] = numero;
                }
                else
                {
                    Console.WriteLine($"'{entrada[i]}' não é um número válido.");
                    return;
                }
            }
            if (numeros.SequenceEqual(listaNumeros))
            {
                Console.WriteLine("Acertou!");
            }
            else
            {
                Console.WriteLine("Errou");
            }
        }
    }
}