using System;

namespace CarApp
{
    class Program
    {
        /// <summary>
        /// Cria um array de 10 carros com propriedades diferentes e exibe seus detalhes.
        /// </summary>
        static void Main(string[] args)
        {
            // Array com 10 carros diferentes.
            Carro[] carList = new Carro[10];

            carList[0] = new Carro("Sedan", "ABC123", "Vermelho", "V6");
            carList[1] = new Carro("SUV", "XYZ789", "Azul", "Elétrico");
            carList[2] = new Carro("Sedan", "AAA1111", "Vermelho", "V6");
            carList[3] = new Carro("SUV", "BBB2222", "Azul", "Elétrico");
            carList[4] = new Carro("Conversível", "QRS654", "Amarelo", "V4");
            carList[5] = new Carro("Conversível", "EEE5555", "Amarelo", "V4");
            carList[6] = new Carro("Minivan", "WXY741", "Prata", "V6");
            carList[7] = new Carro("Coupe", "ZAB852", "Azul Escuro", "V8");
            carList[8] = new Carro("Esportivo", "CDE963", "Verde", "V12");
            carList[9] = new Carro("Minivan", "GGG7777", "Prata", "V6 Turbo");

            // Utilizando for para exibir os detalhes de cada carro.
            for (int i = 0; i < carList.Length; i++)
            {
                Console.WriteLine(
                    $"Detalhes do carro: Chassis: {carList[i].Chassis}, Placa: {carList[i].LicensePlate}, Cor: {carList[i].Cor}, Motor: {carList[i].Motor}");
            }
        }
    }
}