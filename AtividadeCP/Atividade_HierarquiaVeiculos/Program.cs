using AtividadeCP;
using System;

namespace AtividadeCP
{
    class Program
    {
        static void Main()
        {
            Veiculo[] veiculos = new Veiculo[]
            {
                new Carro("Sedan"),
                new Caminhao("Truck"),
                new Moto("Sport")
            };

            foreach (var veiculo in veiculos)
            {
                veiculo.Acelerar();
                Console.WriteLine(veiculo);
            }
        }
    }
}