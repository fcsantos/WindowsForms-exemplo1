namespace Projeto.Win.EditoraCRUD
{
    partial class EditoraConsulta
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
            this.dgvEditora = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.IdEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditora)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEditora
            // 
            this.dgvEditora.AllowUserToAddRows = false;
            this.dgvEditora.AllowUserToDeleteRows = false;
            this.dgvEditora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEditora,
            this.Nome});
            this.dgvEditora.Location = new System.Drawing.Point(13, 13);
            this.dgvEditora.Name = "dgvEditora";
            this.dgvEditora.ReadOnly = true;
            this.dgvEditora.Size = new System.Drawing.Size(570, 225);
            this.dgvEditora.TabIndex = 0;
            this.dgvEditora.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditora_CellClick);
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
            // IdEditora
            // 
            this.IdEditora.DataPropertyName = "IdEditora";
            this.IdEditora.HeaderText = "Cód.";
            this.IdEditora.MinimumWidth = 20;
            this.IdEditora.Name = "IdEditora";
            this.IdEditora.ReadOnly = true;
            this.IdEditora.Width = 50;
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
            // EditoraConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 302);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvEditora);
            this.Name = "EditoraConsulta";
            this.Text = "EditoraConsulta";
            this.Load += new System.EventHandler(this.EditoraConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEditora;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}