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

namespace Caelum.Banco
{
    public partial class FormPrincipal : Form
    {
        string nomeArquivo = "contas.txt";
        IList<Conta> contas;
        IDictionary<string, Conta> contasPorTitular;

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
            contas = new List<Conta>();
            contasPorTitular = new Dictionary<string, Conta>();

            // carregar a lista de contas a partir de um arquivo
            this.CarregaContasDoArquivo();
        }

        private void CarregaContasDoArquivo()
        {
            if (File.Exists(nomeArquivo))
            {
                using (var conteudo = File.OpenRead(nomeArquivo))
                using (var leitor = new StreamReader(conteudo))
                {
                    string linha = leitor.ReadLine();
                    while (linha != null)
                    {
                        Conta conta = ConverteLinhaEmConta.Converte(linha);
                        this.AdicionaConta(conta);
                        linha = leitor.ReadLine();
                    }
                }
            }
        }

        private void SalvaContasNoArquivo()
        {
            using (var conteudo = File.OpenWrite(nomeArquivo))
            using (var escritor = new StreamWriter(conteudo))
            {
                foreach(var conta in this.contas)
                {
                    // if de uma linha só - operador ternário
                    var tipo = (conta is ContaCorrente) ? "CC" : "CP";
                    var linha = $"{conta.Numero};{conta.Titular.Nome};{conta.Saldo};{tipo}";
                    escritor.WriteLine(linha);
                }
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
            this.SalvaContasNoArquivo();
        }
    }
}
