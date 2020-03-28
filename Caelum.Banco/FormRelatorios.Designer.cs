namespace Caelum.Banco
{
    partial class FormRelatorios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxContas = new System.Windows.Forms.ListBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSaldoTotal = new System.Windows.Forms.Label();
            this.lblMaiorSaldo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFiltro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 55);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.listBoxContas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(351, 272);
            this.panel2.TabIndex = 2;
            // 
            // listBoxContas
            // 
            this.listBoxContas.FormattingEnabled = true;
            this.listBoxContas.Location = new System.Drawing.Point(13, 12);
            this.listBoxContas.Name = "listBoxContas";
            this.listBoxContas.Size = new System.Drawing.Size(325, 147);
            this.listBoxContas.TabIndex = 1;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(10, 12);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(156, 31);
            this.btnFiltro.TabIndex = 0;
            this.btnFiltro.Text = "Saldo maior que 5k";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMaiorSaldo);
            this.groupBox1.Controls.Add(this.lblSaldoTotal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maior Saldo:";
            // 
            // lblSaldoTotal
            // 
            this.lblSaldoTotal.AutoSize = true;
            this.lblSaldoTotal.Location = new System.Drawing.Point(161, 28);
            this.lblSaldoTotal.Name = "lblSaldoTotal";
            this.lblSaldoTotal.Size = new System.Drawing.Size(0, 13);
            this.lblSaldoTotal.TabIndex = 2;
            // 
            // lblMaiorSaldo
            // 
            this.lblMaiorSaldo.AutoSize = true;
            this.lblMaiorSaldo.Location = new System.Drawing.Point(161, 53);
            this.lblMaiorSaldo.Name = "lblMaiorSaldo";
            this.lblMaiorSaldo.Size = new System.Drawing.Size(35, 13);
            this.lblMaiorSaldo.TabIndex = 3;
            this.lblMaiorSaldo.Text = "label4";
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 327);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBoxContas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMaiorSaldo;
        private System.Windows.Forms.Label lblSaldoTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}