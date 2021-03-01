using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_TesteTec.Pages
{
    public partial class EditarDados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConsultar.Text))
            {
                txtConsultar.Focus();
                txtConsultar.BorderColor = Color.Red;
                txtConsultar.BackColor = Color.LightPink;
            }
            else
            {
                // Instanciando o DataContext
                DataClasseDataContext db = new DataClasseDataContext();

                //Preenchendo os dados do ID consultado
                try
                {
                    var consulta = (from p in db.Cliente
                                    where p.CLI_ID.Equals(Convert.ToInt32(txtConsultar.Text))
                                    select p).Single();

                    //Caso esteja com a cor de erro, voltara para cor padrão
                    if (txtConsultar.BackColor != Color.White)
                    {
                        lblErro.Text = "";
                        lblErro.BackColor = Color.Transparent;
                        txtNome.BackColor = Color.White;
                        txtNome.BorderColor = Color.Transparent;
                        txtConsultar.BackColor = Color.White;
                        txtConsultar.BorderColor = Color.Transparent;
                    }

                    lblID.Text = "Dados do ID: " + "<b>" + consulta.CLI_ID + "</b>";
                    lblNome.Text = "Nome: " + "<b>" + consulta.CLI_NOME + "</b>";

                    string DataNascimento = Convert.ToString(consulta.CLI_DATANASCIMENTO);
                    string DataConvertida = DataNascimento.Substring(0, DataNascimento.IndexOf("00:00:00"));

                    lblDataNasc.Text = "Data de nascimento: " + "<b>" + DataConvertida + "</b>";

                    if (consulta.CLI_ATIVO == true)
                    {
                        lblStatus.Text = "Status atual: " + "<b>Ativo</b>";
                    }
                    else
                    {
                        lblStatus.Text = "Status atual: " + "<b>Inativo</b>";
                    }
                }
                catch (Exception)
                {
                    txtConsultar.BackColor = Color.LightPink;
                    lblErro.BackColor = Color.Red;
                    lblErro.Text = "ID Inválido!";
                }
            }
        }

        protected void btnNome_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                txtNome.Focus();
                txtNome.BorderColor = Color.Red;
                txtNome.BackColor = Color.LightPink;
            }
            else
            {
                try
                {
                    // Instanciando o DataContext
                    DataClasseDataContext db = new DataClasseDataContext();

                    //Preenchendo os dados do ID consultado


                    var consulta = (from p in db.Cliente
                                    where p.CLI_ID.Equals(Convert.ToInt32(txtConsultar.Text))
                                    select p).Single();

                    //Caso esteja com a cor de erro, voltara para cor padrão
                    if (txtNome.BackColor != Color.White)
                    {
                        lblErro.Text = "";
                        lblErro.BackColor = Color.Transparent;
                        txtNome.BackColor = Color.White;
                        txtNome.BorderColor = Color.Transparent;
                        txtConsultar.BackColor = Color.White;
                        txtConsultar.BorderColor = Color.Transparent;
                    }

                    consulta.CLI_NOME = txtNome.Text;

                    db.SubmitChanges();

                    lblNome.Text = "Nome: " + "<b>" + consulta.CLI_NOME + "</b>";
                }
                catch (Exception)
                {
                    txtNome.BackColor = Color.LightPink;
                    lblErro.BackColor = Color.Red;
                    txtConsultar.BackColor = Color.LightPink;
                    lblErro.Text = "";
                }
            }
        }

        protected void btnDataNasc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDataNasc.Text))
            {
                txtDataNasc.Focus();
                txtDataNasc.BorderColor = Color.Red;
                txtDataNasc.BackColor = Color.LightPink;
            }
            else
            {
                try
                {
                    // Instanciando o DataContext
                    DataClasseDataContext db = new DataClasseDataContext();

                    //Preenchendo os dados do ID consultado


                    var consulta = (from p in db.Cliente
                                    where p.CLI_ID.Equals(Convert.ToInt32(txtConsultar.Text))
                                    select p).Single();

                    //Caso esteja com a cor de erro, voltara para cor padrão
                    if (txtDataNasc.BackColor != Color.White)
                    {
                        lblErro.Text = "";
                        lblErro.BackColor = Color.Transparent;
                        txtDataNasc.BackColor = Color.White;
                        txtDataNasc.BorderColor = Color.Transparent;
                        txtConsultar.BackColor = Color.White;
                        txtConsultar.BorderColor = Color.Transparent;
                    }

                    consulta.CLI_DATANASCIMENTO = Convert.ToDateTime(txtDataNasc.Text);

                    db.SubmitChanges();

                    string DataNascimento = Convert.ToString(consulta.CLI_DATANASCIMENTO);
                    string resultado = DataNascimento.Substring(0, DataNascimento.IndexOf("00:00:00"));
                    lblDataNasc.Text = "Data atual: " + "<b>" + resultado + "</b>";
                }
                catch (Exception)
                {
                    txtDataNasc.BackColor = Color.LightPink;
                    lblErro.BackColor = Color.Red;
                    txtConsultar.BackColor = Color.LightPink;
                    lblErro.Text = "";
                }
            }
        }

        protected void btnStatus_Click(object sender, EventArgs e)
        {
            try
            {
                // Instanciando o DataContext
                DataClasseDataContext db = new DataClasseDataContext();

                //Preenchendo os dados do ID consultado

                var consulta = (from p in db.Cliente
                                where p.CLI_ID.Equals(Convert.ToInt32(txtConsultar.Text))
                                select p).Single();

                //Caso esteja com a cor de erro, voltara para cor padrão
                if (txtConsultar.BackColor != Color.White)
                {
                    lblErro.Text = "";
                    lblErro.BackColor = Color.Transparent;
                    txtConsultar.BackColor = Color.White;
                    txtConsultar.BorderColor = Color.Transparent;
                }

                string valorEscolhido = rbStatus.SelectedValue;
                consulta.CLI_ATIVO = Convert.ToBoolean(rbStatus.SelectedValue);

                db.SubmitChanges();

                if (consulta.CLI_ATIVO == true)
                {
                    lblStatus.Text = "Status atual: " + "<b>Ativo</b>";
                }
                else
                {
                    lblStatus.Text = "Status atual: " + "<b>Inativo</b>";
                }
            }
            catch
            {
                lblErro.BackColor = Color.Red;
                txtConsultar.BackColor = Color.LightPink;
                lblErro.Text = "";
            }          
        }
    }
}