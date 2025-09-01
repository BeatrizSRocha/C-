using System;

namespace ConsoleApp1
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int i = 0;
        //    while (i < 10000) {
        //        Console.WriteLine("Alguma coisa que vai imprimir");
        //        i++;
        //    }
        //}
        static void Main(string[] args)
        { 
            // Inicialização da variável, condição de funcionamento, incremento
            for (int i = 0; i <= 9; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}