namespace Projeto.Win.AutorCRUD
{
    partial class AutorCadastro
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
            this.lblNomeAutor = new System.Windows.Forms.Label();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.btnCadastrarAutor = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblCodAutor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomeAutor
            // 
            this.lblNomeAutor.AutoSize = true;
            this.lblNomeAutor.Location = new System.Drawing.Point(31, 35);
            this.lblNomeAutor.Name = "lblNomeAutor";
            this.lblNomeAutor.Size = new System.Drawing.Size(81, 13);
            this.lblNomeAutor.TabIndex = 0;
            this.lblNomeAutor.Text = "Nome do Autor:";
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Location = new System.Drawing.Point(154, 35);
            this.txtNomeAutor.MaxLength = 150;
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(375, 20);
            this.txtNomeAutor.TabIndex = 1;
            // 
            // btnCadastrarAutor
            // 
            this.btnCadastrarAutor.Location = new System.Drawing.Point(411, 165);
            this.btnCadastrarAutor.Name = "btnCadastrarAutor";
            this.btnCadastrarAutor.Size = new System.Drawing.Size(117, 41);
            this.btnCadastrarAutor.TabIndex = 2;
            this.btnCadastrarAutor.Text = "Salvar";
            this.btnCadastrarAutor.UseVisualStyleBackColor = true;
            this.btnCadastrarAutor.Click += new System.EventHandler(this.btnCadastrarAutor_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(248, 165);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(117, 41);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblCodAutor
            // 
            this.lblCodAutor.AutoSize = true;
            this.lblCodAutor.Location = new System.Drawing.Point(34, 13);
            this.lblCodAutor.Name = "lblCodAutor";
            this.lblCodAutor.Size = new System.Drawing.Size(0, 13);
            this.lblCodAutor.TabIndex = 4;
            // 
            // AutorCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 302);
            this.Controls.Add(this.lblCodAutor);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrarAutor);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.lblNomeAutor);
            this.Name = "AutorCadastro";
            this.Text = "Autor Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeAutor;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.Button btnCadastrarAutor;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblCodAutor;
    }
}