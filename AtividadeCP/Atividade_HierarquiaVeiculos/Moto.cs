using AtividadeCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeCP
{
    internal class Moto : Veiculo
    {
        public Moto(string modelo) : base(modelo) { }
        public override void Acelerar()
        {
            Velocidade += 15;
            Console.WriteLine($"{Modelo} acelerou: +15 km/h");
        }
    }
}
