namespace MyApp
{
    internal class AreaCalculator
    {
        static void Main(string[] args)
        {
            // Pedindo o nome do usuário
            Console.WriteLine("Insira o seu nome:");
            string nome = Console.ReadLine();

            // Escolha da área a ser calculada
            Console.WriteLine($"Olá, {nome}! Você gostaria de saber qual área? (1 - Círculo, 2 - Triângulo, 3 - Retângulo)");
            string escolhaStr = Console.ReadLine()?.Trim();
            int escolha;
            int.TryParse(escolhaStr, out escolha);

            double area = 0;

            // Pedindo valor do raio do círculo
            if (escolha == 1)
            {
                Console.WriteLine("Insira o raio do círculo:");
                double raio = double.Parse(Console.ReadLine());
                area = AreaDoCirculo(raio);
                Print("Área do círculo: ", area);
            }

            // Pedindo valores da base e altura do triângulo
            if (escolha == 2)
            {
                Console.WriteLine("Insira o valor da base do triângulo:");
                double baseTri = double.Parse(Console.ReadLine());
                Console.WriteLine("Insira o valor da altura do triângulo:");
                double alturaTri = double.Parse(Console.ReadLine());
                area = AreaDoTriangulo(baseTri, alturaTri);
                Print("Área do triângulo: ", area);
            }

            // Pedindo valores do comprimento e largura do retângulo
            if (escolha == 3)
            {
                Console.WriteLine("Insira o comprimento do retângulo:");
                double comprimento = double.Parse(Console.ReadLine());
                Console.WriteLine("Insira a largura do retângulo:");
                double largura = double.Parse(Console.ReadLine());
                area = AreaDoRetangulo(comprimento, largura);
                Print("Área do retângulo: ", area);
            }

            // Se o usuário não escolher uma das opções anteriores, o programa informa que a opção é inválida
            else
            {
                Print("Opção inválida.");
            }
        }

        // Cálculo da área do círculo
        static double AreaDoCirculo(double raio)
        {
            return Math.PI * Math.Pow(raio, 2);
        }

        // Cálculo da área do triângulo
        static double AreaDoTriangulo(double baseTri, double alturaTri)
        {
            return (baseTri * alturaTri) / 2;
        }

        // Cálculo da área do retângulo
        static double AreaDoRetangulo(double comprimento, double largura)
        {
            return comprimento * largura;
        }

        // Prints para diferentes dados colocados
        static void Print(double valor)
        {
            Console.WriteLine(valor);
        }
        static void Print(string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        // Print da mensagem com o valor calculado
        static void Print(string mensagem, double valor)
        {
            Console.WriteLine($"{mensagem}{valor}");
        }
    }
}