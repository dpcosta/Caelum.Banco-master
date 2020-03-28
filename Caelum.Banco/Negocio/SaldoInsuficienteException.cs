using System;

namespace Caelum.Banco.Negocio
{
    public class SaldoInsuficienteException : Exception
    {
        public double ValorSaque { get; }
        public double SaldoAtual { get; }

        public SaldoInsuficienteException(double saque, double saldo) : base("Saldo insuficiente em tentativa de saque!")
        {
            ValorSaque = saque;
            SaldoAtual = saldo;
        }
    }
}
