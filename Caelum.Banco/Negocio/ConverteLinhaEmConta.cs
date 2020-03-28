using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.Banco.Negocio
{
    public class ConverteLinhaEmConta
    {
        public static Conta Converte(string linha)
        {
            string[] partes = linha.Split(';');

            var numero = partes[0];
            var titular = partes[1];
            var saldo = partes[2];
            var tipo = partes[3];

            Conta conta;
            if (tipo == "CC")
                conta = new ContaCorrente(Convert.ToInt32(numero), titular);
            else
                conta = new ContaPoupanca(Convert.ToInt32(numero), titular);

            conta.Deposita(Convert.ToDouble(saldo));

            return conta;
        }
    }
}
