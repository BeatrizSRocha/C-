using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesPré_CP
{
    internal class Caminhao : Veiculo
    {
        public Caminhao(string modelo) : base(modelo) { }
        public override void Acelerar()
        {
            Velocidade += 10;
            Console.WriteLine($"{Modelo} acelerou: +10 km/h");
        }
    }
}
