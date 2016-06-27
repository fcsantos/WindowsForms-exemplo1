using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace Projeto.Win.Autor
{
    public partial class AutorCadastro : Form
    {
        public AutorCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrarAutor_Click(object sender, EventArgs e)
        {
            var a = new Projeto.Entidade.Autor();
            a.Nome = txtNomeAutor.Text;
            CadastrarAutor(a);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {          
            if (Application.OpenForms.OfType<FormHome>().Any())
                Application.OpenForms.OfType<AutorCadastro>().First().Close();
        }

        private async void CadastrarAutor(Projeto.Entidade.Autor autor)
        {
            var URL = ConfigurationManager.AppSettings["URLAutor"];
            using (var client = new HttpClient())
            {
                var serializedAutor = JsonConvert.SerializeObject(autor);
                var content = new StringContent(serializedAutor, Encoding.UTF8, "application/json");
                HttpResponseMessage responseMessage = await client.PostAsync(URL + "/cadastro", content);
                if (responseMessage.IsSuccessStatusCode)
                {
                    if (MessageBox.Show("Autor cadastrado com sucesso", "Confirmar", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        AutorConsulta con = new AutorConsulta();
                        con.Show();
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
