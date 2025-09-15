using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array de int
            int[] listaNumeros = { 5, 6, 4, 46, 32, 13 };

            int numero = 0;

            while (true)
            {
                Console.WriteLine("Tente descobrir o número ");

                numero = int.Parse(Console.ReadLine());

                for (int i = 0; i < listaNumeros.Length; i++)
                {
                    if (numero == listaNumeros[i])
                    {
                        Console.WriteLine("Certo");
                        if (i >= listaNumeros.Length -1)
                        {
                            return;
                        }
                        numero = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Errado");
                        break;
                    }
                }
                Console.WriteLine("Terminado");
            }
        }
    }
}