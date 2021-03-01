<%@ Page Title="Cadastrar Cliente" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroCliente.aspx.cs" Inherits="Web_TesteTec.IncluirExcluir" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Styles/cadastro.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="cadastro">
        <h1>Cadastro de Clientes</h1>
        <p id="nome">Nome: </p>
        <asp:TextBox ID="txtNome" runat="server" required=""></asp:TextBox>
        <p id="dataNasc">Data de Nascimento: </p>
        <asp:TextBox ID="txtDataNasc" runat="server" TextMode="Date" required=""></asp:TextBox>
        <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" OnClick="btnCadastro_Click" /><br /><br /><br />
        <asp:Label ID="lblCadastro" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
