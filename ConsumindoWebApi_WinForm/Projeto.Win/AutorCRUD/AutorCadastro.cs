using Newtonsoft.Json;
using Projeto.Entidade;
using System;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace Projeto.Win.AutorCRUD
{
    public partial class AutorCadastro : Form
    {
        private string tipoCrud = string.Empty;
        private int id = 0;

        public AutorCadastro()
        {
            InitializeComponent();
        }

        public AutorCadastro(Autor autor)
        {            
            InitializeComponent();

            id = autor.IdAutor;
            txtNomeAutor.Text = autor.Nome;            
            if (autor != null)
                tipoCrud = "Editar";
        }

        private void btnCadastrarAutor_Click(object sender, EventArgs e)
        {
            var a = new Autor();
            a.IdAutor = id;
            a.Nome = txtNomeAutor.Text;
            CadastrarOuEditarAutor(a);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {          
            if (Application.OpenForms.OfType<FormHome>().Any())
                Application.OpenForms.OfType<AutorCadastro>().First().Close();
        }

        private async void CadastrarOuEditarAutor(Autor autor)
        {
            var URL = ConfigurationManager.AppSettings["URLAutor"];
            using (var client = new HttpClient())
            {
                var serializedAutor = JsonConvert.SerializeObject(autor);
                var content = new StringContent(serializedAutor, Encoding.UTF8, "application/json");
                HttpResponseMessage responseMessage;
                if (tipoCrud == "Editar")
                    responseMessage = await client.PutAsync(URL + "/atualizar", content);
                else
                    responseMessage = await client.PostAsync(URL + "/cadastro", content);

                if (responseMessage.IsSuccessStatusCode)
                {
                    if (MessageBox.Show("Autor cadastrado/atualizado com sucesso", "Confirmar", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        if (Application.OpenForms.OfType<FormHome>().Any())
                        {
                            Application.OpenForms.OfType<AutorCadastro>().First().Close();
                            AutorConsulta con = new AutorConsulta();
                            con.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o autor  : " + responseMessage.StatusCode);
                }
            }
        }
    }
}
