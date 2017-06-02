using Newtonsoft.Json;
using Projeto.Entidade;
using System;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace Projeto.Win.EditoraCRUD
{
    public partial class EditoraConsulta : Form
    {
        private string URL = ConfigurationManager.AppSettings["URLEditora"];

        public EditoraConsulta()
        {
            InitializeComponent();
            AddButtons();
        }

        private void EditoraConsulta_Load(object sender, EventArgs e)
        {
            ListarEditoras();
        }

        private void AddButtons()
        {
            //ADD ExcluirButton
            DataGridViewButtonColumn btnExcluir = new DataGridViewButtonColumn();
            btnExcluir.HeaderText = "Excluir Editora";
            btnExcluir.Name = "btnExcluirEditora";
            btnExcluir.Text = "Excluir";
            btnExcluir.UseColumnTextForButtonValue = true;
            btnExcluir.Width = 80;
            dgvEditora.Columns.Add(btnExcluir);

            //ADD AtualizarButton
            DataGridViewButtonColumn btnAtualizar = new DataGridViewButtonColumn();
            btnAtualizar.HeaderText = "Atualizar Editora";
            btnAtualizar.Name = "btnAtualizarEditora";
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseColumnTextForButtonValue = true;
            btnAtualizar.Width = 85;
            dgvEditora.Columns.Add(btnAtualizar);
        }

        private void dgvEditora_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var editora = new Editora();
            editora.IdEditora = (Int32)dgvEditora[0, e.RowIndex].Value;
            editora.Nome = dgvEditora[1, e.RowIndex].Value.ToString();

            if (dgvEditora.Columns[e.ColumnIndex].Name == "btnExcluirEditora")
            {
                ExcluirEditora(editora.IdEditora);
            }
            if (dgvEditora.Columns[e.ColumnIndex].Name == "btnAtualizarEditora")
            {
                if (Application.OpenForms.OfType<FormHome>().Any())
                {
                    Application.OpenForms.OfType<EditoraConsulta>().First().Close();
                    EditoraCadastro cad = new EditoraCadastro(editora);
                    cad.Show();
                }
            }

            EditoraConsulta_Load(sender, e);
        }

        private async void ListarEditoras()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URL + "/listar"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var EditoraJsonString = await response.Content.ReadAsStringAsync();
                        dgvEditora.AutoGenerateColumns = false;
                        dgvEditora.DataSource = JsonConvert.DeserializeObject<Editora[]>(EditoraJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show(("Não foi possível listar as editoras" + response.StatusCode));
                    }
                }
            }
        }

        private async void ExcluirEditora(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.DeleteAsync(string.Format("{0}?id={1}", URL + "/excluir", id.ToString()));
                if (response.IsSuccessStatusCode)
                {
                    if (MessageBox.Show("Editora excluído com sucesso", "Confirmar", MessageBoxButtons.OK) == DialogResult.OK) { }
                }
                else
                {
                    MessageBox.Show("Falha ao excluir a editora  : " + response.StatusCode);
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormHome>().Any())
                Application.OpenForms.OfType<EditoraConsulta>().First().Close();
        }
    }
}
