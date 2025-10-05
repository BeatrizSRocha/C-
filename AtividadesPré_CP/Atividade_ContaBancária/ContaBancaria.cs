namespace Atividades
{
    public class ContaBancaria
    {
        public string Titular { get; private set; }
        public decimal Saldo { get; private set; }
        public ContaBancaria(string titular, decimal saldoInicial = 0)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentException("O valor do depósito deve ser positivo.");
            Saldo += valor;
        }

        public bool Sacar(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentException("O valor do saque deve ser positivo.");
            if (valor > Saldo)
                return false;
            Saldo -= valor;
            return true;
        }

        public decimal ConsultarSaldo()
        {
            return Saldo;
        }
    }
}