namespace Projeto.Win.LivroCRUD
{
    partial class LivroConsulta
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
            this.dgvLivro = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.IdLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditoraId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sinopse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLivro
            // 
            this.dgvLivro.AllowUserToAddRows = false;
            this.dgvLivro.AllowUserToDeleteRows = false;
            this.dgvLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLivro,
            this.Titulo,
            this.ISBN,
            this.Categoria,
            this.Genero,
            this.NomeAutor,
            this.AutorId,
            this.NomeEditora,
            this.EditoraId,
            this.Sinopse});
            this.dgvLivro.Location = new System.Drawing.Point(12, 12);
            this.dgvLivro.Name = "dgvLivro";
            this.dgvLivro.ReadOnly = true;
            this.dgvLivro.Size = new System.Drawing.Size(570, 225);
            this.dgvLivro.TabIndex = 0;
            this.dgvLivro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivro_CellClick);
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
            // IdLivro
            // 
            this.IdLivro.DataPropertyName = "IdLivro";
            this.IdLivro.HeaderText = "Cód.";
            this.IdLivro.MinimumWidth = 20;
            this.IdLivro.Name = "IdLivro";
            this.IdLivro.ReadOnly = true;
            this.IdLivro.Width = 50;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Título";
            this.Titulo.MinimumWidth = 200;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 300;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.DataPropertyName = "Genero";
            this.Genero.HeaderText = "Gênero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // NomeAutor
            // 
            this.NomeAutor.DataPropertyName = "NomeAutor";
            this.NomeAutor.HeaderText = "Autor";
            this.NomeAutor.Name = "NomeAutor";
            this.NomeAutor.ReadOnly = true;
            // 
            // AutorId
            // 
            this.AutorId.DataPropertyName = "AutorId";
            this.AutorId.HeaderText = "Id autor";
            this.AutorId.Name = "AutorId";
            this.AutorId.ReadOnly = true;
            this.AutorId.Visible = false;
            // 
            // NomeEditora
            // 
            this.NomeEditora.DataPropertyName = "NomeEditora";
            this.NomeEditora.HeaderText = "Editora";
            this.NomeEditora.Name = "NomeEditora";
            this.NomeEditora.ReadOnly = true;
            // 
            // EditoraId
            // 
            this.EditoraId.DataPropertyName = "EditoraId";
            this.EditoraId.HeaderText = "Id editora";
            this.EditoraId.Name = "EditoraId";
            this.EditoraId.ReadOnly = true;
            this.EditoraId.Visible = false;
            // 
            // Sinopse
            // 
            this.Sinopse.DataPropertyName = "Sinopse";
            this.Sinopse.HeaderText = "Sinopse";
            this.Sinopse.MinimumWidth = 200;
            this.Sinopse.Name = "Sinopse";
            this.Sinopse.ReadOnly = true;
            this.Sinopse.Width = 500;
            // 
            // LivroConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 302);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvLivro);
            this.Name = "LivroConsulta";
            this.Text = "LivroConsulta";
            this.Load += new System.EventHandler(this.LivroConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLivro;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn EditoraId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sinopse;
    }
}