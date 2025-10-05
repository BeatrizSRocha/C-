using System;
using Atividades;

namespace Atividades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var conta = new ContaBancaria("Maria", 1000m);
            conta.Depositar(500m);
            bool saqueRealizado = conta.Sacar(200m);

            Console.WriteLine($"Titular: {conta.Titular}");
            Console.WriteLine($"Saldo atual: {conta.ConsultarSaldo():C}");
            Console.WriteLine($"Saque realizado: {(saqueRealizado ? "Sim" : "Não")}");
        }
    }
}