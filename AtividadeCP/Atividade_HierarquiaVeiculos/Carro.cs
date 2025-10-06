using AtividadeCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCP
{
    public class Carro : Veiculo
    {
        public Carro(string modelo) : base(modelo) { }
        public override void Acelerar()
        {
            Velocidade += 30;
            Console.WriteLine($"{Modelo} acelerou: +30 km/h");
        }
    }
}
