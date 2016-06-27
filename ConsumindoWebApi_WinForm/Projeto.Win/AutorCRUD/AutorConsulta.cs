using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.Win.Autor
{
    public partial class AutorConsulta : Form
    {
        private string URL = ConfigurationManager.AppSettings["URLAutor"];

        public AutorConsulta()
        {
            InitializeComponent();            
        }

        private void autorConsulta_Load(object sender, EventArgs e)
        {
            ListarAutores();
            AddButtons();
        }

        private void AddButtons()
        {
            //ADD ExcluirButton
            DataGridViewButtonColumn btnExcluir = new DataGridViewButtonColumn();
            btnExcluir.HeaderText = "Excluir Autor";
            btnExcluir.Name = "btnExcluirAutor";
            btnExcluir.Text = "Excluir";
            btnExcluir.UseColumnTextForButtonValue = true;
            dgvAutor.Columns.Add(btnExcluir);

            //ADD ExcluirButton
            DataGridViewButtonColumn btnAtualizar = new DataGridViewButtonColumn();
            btnAtualizar.HeaderText = "Atualizar Autor";
            btnAtualizar.Name = "btnAtualizarAutor";
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseColumnTextForButtonValue = true;
            dgvAutor.Columns.Add(btnAtualizar);

            dgvAutor.CellClick += new DataGridViewCellEventHandler(dgvAutor_CellClick);
        }

        private void dgvAutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var IdAutor = (Int32)dgvAutor[0, e.RowIndex].Value;

            if (dgvAutor.Columns[e.ColumnIndex].Name == "btnExcluirAutor")
            {
                ExcluirAutor(IdAutor);
            }
            if (dgvAutor.Columns[e.ColumnIndex].Name == "btnAtualizarAutor")
            {
                AutorCadastro cad = new AutorCadastro();
                cad.Show();
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
                        dgvAutor.DataSource = JsonConvert.DeserializeObject<Projeto.Entidade.Autor[]>(AutorJsonString).ToList();
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
                    MessageBox.Show("Autor excluído com sucesso");
                }
                else
                {
                    MessageBox.Show("Falha ao excluir o autor  : " + response.StatusCode);
                }
            }
        }
    }
}
