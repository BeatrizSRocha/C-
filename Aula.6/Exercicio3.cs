using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array de números
            int[] listaNumeros = { 5, 6, 4, 13 };

            Console.WriteLine("Digite 4 números separados por espaço:");
            string[] entrada = Console.ReadLine().Split(' ');

            // Verifica se o usuário digitou 4 números

            if (entrada.Length != listaNumeros.Length)
            {
                Console.WriteLine("Você deve digitar exatamente 4 números");
                return;
            }
        }
    }
}
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array de números
            int[] listaNumeros = { 5, 6, 4, 13 };

            Console.WriteLine("Digite 4 números separados por espaço:");
            string[] entrada = Console.ReadLine().Split(' ');

            // Verifica se o usuário digitou 4 números
            if (entrada.Length != listaNumeros.Length)
            {
                Console.WriteLine("Você deve digitar exatamente 4 números");
                return;
            }

            int[] numerosColocados = new int[listaNumeros.Length];
            for (int i = 0; i < listaNumeros.Length; i++)
            {
                if (!int.TryParse(entrada[i], out numerosColocados[i]))
                {
                    Console.WriteLine($"Valor inválido: "{entrada[i]});
                    return;
                }
            }

            Console.WriteLine("Números digitados:");
            foreach (var numero in numerosColocados)
            {
                Console.WriteLine(numero);
            }
        }
    }
}