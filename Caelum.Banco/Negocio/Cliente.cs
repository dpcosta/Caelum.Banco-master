using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.Banco.Negocio
{
    public class Cliente
    {
        public string Nome { get; }
        public string Endereco { get; set; }
        public string CPF { get; set; }

        public Cliente(string nome)
        {
            Nome = nome;
        }

    }
}
