using System;

namespace Loopingsforewhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // 'a' define a altura da pirâmide (número de linhas)
            int a = 10;

            for (int i = 0; i < a; i++)
            {

                // O número de espaços diminui à medida que o 'i' aumenta
                for (int j = 0; j < a - i - 1; j++)
                {
                    Console.Write(" "); // Imprime um espaço
                }

                // Com o os asteriscos no centro, o número deles aumenta conforme o 'i' cresce
                for (int k = 0; k < (2 * i + 1); k++)
                {
                    Console.Write("*");
                }

                // Após inserir todos os asteriscos, pula uma linha, formando o formato do triângulo
                Console.WriteLine();
            }
        }
    }
}
