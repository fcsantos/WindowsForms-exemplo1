namespace Projeto.Win
{
    partial class FormAutor
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
            this.lblURL = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnObterAutor = new System.Windows.Forms.Button();
            this.btnObterPorId = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(13, 38);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(82, 13);
            this.lblURL.TabIndex = 0;
            this.lblURL.Text = "URL - Web Api:";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(111, 38);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(457, 20);
            this.txtURL.TabIndex = 1;
            this.txtURL.Text = "http://localhost:51558/api/autor";
            // 
            // btnObterAutor
            // 
            this.btnObterAutor.Location = new System.Drawing.Point(16, 257);
            this.btnObterAutor.Name = "btnObterAutor";
            this.btnObterAutor.Size = new System.Drawing.Size(97, 23);
            this.btnObterAutor.TabIndex = 2;
            this.btnObterAutor.Text = "Listar Autores";
            this.btnObterAutor.UseVisualStyleBackColor = true;
            this.btnObterAutor.Click += new System.EventHandler(this.btnObterAutor_Click);
            // 
            // btnObterPorId
            // 
            this.btnObterPorId.Location = new System.Drawing.Point(137, 257);
            this.btnObterPorId.Name = "btnObterPorId";
            this.btnObterPorId.Size = new System.Drawing.Size(106, 23);
            this.btnObterPorId.TabIndex = 3;
            this.btnObterPorId.Text = "Obter Autor Por Id";
            this.btnObterPorId.UseVisualStyleBackColor = true;
            this.btnObterPorId.Click += new System.EventHandler(this.btnObterPorId_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(266, 257);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 4;
            this.btnIncluir.Text = "Incluir Autor";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(364, 257);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(88, 23);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "Atualizar Autor";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(472, 257);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(96, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Deletar Autor";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(20, 82);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(548, 150);
            this.dgvDados.TabIndex = 17;
            // 
            // FormAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 302);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnObterPorId);
            this.Controls.Add(this.btnObterAutor);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblURL);
            this.Name = "FormAutor";
            this.Text = "CRUD Autor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnObterAutor;
        private System.Windows.Forms.Button btnObterPorId;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvDados;
    }
}

