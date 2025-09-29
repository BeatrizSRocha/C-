using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    abstract class Veiculo
    {
        protected string placa;
        protected string chassi;
        protected string cor;
        protected int pessoas;
        protected string motor;

        bool motorLigado;
        protected int capacidadePessoas;
        protected float estadodoTanque;

        public void LigarMotor()
        {
            motorLigado = true;
        }
        public void DesligarMotor()
        {
            motorLigado = false;
        }
        public int EstadoTanque()
        {
            // retorno em porcentagem (%)
            return (int)(estadodoTanque * 100);
        }
        public bool AdicionarPessoas(int pessoas)
        {
            if (pessoas > capacidadePessoas)
            {
                Console.WriteLine("Lotado!");
            }
            this.pessoas += capacidadePessoas;
        }
        public virtual string VerificaPessoas()
        {
            return "existem" + this.pessoas + "no" + this.GetType().Name + "contando com o Motorista";
        }
    }
}
