﻿namespace Projeto.Win.EditoraCRUD
{
    partial class EditoraCadastro
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
            this.lblNomeEditora = new System.Windows.Forms.Label();
            this.txtNomeEditora = new System.Windows.Forms.TextBox();
            this.btnCadastrarEditora = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeEditora
            // 
            this.lblNomeEditora.AutoSize = true;
            this.lblNomeEditora.Location = new System.Drawing.Point(31, 35);
            this.lblNomeEditora.Name = "lblNomeEditora";
            this.lblNomeEditora.Size = new System.Drawing.Size(89, 13);
            this.lblNomeEditora.TabIndex = 0;
            this.lblNomeEditora.Text = "Nome da Editora:";
            // 
            // txtNomeEditora
            // 
            this.txtNomeEditora.Location = new System.Drawing.Point(154, 35);
            this.txtNomeEditora.MaxLength = 150;
            this.txtNomeEditora.Name = "txtNomeEditora";
            this.txtNomeEditora.Size = new System.Drawing.Size(376, 20);
            this.txtNomeEditora.TabIndex = 1;
            // 
            // btnCadastrarEditora
            // 
            this.btnCadastrarEditora.Location = new System.Drawing.Point(411, 165);
            this.btnCadastrarEditora.Name = "btnCadastrarEditora";
            this.btnCadastrarEditora.Size = new System.Drawing.Size(117, 41);
            this.btnCadastrarEditora.TabIndex = 2;
            this.btnCadastrarEditora.Text = "Salvar";
            this.btnCadastrarEditora.UseVisualStyleBackColor = true;
            this.btnCadastrarEditora.Click += new System.EventHandler(this.btnCadastrarEditora_Click);
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
            // EditoraCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 302);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrarEditora);
            this.Controls.Add(this.txtNomeEditora);
            this.Controls.Add(this.lblNomeEditora);
            this.Name = "EditoraCadastro";
            this.Text = "Editora Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeEditora;
        private System.Windows.Forms.TextBox txtNomeEditora;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastrarEditora;
    }
}