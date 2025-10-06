using AtividadeCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeCP
{
    internal class Caminhao : Veiculo
    {
        public Caminhao(string modelo) : base(modelo) { }
        public override void Acelerar()
        {
            Velocidade += 40;
            Console.WriteLine($"{Modelo} acelerou: +40 km/h");
        }
    }
}
