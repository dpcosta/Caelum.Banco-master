using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // formatação
            // nome fixo do arquivo (nesse caso precisa estar fixo msm)
            // verificar se existe, se pode abrir, se existe conteúdo

            var nomeArquivo = "contas.txt";
            if (File.Exists(nomeArquivo))
            {
                // pra chamar o using a classe precisa implementar IDisposable
                using (Stream conteudo = new FileStream(nomeArquivo, FileMode.Open, FileAccess.Read)) 
                using (StreamReader leitor = new StreamReader(conteudo))
                {
                    string linha = leitor.ReadLine();
                    while (linha != null)
                    {
                        Console.WriteLine(linha);
                        linha = leitor.ReadLine();
                    }
                } // chama o método Dispose()

                //Stream conteudo = null;
                //StreamReader leitor = null;
                //try
                //{
                //    conteudo = new FileStream(nomeArquivo, FileMode.Open, FileAccess.Read);

                //    leitor = new StreamReader(conteudo);
                //    string linha = leitor.ReadLine();
                //    while (linha != null)
                //    {
                //        Console.WriteLine(linha);
                //        linha = leitor.ReadLine();
                //    }
                //}
                //finally
                //{
                //    if (leitor != null) leitor.Dispose();
                //    if (conteudo != null) conteudo.Dispose();
                //}
                
            }
            
        }
    }
}
