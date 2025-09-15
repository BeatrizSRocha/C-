using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array de int
            int[] listaNumeros = { 5, 6, 4, 13 };

            int[] numeros = { 0, 0, 0, 0 };

            for (int i = 0; i < listaSenha.Length; i++)
            {
                Console.Write("Digito " + (i + 1) + ": ");
                senhaNumeros[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < listaSenha.Length; i++)
            {
                if (senhaNumeros[i] != listaSenha[i])
                {
                    Console.WriteLine("Senha incorreta! Tente novamente :c");
                    break;
                }
                if (i == listaSenha.Length - 1)
                {
                    Console.WriteLine("Parabéns, você acertou!");
                    return;
                }
            }
        }
    }
}