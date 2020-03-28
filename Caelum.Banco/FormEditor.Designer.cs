namespace Caelum.Banco
{
    partial class FormEditor
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
            this.textoEditor = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // textoEditor
            // 
            this.textoEditor.Location = new System.Drawing.Point(12, 12);
            this.textoEditor.Multiline = true;
            this.textoEditor.Name = "textoEditor";
            this.textoEditor.Size = new System.Drawing.Size(303, 309);
            this.textoEditor.TabIndex = 0;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(124, 339);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // saveFileDlg
            // 
            this.saveFileDlg.FileName = "editor.txt";
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 374);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.textoEditor);
            this.Name = "FormEditor";
            this.Text = "FormEditor";
            this.Load += new System.EventHandler(this.FormEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoEditor;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
    }
}