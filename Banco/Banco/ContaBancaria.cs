using System.Globalization;

namespace Banco
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            //não precisa do saldo pois ele ja inicia com zero
        }
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5.0;
        }




















        public override string ToString()
        {
            return $"Conta\n" +
                $"{Numero}\n" +
                $"Titular: {Titular}\n" +
                $"Saldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}\n";
        }


    }
}
