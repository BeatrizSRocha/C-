using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    internal class Moto : Veiculo
    {
        string modelo;
        public Moto(string placa, string modelo, string cor, string motor)
        {
            capacidadePessoas = 2;
            this.placa = placa;
            this.modelo = modelo;
            this.cor = cor;
            this.motor = motor;
            Random random = new Random();
            chassi = random.Next().ToString("000000000000");
        }
        string override string VerificaPessoas()
        {
            return "existem" + this.pessoas + "na" + "moto" + "contando com o Motociclista";
        }
    }
}
