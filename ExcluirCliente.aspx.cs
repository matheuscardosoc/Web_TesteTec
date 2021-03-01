using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Web_TesteTec
{
    public partial class ExcluirCliente : System.Web.UI.Page
    {
        int idMemoria = 0;
        string nomeMemoria = "";
        string dataNascMemoria = "";
        bool statusMemoria;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtID.Text))
            {
                txtID.Focus();
                txtID.BorderColor = Color.Red;
                txtID.BackColor = Color.LightPink;
            }
            else
            {
                // Instanciando o DataContext
                DataClasseDataContext db = new DataClasseDataContext();

                // Consultando e preenchendo os campos
                try
                {
                    var consulta = (from p in db.Cliente
                                    where p.CLI_ID.Equals(Convert.ToInt32(txtID.Text))
                                    select p).Single();

                    idMemoria = consulta.CLI_ID;
                    nomeMemoria = consulta.CLI_NOME;
                    dataNascMemoria = Convert.ToString(consulta.CLI_DATANASCIMENTO);
                    statusMemoria = consulta.CLI_ATIVO;

                    if (txtID.BackColor != Color.White)
                    {
                        txtID.BackColor = Color.White;
                        txtID.BorderColor = Color.Transparent;
                    }

                    txtNome.Text = consulta.CLI_NOME;
                    txtDataNasc.Text = dataNascMemoria.Substring(0, dataNascMemoria.IndexOf("00:00:00"));
                    if (statusMemoria)
                    {
                        txtStatus.Text = "Ativo";
                    } else
                    {
                        txtStatus.Text = "Inativo";
                    }
                }
                catch (Exception)
                {
                    txtID.BackColor = Color.LightPink;
                }
            }
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                txtID.Focus();
                txtID.BorderColor = Color.Red;
                txtID.BackColor = Color.LightPink;
            }
            else
            {
                try
                {
                    DataClasseDataContext db = new DataClasseDataContext();

                    var consulta = (from p in db.Cliente
                                    where p.CLI_ID.Equals(Convert.ToInt32(txtID.Text))
                                    select p).Single();

                    idMemoria = consulta.CLI_ID;

                    if (consulta != null)
                    {
                        db.Cliente.DeleteOnSubmit(consulta);

                        db.SubmitChanges();

                        lblAviso.Text = "<b>Dados do Cliente id " + idMemoria + " apagados com sucesso!</b>.";
                    }
                }
                catch (Exception ex)
                {
                    lblAviso.Text = ex.Message;
                }
            }
        }
    }
}