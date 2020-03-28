using System;

namespace Caelum.Banco.Negocio
{
    /// <summary>
    /// Representa uma conta bancária.
    /// </summary>
    public abstract class Conta
    {
        private static int totalContas;

        public Conta(string titular)
        {
            Titular = new Cliente(titular);
            Conta.totalContas++;
            Numero = Conta.totalContas;
        }

        public Conta(int numero, string titular)
        {
            Titular = new Cliente(titular);
            Conta.totalContas++; 
            Numero = numero;
        }

        public static int ProximoNumero => Conta.totalContas + 1;

        public int Numero { get; }
        public Cliente Titular { get; }
        public double Saldo { get; private set; }


        public virtual void Saca(double valor)
        {
            if (valor < 0) throw new ArgumentException("Saque com valor inválido (esperado: valor maior que zero)");
            if (Saldo < valor) throw new SaldoInsuficienteException(valor, Saldo);
            Saldo -= valor;
        }

        public virtual void Deposita(double valor)
        {
            if (valor < 0) throw new ArgumentException("Depósito com valor inválido (esperado: valor maior que zero)");
            Saldo += valor;
        }

        public virtual void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }

        public override string ToString()
        {
            return $"{this.Numero:000} - {this.Titular.Nome}";
        }
    }
}
