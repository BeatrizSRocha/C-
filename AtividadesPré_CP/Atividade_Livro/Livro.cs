namespace AtividadesCP
{
    public class Livro
    {
        string titulo;
        string autor;
        int anoPublicacao;

        public Livro(string titulo, string autor, int anoPublicacao)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anoPublicacao = anoPublicacao;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Ano de Publicação: {anoPublicacao}");
        }
    }
}