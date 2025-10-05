using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesPré_CP
{
    internal class Moto : Veiculo
    {
        public Moto(string modelo) : base(modelo) { }
        public override void Acelerar()
        {
            Velocidade += 30;
            Console.WriteLine($"{Modelo} acelerou: +30 km/h");
        }
    }
}
