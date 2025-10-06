using AtividadeCP;
using System;

namespace AtividadeCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro[] livros = new Livro[3];
            livros[0] = new Livro("Quem é Você, Alasca?", " John Green", 2005);
            livros[1] = new Livro("Harry Potter e o Prisioneiro de Azkaban ", " J. K. Rowling ", 1999);
            livros[2] = new Livro("Cidade de Papel", " John Green ", 2008);

            for (int i = 0; i < livros.Length; i++)
            {
                livros[i].ExibirInformacoes();
                Console.WriteLine();
            }
        }
    }
}