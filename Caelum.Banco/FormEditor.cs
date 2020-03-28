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

namespace Caelum.Banco
{
    public partial class FormEditor : Form
    {
        private string nomeArquivo = "texto.txt";

        public FormEditor()
        {
            InitializeComponent();
        }

        private void FormEditor_Load(object sender, EventArgs e)
        {
            if (File.Exists(nomeArquivo))
            {
                using (Stream conteudo = new FileStream(nomeArquivo, FileMode.Open, FileAccess.Read))
                using (StreamReader leitor = new StreamReader(conteudo))
                {
                    string linha = leitor.ReadLine();
                    while (linha != null)
                    {
                        textoEditor.Text += $"{linha}\r\n";
                        linha = leitor.ReadLine();
                    }
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            // FPuts(nomeArquivo, textoEditor.Text);

            // File.AppendAllText(nomeArquivo, textoEditor.Text);

            DialogResult resultado = saveFileDlg.ShowDialog();
            if (resultado != DialogResult.Cancel)
            {
                var arquivo = saveFileDlg.FileName;
                using (Stream conteudo = new FileStream(arquivo, FileMode.Create, FileAccess.Write))
                using (StreamWriter escritor = new StreamWriter(conteudo))
                {
                    escritor.WriteLine(textoEditor.Text);
                    //while (linha != null)
                    //{

                    //    linha = escritor.ReadLine();
                    //}
                }
            }



            
        }
    }
}
