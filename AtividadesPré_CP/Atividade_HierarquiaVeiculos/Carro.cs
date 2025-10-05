using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesPré_CP
{
    public class Carro : Veiculo
    {
        public Carro(string modelo) : base(modelo) { }
        public override void Acelerar()
        {
            Velocidade += 20;
            Console.WriteLine($"{Modelo} acelerou: +20 km/h");
        }
    }
}
