using Herança;
using Herança;
using System;

namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo[] veiculos = new Veiculo[3];
            veiculos[0] = new Carro("hjk2324", "Santana", "Vinho", "AP2.0");
            veiculos[1] = new Moto("asd1234", "CB 300", "Preta", "300cc");
            veiculos[2] = new Moto("qwe5678", "Ninja 400", "Verde", "400cc");
            veiculos[3] = new Pickup("zxc9876", "Ranger", "Prata", "2.2 Diesel",1000);

            for (int i = 0; i < veiculos.Length; i++)
            {
                veiculos[i].LigarMotor();
                veiculos[i].AdicionarPessoas(2);
                Console.WriteLine(veiculos[i].VerificaPessoas());
            }
        }
    }
}