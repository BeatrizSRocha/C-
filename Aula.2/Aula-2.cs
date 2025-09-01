namespace MyApp; { internal class Program
{
    static void Main(string[] args)
    {
        int n1, n2; int r;

        Console.WriteLine("Insira o valor de n1: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Insira o valor de n2: ");
        n2 = int.Parse(Console.ReadLine());

        r = n1 + n2;

    if (r == 0)
        {
            Console.WriteLine("O resultado é zero.");
        }
        if (r > 0)
        {
            Console.WriteLine("O valor é maior que zero");
        }
        else
        {
            Console.WriteLine("O valor é menor que zero.");
        }
    }
}
