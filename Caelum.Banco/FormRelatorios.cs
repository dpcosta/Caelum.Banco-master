using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caelum.Banco.Negocio;

namespace Caelum.Banco
{
    public partial class FormRelatorios : Form
    {
        IEnumerable<Conta> contas;

        public FormRelatorios(IEnumerable<Conta> contas)
        {
            InitializeComponent();
            this.contas = contas;
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            /*
             Tipos de operações:
             - filtro >> subconjunto
             - ordenação >> classificar
             - projeção >> transformar um elemento de um tipo para outro
             - agregação >> transforma a coleção em um elemento único a partir de uma função (soma, contar, mínimo, etc.)
             */

            listBoxContas.Items.Clear();
            var resultado = this.contas
                .Where(c => c.Saldo > 5000) // filtro
                .OrderBy(c => c.Titular.Nome); // ordenação
            
            listBoxContas.Items.AddRange(resultado.ToArray());
            
            //agregação:
            lblSaldoTotal.Text = resultado.Sum(c => c.Saldo).ToString("0,0.00");
            lblMaiorSaldo.Text = resultado.Max(c => c.Saldo).ToString("0,0.00");

            // projeção da lista de contas >> lista de double (saldo)
            var saldos = this.contas.Select(c => c.Saldo);

        }
    }
}
