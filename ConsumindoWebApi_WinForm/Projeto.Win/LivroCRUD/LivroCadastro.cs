using Newtonsoft.Json;
using Projeto.Entidade;
using System;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace Projeto.Win.LivroCRUD
{
    public partial class LivroCadastro : Form
    {
        private string tipoCrud = string.Empty;
        private int id = 0;

        public LivroCadastro()
        {
            InitializeComponent();
        }

        public LivroCadastro(Livro livro)
        {
            InitializeComponent();

            id = livro.IdLivro;
            txtTitulo.Text = livro.Titulo;
            txtISBN.Text = livro.ISBN;
            cbAutor.SelectedValue = livro.;
            cbEditora.SelectedValue = livro.EditoraId;
            txtCategoria.Text = livro.Categoria;
            txtGenero.Text = livro.Genero;
            txtSinopse.Text = livro.Sinopse;            
            if (livro != null)
                tipoCrud = "Editar";
        }

        private void LivroCadastro_Load(object sender, EventArgs e)
        {
            ListarEditoras();
            //cbEditora.SelectedIndex = 0;
            ListarAutores();
            //cbAutor.SelectedIndex = 0;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormHome>().Any())
                Application.OpenForms.OfType<LivroCadastro>().First().Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var livro = new Livro();
            livro.IdLivro = id;
            livro.Titulo = txtTitulo.Text;
            livro.ISBN = txtISBN.Text;
            livro.AutorId = Convert.ToInt32(cbAutor.SelectedValue);
            livro.EditoraId = Convert.ToInt32(cbEditora.SelectedValue);
            livro.Categoria = txtCategoria.Text;
            livro.Genero = txtGenero.Text;
            livro.Sinopse = txtSinopse.Text;
            CadastrarOuEditarLivro(livro);
        }

        private async void CadastrarOuEditarLivro(Livro livro)
        {
            var URL = ConfigurationManager.AppSettings["URLLivro"];
            using (var client = new HttpClient())
            {
                var serializedEditora = JsonConvert.SerializeObject(livro);
                var content = new StringContent(serializedEditora, Encoding.UTF8, "application/json");
                HttpResponseMessage responseMessage;
                if (tipoCrud == "Editar")
                    responseMessage = await client.PutAsync(URL + "/atualizar", content);
                else
                    responseMessage = await client.PostAsync(URL + "/cadastrar", content);

                if (responseMessage.IsSuccessStatusCode)
                {
                    if (MessageBox.Show("Livro cadastrado/atualizado com sucesso", "Confirmar", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        if (Application.OpenForms.OfType<FormHome>().Any())
                        {
                            Application.OpenForms.OfType<LivroCadastro>().First().Close();
                            LivroConsulta con = new LivroConsulta();
                            con.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o livro  : " + responseMessage.StatusCode);
                }
            }
        }

        private async void ListarEditoras()
        {            
            var URLEditora = ConfigurationManager.AppSettings["URLEditora"];
            
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URLEditora + "/listar"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var EditoraJsonString = await response.Content.ReadAsStringAsync();
                        cbEditora.DisplayMember = "Nome";
                        cbEditora.ValueMember = "IdEditora";                      
                        cbEditora.DataSource = JsonConvert.DeserializeObject<Editora[]>(EditoraJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show(("Não foi possível listar as editoras" + response.StatusCode));
                    }
                }
            }
        }

        private async void ListarAutores()
        {
            var URLAutor = ConfigurationManager.AppSettings["URLAutor"];

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URLAutor + "/listar"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var AutorJsonString = await response.Content.ReadAsStringAsync();
                        cbAutor.DisplayMember = "Nome";
                        cbAutor.ValueMember = "IdAutor";                       
                        cbAutor.DataSource = JsonConvert.DeserializeObject<Autor[]>(AutorJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show(("Não foi possível listar os autores" + response.StatusCode));
                    }
                }
            }
        }
    }
}
