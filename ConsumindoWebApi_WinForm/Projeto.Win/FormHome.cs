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
            Autor.AutorCadastro cad = new Autor.AutorCadastro();
            cad.Show();
        }

        private void consultaAutor_Click(object sender, EventArgs e)
        {
            Autor.AutorConsulta con = new Autor.AutorConsulta();
            con.Show();
        }

        private void cadastroEditora_Click(object sender, EventArgs e)
        {
            Editora.EditoraCadastro cad = new Editora.EditoraCadastro();
            cad.Show();
        }

        private void consultaEditora_Click(object sender, EventArgs e)
        {
            Editora.EditoraConsulta con = new Editora.EditoraConsulta();
            con.Show();
        }

        private void cadastroLivro_Click(object sender, EventArgs e)
        {
            Livro.LivroCadastro cad = new Livro.LivroCadastro();
            cad.Show();
        }

        private void consultaLivro_Click(object sender, EventArgs e)
        {
            Livro.LivroConsulta con = new Livro.LivroConsulta();
            con.Show();
        }
    }
}
