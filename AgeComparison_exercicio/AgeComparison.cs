namespace MyApp
{
    internal class AgeComparison
    {
        static void Main(string[] args)
        {
            int age1, age2;

            Console.WriteLine("Insira a idade do primeiro aluno: ");
            age1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a idade do segundo aluno: ");
            age2 = int.Parse(Console.ReadLine());

            if (age1 > age2)
            {
                Console.WriteLine("O primeiro aluno é o mais velho.");
                Console.WriteLine("O segundo aluno é o mais novo.");
            }
            if (age2 > age1)
            {
                Console.WriteLine("O segundo aluno é o mais velho.");
                Console.WriteLine("O primeiro aluno é o mais novo.");
            }
            else
            {
                Console.WriteLine("Ambos os alunos têm a mesma idade.");
            }
        }
    }
}