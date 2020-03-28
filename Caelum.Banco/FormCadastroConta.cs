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
using Caelum.Banco.Busca;

namespace Caelum.Banco
{
    public partial class FormCadastroConta : Form
    {
        FormPrincipal formPrincipal;
        ICollection<string> devedores;

        public FormCadastroConta(FormPrincipal form)
        {
            InitializeComponent();
            formPrincipal = form;
            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraLista();
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            textoNumero.Text = Conta.ProximoNumero.ToString("000");
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textoTitular.Text))
            {
                MessageBox.Show("Preencha o nome do titular!");
                return; // sai do método
            }

            if (this.devedores.Contains(textoTitular.Text))
            {
                MessageBox.Show($"Não é possível criar a conta. Motivo: Titular da conta é devedor.");
                return;
            }

            Conta novaConta;
            if (rbContaCorrente.Checked) 
                novaConta = new ContaCorrente(textoTitular.Text);
            else novaConta = new ContaPoupanca(textoTitular.Text);

            formPrincipal.AdicionaConta(novaConta);
            this.Close();
        }

    }
}
