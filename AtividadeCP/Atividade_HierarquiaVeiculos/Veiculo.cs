using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeCP
{
    public abstract class Veiculo
    {
        public string Modelo { get; set; }
        public int Velocidade { get; protected set; }

        public Veiculo(string modelo)
        {
            Modelo = modelo;
            Velocidade = 0;
        }
        public abstract void Acelerar();
        public override string ToString()
        {
            return $"{GetType().Name} {Modelo} está a {Velocidade} km/h";
        }
    }
}
