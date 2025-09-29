using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    internal class Pickup : Veiculo
    {
        float cargaMaxima;
        public Pickup(string placa, string modelo, string cor, string motor, float cargaMaxima) : base(placa, modelo, cor, motor)
        {
            this.cargaMaxima = cargaMaxima;
        }
    }
}
