using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_TesteTec
{
    public partial class IncluirExcluir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                // Instanciando o DataContext
                DataClasseDataContext db = new DataClasseDataContext();

                // Instanciando a classe da tabela Cliente
                Cliente cliente = new Cliente();
                cliente.CLI_NOME = txtNome.Text;
                cliente.CLI_DATANASCIMENTO = Convert.ToDateTime(txtDataNasc.Text);
                cliente.CLI_ATIVO = true;

                // Enviando as alterações para o BD
                db.Cliente.InsertOnSubmit(cliente);
                db.SubmitChanges();

                var consulta = (from p in db.Cliente
                                where p.CLI_NOME.Equals(txtNome.Text)
                                select p).Single();

                lblCadastro.Text = "<b>Cadastro realizado com Sucesso! O ID do Cliente cadastrado é: " + consulta.CLI_ID + "</b>";
            }
            catch (Exception ex)
            {
                lblCadastro.ForeColor = Color.Red;
                lblCadastro.Text = ex.Message;
            }
        }
    }
}