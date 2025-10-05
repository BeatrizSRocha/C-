using System;
using AtividadesCP;

namespace AtividadesCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro[] livros = new Livro[3];
            livros[0] = new Livro("Dom Casmurro", "Machado de Assis", 1899);
            livros[1] = new Livro("O Alquimista", "Paulo Coelho", 1988);
            livros[2] = new Livro("Capitães da Areia", "Jorge Amado", 1937);

            for (int i = 0; i < livros.Length; i++)
            {
                livros[i].ExibirInformacoes();
                Console.WriteLine();
            }
        }
    }
}