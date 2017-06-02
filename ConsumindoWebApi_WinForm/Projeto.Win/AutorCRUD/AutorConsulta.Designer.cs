namespace Projeto.Win.AutorCRUD
{
    partial class AutorConsulta
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
            this.dgvAutor = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.IdAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutor
            // 
            this.dgvAutor.AllowUserToAddRows = false;
            this.dgvAutor.AllowUserToDeleteRows = false;
            this.dgvAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAutor,
            this.Nome});
            this.dgvAutor.Location = new System.Drawing.Point(12, 12);
            this.dgvAutor.Name = "dgvAutor";
            this.dgvAutor.ReadOnly = true;
            this.dgvAutor.Size = new System.Drawing.Size(570, 225);
            this.dgvAutor.TabIndex = 0;
            this.dgvAutor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutor_CellClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 249);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(117, 41);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // IdAutor
            // 
            this.IdAutor.DataPropertyName = "IdAutor";
            this.IdAutor.HeaderText = "Cód.";
            this.IdAutor.MinimumWidth = 20;
            this.IdAutor.Name = "IdAutor";
            this.IdAutor.ReadOnly = true;
            this.IdAutor.Width = 50;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 100;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 310;
            // 
            // AutorConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 302);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvAutor);
            this.Name = "AutorConsulta";
            this.Text = "Autor Consulta";
            this.Load += new System.EventHandler(this.autorConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutor;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}