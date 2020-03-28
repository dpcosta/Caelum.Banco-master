using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.Banco.Negocio
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(string titular) : base(titular)
        {
        }

        public ContaPoupanca(int numero, string titular) : base(numero, titular)
        {
        }

        public override void Saca(double valor)
        {
            base.Saca(valor + 0.1);
        }
    }
}
