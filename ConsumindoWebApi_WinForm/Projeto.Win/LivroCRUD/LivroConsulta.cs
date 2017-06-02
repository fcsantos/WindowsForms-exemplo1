using Newtonsoft.Json;
using Projeto.Entidade;
using System;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace Projeto.Win.LivroCRUD
{
    public partial class LivroConsulta : Form
    {
        private string URL = ConfigurationManager.AppSettings["URLLivro"];

        public LivroConsulta()
        {
            InitializeComponent();
            AddButtons();
        }

        private void LivroConsulta_Load(object sender, EventArgs e)
        {
            ListarLivros();
        }

        private void AddButtons()
        {
            //ADD ExcluirButton
            DataGridViewButtonColumn btnExcluir = new DataGridViewButtonColumn();
            btnExcluir.HeaderText = "Excluir Livro";
            btnExcluir.Name = "btnExcluirLivro";
            btnExcluir.Text = "Excluir";
            btnExcluir.UseColumnTextForButtonValue = true;
            btnExcluir.Width = 80;
            dgvLivro.Columns.Add(btnExcluir);

            //ADD AtualizarButton
            DataGridViewButtonColumn btnAtualizar = new DataGridViewButtonColumn();
            btnAtualizar.HeaderText = "Atualizar Livro";
            btnAtualizar.Name = "btnAtualizarLivro";
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseColumnTextForButtonValue = true;
            btnAtualizar.Width = 85;
            dgvLivro.Columns.Add(btnAtualizar);
        }

        private void dgvLivro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var livro = new Livro();
            livro.IdLivro = (Int32)dgvLivro[0, e.RowIndex].Value;
            livro.Titulo = dgvLivro[1, e.RowIndex].Value.ToString();
            livro.ISBN = dgvLivro[2, e.RowIndex].Value.ToString();
            livro.Categoria = dgvLivro[3, e.RowIndex].Value.ToString();
            livro.Genero = dgvLivro[4, e.RowIndex].Value.ToString();
            livro.NomeAutor = dgvLivro[5, e.RowIndex].Value.ToString();
            livro.AutorId = Convert.ToInt32(dgvLivro[6, e.RowIndex].Value);
            livro.NomeEditora = dgvLivro[7, e.RowIndex].Value.ToString();
            livro.EditoraId = Convert.ToInt32(dgvLivro[8, e.RowIndex].Value);            
            livro.Sinopse = dgvLivro[9, e.RowIndex].Value.ToString();


            if (dgvLivro.Columns[e.ColumnIndex].Name == "btnExcluirLivro")
            {
                ExcluirLivro(livro.IdLivro);
            }
            if (dgvLivro.Columns[e.ColumnIndex].Name == "btnAtualizarLivro")
            {
                if (Application.OpenForms.OfType<FormHome>().Any())
                {
                    Application.OpenForms.OfType<LivroConsulta>().First().Close();
                    LivroCadastro cad = new LivroCadastro(livro);
                    cad.Show();
                }
            }

            LivroConsulta_Load(sender, e);
        }

        private async void ListarLivros()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URL + "/listar"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var LivroJsonString = await response.Content.ReadAsStringAsync();
                        dgvLivro.AutoGenerateColumns = false;
                        dgvLivro.DataSource = JsonConvert.DeserializeObject<Livro[]>(LivroJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show(("Não foi possível listar os livros" + response.StatusCode));
                    }
                }
            }
        }

        private async void ExcluirLivro(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.DeleteAsync(string.Format("{0}?id={1}", URL + "/excluir", id.ToString()));
                if (response.IsSuccessStatusCode)
                {
                    if (MessageBox.Show("Livro excluído com sucesso", "Confirmar", MessageBoxButtons.OK) == DialogResult.OK) { }
                }
                else
                {
                    MessageBox.Show("Falha ao excluir o livro  : " + response.StatusCode);
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormHome>().Any())
                Application.OpenForms.OfType<LivroConsulta>().First().Close();
        }
    }
}
