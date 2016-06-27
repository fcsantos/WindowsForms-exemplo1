using Newtonsoft.Json;
using Projeto.Entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Projeto.Win
{
    public partial class FormAutor : Form
    {
        public FormAutor()
        {
            InitializeComponent();
        }

        private string URL = "";
        private int codigoAutor = -1;

        private void btnObterAutor_Click(object sender, EventArgs e)
        {
            ListarAutores();
        }

        private void btnObterPorId_Click(object sender, EventArgs e)
        {
            InformarCodigoAutor();
            if (codigoAutor != -1)
            {
                ListarAutorPorId(codigoAutor);
            }            
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            CadastrarAutor();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            InformarCodigoAutor();
            if (codigoAutor != -1)
            {
                AtualizarAutor(codigoAutor);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            InformarCodigoAutor();
            if (codigoAutor != -1)
            {
                ExcluirAutor(codigoAutor);
            }
        }

        private void InformarCodigoAutor()
        {
            var prompt = "Informe o Código do Autor";
            var titulo = "Tecle ESC para Cancelar";
            var respostaPadrao = "-1";
            var valorRetornado = "";

            valorRetornado = Interaction.InputBox(prompt, titulo, respostaPadrao, 200, 400);
            codigoAutor = Convert.ToInt32(valorRetornado);
        }

        private async void ListarAutores()
        {
            URL = txtURL.Text;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URL + "/listar"))
                {                    
                    if (response.IsSuccessStatusCode)
                    {
                        var AutorJsonString = await response.Content.ReadAsStringAsync();
                        dgvDados.DataSource = JsonConvert.DeserializeObject<Projeto.Entidade.Autor[]>(AutorJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show(("Não foi possível listar os autores" + response.StatusCode));
                    }
                }
            }

        }

        private async void ListarAutorPorId(int id)
        {
            using(var client = new HttpClient())
            {
                var bsDados = new BindingSource();
                URL = txtURL.Text + "/obter";
                using(var response = await client.GetAsync(string.Format("{0}?id={1}", URL, id.ToString())))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var AutorJsonString = await response.Content.ReadAsStringAsync();
                        bsDados.DataSource = JsonConvert.DeserializeObject<Projeto.Entidade.Autor>(AutorJsonString);
                        dgvDados.DataSource = bsDados;
                    }
                    else
                    {
                        MessageBox.Show(("Falha ao obter o autor: " + response.StatusCode));
                    }
                }
            }
        }

        private async void CadastrarAutor()
        {
            URL = txtURL.Text;
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(URL + "/listar");
                var AutorJsonString = await response.Content.ReadAsStringAsync();
                var ultimoAutor = JsonConvert.DeserializeObject<Projeto.Entidade.Autor[]>(AutorJsonString).Count();
                ultimoAutor += 1;
                var a = new Projeto.Entidade.Autor();
                a.Nome = "Autor " + ultimoAutor;

                var serializedAutor = JsonConvert.SerializeObject(a);
                var content = new StringContent(serializedAutor, Encoding.UTF8, "application/json");
                HttpResponseMessage responseMessage = await client.PostAsync(URL + "/cadastro", content);
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Autor cadastrado com sucesso");
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o autor  : " + responseMessage.StatusCode);
                }
            }
            ListarAutores();
        }

        private async void AtualizarAutor(int id)
        {
            URL = txtURL.Text;
            using(var client = new HttpClient())
            {
                var response = await client.GetAsync(URL + "/listar");
                var AutorJsonString = await response.Content.ReadAsStringAsync();
                var ultimoAutor = JsonConvert.DeserializeObject<Projeto.Entidade.Autor[]>(AutorJsonString).Count();
                ultimoAutor += 100;
                var a = new Projeto.Entidade.Autor();
                a.IdAutor = id;
                a.Nome = "Autor " + ultimoAutor;

                var serializedAutor = JsonConvert.SerializeObject(a);
                var content = new StringContent(serializedAutor, Encoding.UTF8, "application/json");
                HttpResponseMessage responseMessage = await client.PutAsync(URL + "/atualizar", content);
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Autor atualizado com sucesso");
                }
                else
                {
                    MessageBox.Show("Falha ao atualizar o autor  : " + responseMessage.StatusCode);
                }
            }
            ListarAutores();
        }

        private async void ExcluirAutor(int id)
        {
            using(var client = new HttpClient())
            {
                URL = txtURL.Text + "/excluir";
                var response = await client.DeleteAsync(String.Format("{0}?id={1}", URL, id.ToString()));
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Autor excluído com sucesso");
                }
                else
                {
                    MessageBox.Show("Falha ao excluir o autor  : " + response.StatusCode);
                }
            }
            ListarAutores();
        }       
    }
}
