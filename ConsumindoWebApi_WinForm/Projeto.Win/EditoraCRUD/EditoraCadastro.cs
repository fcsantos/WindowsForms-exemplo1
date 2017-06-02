using Newtonsoft.Json;
using Projeto.Entidade;
using System;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace Projeto.Win.EditoraCRUD
{
    public partial class EditoraCadastro : Form
    {
        private string tipoCrud = string.Empty;
        private int id = 0;

        public EditoraCadastro()
        {
            InitializeComponent();
        }

        public EditoraCadastro(Editora editora)
        {
            InitializeComponent();

            id = editora.IdEditora;
            txtNomeEditora.Text = editora.Nome;
            if (editora != null)
                tipoCrud = "Editar";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormHome>().Any())
                Application.OpenForms.OfType<EditoraCadastro>().First().Close();
        }

        private void btnCadastrarEditora_Click(object sender, EventArgs e)
        {
            var edit = new Editora();
            edit.IdEditora = id;
            edit.Nome = txtNomeEditora.Text;
            CadastrarOuEditarEditora(edit);
        }

        private async void CadastrarOuEditarEditora(Editora editora)
        {
            var URL = ConfigurationManager.AppSettings["URLEditora"];
            using (var client = new HttpClient())
            {
                var serializedEditora = JsonConvert.SerializeObject(editora);
                var content = new StringContent(serializedEditora, Encoding.UTF8, "application/json");
                HttpResponseMessage responseMessage;
                if (tipoCrud == "Editar")
                    responseMessage = await client.PutAsync(URL + "/atualizar", content);
                else
                    responseMessage = await client.PostAsync(URL + "/cadastrar", content);

                if (responseMessage.IsSuccessStatusCode)
                {
                    if (MessageBox.Show("Editora cadastrada/atualizada com sucesso", "Confirmar", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        if (Application.OpenForms.OfType<FormHome>().Any())
                        {
                            Application.OpenForms.OfType<EditoraCadastro>().First().Close();
                            EditoraConsulta con = new EditoraConsulta();
                            con.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar a editora  : " + responseMessage.StatusCode);
                }
            }
        }
    }
}
