namespace Caelum.Banco
{
    partial class FormCadastroConta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbContaPoupanca = new System.Windows.Forms.RadioButton();
            this.rbContaCorrente = new System.Windows.Forms.RadioButton();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbContaPoupanca);
            this.groupBox1.Controls.Add(this.rbContaCorrente);
            this.groupBox1.Location = new System.Drawing.Point(32, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 64);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo da conta";
            // 
            // rbContaPoupanca
            // 
            this.rbContaPoupanca.AutoSize = true;
            this.rbContaPoupanca.Location = new System.Drawing.Point(94, 29);
            this.rbContaPoupanca.Name = "rbContaPoupanca";
            this.rbContaPoupanca.Size = new System.Drawing.Size(74, 17);
            this.rbContaPoupanca.TabIndex = 3;
            this.rbContaPoupanca.Text = "Poupança";
            this.rbContaPoupanca.UseVisualStyleBackColor = true;
            // 
            // rbContaCorrente
            // 
            this.rbContaCorrente.AutoSize = true;
            this.rbContaCorrente.Checked = true;
            this.rbContaCorrente.Location = new System.Drawing.Point(23, 29);
            this.rbContaCorrente.Name = "rbContaCorrente";
            this.rbContaCorrente.Size = new System.Drawing.Size(65, 17);
            this.rbContaCorrente.TabIndex = 2;
            this.rbContaCorrente.TabStop = true;
            this.rbContaCorrente.Text = "Corrente";
            this.rbContaCorrente.UseVisualStyleBackColor = true;
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(32, 81);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(191, 20);
            this.textoTitular.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome do titular:";
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(32, 33);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.ReadOnly = true;
            this.textoNumero.Size = new System.Drawing.Size(88, 20);
            this.textoNumero.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Número:";
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(33, 198);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(190, 30);
            this.btnCadastro.TabIndex = 3;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 270);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoTitular);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCadastroConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Conta";
            this.Load += new System.EventHandler(this.FormCadastroConta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbContaPoupanca;
        private System.Windows.Forms.RadioButton rbContaCorrente;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastro;
    }
}