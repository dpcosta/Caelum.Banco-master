namespace Caelum.Banco
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaque = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.textoTipo = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscaTitular = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textoBuscaTitular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnNova = new System.Windows.Forms.Button();
            this.btnEditor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textoValor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSaque);
            this.groupBox1.Controls.Add(this.btnDeposito);
            this.groupBox1.Controls.Add(this.textoTipo);
            this.groupBox1.Controls.Add(this.textoSaldo);
            this.groupBox1.Controls.Add(this.textoTitular);
            this.groupBox1.Controls.Add(this.textoNumero);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 220);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta Selecionada";
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(27, 140);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(237, 20);
            this.textoValor.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Valor:";
            // 
            // btnSaque
            // 
            this.btnSaque.Location = new System.Drawing.Point(189, 175);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(75, 23);
            this.btnSaque.TabIndex = 14;
            this.btnSaque.Text = "Sacar";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(108, 175);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(75, 23);
            this.btnDeposito.TabIndex = 13;
            this.btnDeposito.Text = "Depositar";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // textoTipo
            // 
            this.textoTipo.Location = new System.Drawing.Point(79, 47);
            this.textoTipo.Name = "textoTipo";
            this.textoTipo.ReadOnly = true;
            this.textoTipo.Size = new System.Drawing.Size(93, 20);
            this.textoTipo.TabIndex = 12;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(180, 47);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.ReadOnly = true;
            this.textoSaldo.Size = new System.Drawing.Size(84, 20);
            this.textoSaldo.TabIndex = 11;
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(27, 91);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.ReadOnly = true;
            this.textoTitular.Size = new System.Drawing.Size(237, 20);
            this.textoTitular.TabIndex = 10;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(27, 47);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.ReadOnly = true;
            this.textoNumero.Size = new System.Drawing.Size(44, 20);
            this.textoNumero.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Saldo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Titular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Número:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscaTitular);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textoBuscaTitular);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comboContas);
            this.groupBox3.Location = new System.Drawing.Point(15, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 143);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Busca de Contas";
            // 
            // btnBuscaTitular
            // 
            this.btnBuscaTitular.Location = new System.Drawing.Point(189, 90);
            this.btnBuscaTitular.Name = "btnBuscaTitular";
            this.btnBuscaTitular.Size = new System.Drawing.Size(75, 23);
            this.btnBuscaTitular.TabIndex = 5;
            this.btnBuscaTitular.Text = "Buscar";
            this.btnBuscaTitular.UseVisualStyleBackColor = true;
            this.btnBuscaTitular.Click += new System.EventHandler(this.btnBuscaTitular_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Busca por titular:";
            // 
            // textoBuscaTitular
            // 
            this.textoBuscaTitular.Location = new System.Drawing.Point(27, 92);
            this.textoBuscaTitular.Name = "textoBuscaTitular";
            this.textoBuscaTitular.Size = new System.Drawing.Size(156, 20);
            this.textoBuscaTitular.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Escolha a Conta:";
            // 
            // comboContas
            // 
            this.comboContas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(27, 47);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(237, 21);
            this.comboContas.Sorted = true;
            this.comboContas.TabIndex = 0;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditor);
            this.panel1.Controls.Add(this.btnRelatorios);
            this.panel1.Controls.Add(this.btnNova);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 50);
            this.panel1.TabIndex = 10;
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Location = new System.Drawing.Point(98, 15);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(75, 23);
            this.btnRelatorios.TabIndex = 11;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnNova
            // 
            this.btnNova.Location = new System.Drawing.Point(15, 15);
            this.btnNova.Name = "btnNova";
            this.btnNova.Size = new System.Drawing.Size(75, 23);
            this.btnNova.TabIndex = 10;
            this.btnNova.Text = "Nova Conta";
            this.btnNova.UseVisualStyleBackColor = true;
            this.btnNova.Click += new System.EventHandler(this.btnNova_Click);
            // 
            // btnEditor
            // 
            this.btnEditor.Location = new System.Drawing.Point(179, 15);
            this.btnEditor.Name = "btnEditor";
            this.btnEditor.Size = new System.Drawing.Size(75, 23);
            this.btnEditor.TabIndex = 12;
            this.btnEditor.Text = "Editor";
            this.btnEditor.UseVisualStyleBackColor = true;
            this.btnEditor.Click += new System.EventHandler(this.btnEditor_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco Caelum - 879";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.TextBox textoTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscaTitular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textoBuscaTitular;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNova;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnEditor;
    }
}

