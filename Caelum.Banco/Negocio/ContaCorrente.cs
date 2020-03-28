namespace Caelum.Banco.Negocio
{
    public class ContaCorrente : Conta, ITributavel
    {
        public ContaCorrente(string titular) : base(titular)
        {
        }

        public ContaCorrente(int numero, string titular) : base(numero, titular)
        {
        }

        public double CalculaTributos()
        {
            return Saldo * 0.05;
        }
    }
}
