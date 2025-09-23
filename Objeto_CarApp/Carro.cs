using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    /// <summary>
    /// Class que representa um carro com propriedades básicas.
    /// </summary>
    public class Carro
    {
        /// <summary>
        /// Tipo de chassi do carro (ex: sedan, SUV, hatchback).
        /// </summary>
        public string Chassis { get; set; }

        /// <summary>
        /// Número da placa do carro.
        /// </summary>
        public string LicensePlate { get; set; }

        /// <summary>
        /// Cor do carro.
        /// </summary>
        public string Cor { get; set; }

        /// <summary>
        /// Tipo de motor do carro.
        /// </summary>
        public string Motor { get; set; }

        /// <summary>
        /// Construtor que inicializa todas as propriedades do carro.
        /// </summary>
        public Carro(string chassis, string licensePlate, string cor, string motor)
        {
            Chassis = chassis;
            LicensePlate = licensePlate;
            Cor = cor;
            Motor = motor;
        }
    }
}