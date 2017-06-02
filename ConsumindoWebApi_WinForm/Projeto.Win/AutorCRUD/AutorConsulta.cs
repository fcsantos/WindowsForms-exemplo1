using Newtonsoft.Json;
using Projeto.Entidade;
using System;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace Projeto.Win.AutorCRUD
{
    public partial class AutorConsulta : Form
    {
        private string URL = ConfigurationManager.AppSettings["URLAutor"];

        public AutorConsulta()
        {
            InitializeComponent();
            AddButtons();
        }

        private void autorConsulta_Load(object sender, EventArgs e)
        {
            ListarAutores();            
        }

        private void AddButtons()
        {
            //ADD ExcluirButton
            DataGridViewButtonColumn btnExcluir = new DataGridViewButtonColumn();
            btnExcluir.HeaderText = "Excluir Autor";
            btnExcluir.Name = "btnExcluirAutor";
            btnExcluir.Text = "Excluir";
            btnExcluir.UseColumnTextForButtonValue = true;
            btnExcluir.Width = 80;
            dgvAutor.Columns.Add(btnExcluir);

            //ADD AtualizarButton
            DataGridViewButtonColumn btnAtualizar = new DataGridViewButtonColumn();
            btnAtualizar.HeaderText = "Atualizar Autor";
            btnAtualizar.Name = "btnAtualizarAutor";
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseColumnTextForButtonValue = true;
            btnAtualizar.Width = 85;
            dgvAutor.Columns.Add(btnAtualizar);
        }

        private void dgvAutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var autor = new Autor();
            autor.IdAutor = (Int32)dgvAutor[0, e.RowIndex].Value;
            autor.Nome = dgvAutor[1, e.RowIndex].Value.ToString();

            if (dgvAutor.Columns[e.ColumnIndex].Name == "btnExcluirAutor")
            {
                ExcluirAutor(autor.IdAutor);
            }
            if (dgvAutor.Columns[e.ColumnIndex].Name == "btnAtualizarAutor")
            {
                if (Application.OpenForms.OfType<FormHome>().Any())
                {
                    Application.OpenForms.OfType<AutorConsulta>().First().Close();
                    AutorCadastro cad = new AutorCadastro(autor);
                    cad.Show();
                }
            }

            autorConsulta_Load(sender, e);
        }

        private async void ListarAutores()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URL + "/listar"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var AutorJsonString = await response.Content.ReadAsStringAsync();
                        dgvAutor.AutoGenerateColumns = false;
                        dgvAutor.DataSource = JsonConvert.DeserializeObject<Autor[]>(AutorJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show(("Não foi possível listar os autores" + response.StatusCode));
                    }
                }
            }
        }

        private async void ExcluirAutor(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.DeleteAsync(string.Format("{0}?id={1}", URL + "/excluir", id.ToString()));
                if (response.IsSuccessStatusCode)
                {
                    if (MessageBox.Show("Autor excluído com sucesso", "Confirmar", MessageBoxButtons.OK) == DialogResult.OK){}
                }
                else
                {
                    MessageBox.Show("Falha ao excluir o autor  : " + response.StatusCode);
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormHome>().Any())
                Application.OpenForms.OfType<AutorConsulta>().First().Close();
        }
    }
}
