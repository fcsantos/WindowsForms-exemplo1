using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.Win
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Sair", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void cadastroAutor_Click(object sender, EventArgs e)
        {
            AutorCRUD.AutorCadastro cad = new AutorCRUD.AutorCadastro();
            cad.Show();
        }

        private void consultaAutor_Click(object sender, EventArgs e)
        {
            AutorCRUD.AutorConsulta con = new AutorCRUD.AutorConsulta();
            con.Show();
        }

        private void cadastroEditora_Click(object sender, EventArgs e)
        {
            EditoraCRUD.EditoraCadastro cad = new EditoraCRUD.EditoraCadastro();
            cad.Show();
        }

        private void consultaEditora_Click(object sender, EventArgs e)
        {
            EditoraCRUD.EditoraConsulta con = new EditoraCRUD.EditoraConsulta();
            con.Show();
        }

        private void cadastroLivro_Click(object sender, EventArgs e)
        {
            LivroCRUD.LivroCadastro cad = new LivroCRUD.LivroCadastro();
            cad.Show();
        }

        private void consultaLivro_Click(object sender, EventArgs e)
        {
            LivroCRUD.LivroConsulta con = new LivroCRUD.LivroConsulta();
            con.Show();
        }
    }
}
