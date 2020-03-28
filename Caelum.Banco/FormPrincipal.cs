using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Caelum.Banco.Negocio;
using Caelum.Banco.Dados;

namespace Caelum.Banco
{

    // S => Single Responsibility Principle
    public partial class FormPrincipal : Form
    {
        
        IList<Conta> contas;
        IDictionary<string, Conta> contasPorTitular;
        PersistenciaContas dados;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        public void AdicionaConta(Conta conta)
        {
            contas.Add(conta);
            contasPorTitular.Add(conta.Titular.Nome, conta);
            comboContas.Items.Add(conta);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            dados = new PersistenciaContas();
            contas = new List<Conta>();
            contasPorTitular = new Dictionary<string, Conta>();

            foreach(var conta in dados.CarregaContasDoArquivo())
            {
                this.AdicionaConta(conta);
            }
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            var form = new FormCadastroConta(this);
            form.ShowDialog();
        }

        private void AtualizaContaSelecionada()
        {
            var contaSelecionada = comboContas.SelectedItem as Conta;
            textoNumero.Text = contaSelecionada.Numero.ToString("000");
            textoTipo.Text = contaSelecionada.GetType().Name;
            textoTitular.Text = contaSelecionada.Titular.Nome;
            textoSaldo.Text = contaSelecionada.Saldo.ToString("0.00");
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.AtualizaContaSelecionada();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            var parseOk = Double.TryParse(textoValor.Text, out double valorOperacao);
            if (!parseOk)
            {
                MessageBox.Show("Valor inválido (esperado: número)");
                return;
            }
            var contaSelecionada = comboContas.SelectedItem as Conta;
            contaSelecionada.Deposita(valorOperacao);
            this.AtualizaContaSelecionada();
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            var parseOk = Double.TryParse(textoValor.Text, out double valorOperacao);
            if (!parseOk)
            {
                MessageBox.Show("Valor inválido (esperado: número)");
                return;
            }
            var contaSelecionada = comboContas.SelectedItem as Conta;

            try
            {
                contaSelecionada.Saca(valorOperacao);
            }
            catch (SaldoInsuficienteException exception)
            {
                MessageBox.Show($"Saldo estava insuficiente. Saldo Atual: {exception.SaldoAtual}, Valor Sacado: {exception.ValorSaque}");
                // throw; //rethrow >> "engolindo" as exceções
            }
            catch (Exception ex) {
                MessageBox.Show($"Ocorreu um erro diferente:{ex.Message}");
            }
            this.AtualizaContaSelecionada();
        }

        private void btnBuscaTitular_Click(object sender, EventArgs e)
        {
            string nomeTitular = textoBuscaTitular.Text;
            if (string.IsNullOrWhiteSpace(nomeTitular))
            {
                MessageBox.Show("Preencha o titular");
                return;
            }
            
            if (contasPorTitular.ContainsKey(nomeTitular))
            {
                comboContas.SelectedItem = contasPorTitular[nomeTitular];
            } else
            {
                MessageBox.Show("Titular não encontrado!");
                return;
            }
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            var form = new FormRelatorios(this.contas);
            form.ShowDialog();
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            // cria o form e mostra
            var form = new FormEditor();
            form.ShowDialog();
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            dados.SalvaContasNoArquivo(this.contas);        
        }
    }
}
