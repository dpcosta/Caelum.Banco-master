using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Caelum.Banco.Negocio;

namespace Caelum.Banco.Dados
{
    public class PersistenciaContas
    {
        string nomeArquivo = "contas.txt";

        public IList<Conta> CarregaContasDoArquivo()
        {
            var lista = new List<Conta>();
            if (File.Exists(nomeArquivo))
            {
                using (var conteudo = File.OpenRead(nomeArquivo))
                using (var leitor = new StreamReader(conteudo))
                {
                    string linha = leitor.ReadLine();
                    while (linha != null)
                    {
                        Conta conta = ConverteLinhaEmConta.Converte(linha);
                        lista.Add(conta);
                        linha = leitor.ReadLine();
                    }
                }
            }
            return lista;
        }

        public void SalvaContasNoArquivo(IEnumerable<Conta> contas)
        {
            using (var conteudo = File.OpenWrite(nomeArquivo))
            using (var escritor = new StreamWriter(conteudo))
            {
                foreach (var conta in contas)
                {
                    // if de uma linha só - operador ternário
                    var tipo = (conta is ContaCorrente) ? "CC" : "CP";
                    var linha = $"{conta.Numero};{conta.Titular.Nome};{conta.Saldo};{tipo}";
                    escritor.WriteLine(linha);
                }
            }
        }
    }
}
